using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using UnityEngine;

using SFS;
using SFS.Parts;
using SFS.Parts.Modules;

namespace SFSEX.PartsInjector
{
    public static class Injector
    {
        private static Dictionary<string, Part> customParts = new Dictionary<string, Part>();
        private static Dictionary<string, Action<SFS.Parts.Part, SFS.Parts.UsePartData>> onPartUsedHandlers = new Dictionary<string, Action<SFS.Parts.Part, SFS.Parts.UsePartData>>();

        private static void Inject(Part part)
        {
            GameObject.DontDestroyOnLoad(part);

            customParts.Add(part.name, part);
            Base.partsLoader.parts.Add(part.name, part);

            var variants = Base.partsLoader.partVariants;
            for (int i = 0; i < part.variants.Length; i++)
            {
                for (int j = 0; j < part.variants[i].variants.Length; j++)
                {
                    VariantRef variantRef = new VariantRef(part, i, j);
                    variants.Add(variantRef.GetNameID(), variantRef);
                }
            }

            Debug.Log($"Custom Part \"{part.name}\" injected");
        }

        private static bool VerifyPart(Part part)
        {
            if (customParts.ContainsKey(part.name))
            {
                Debug.LogWarning($"Custom Part \"{part.name}\" already exists");
                return false;
            }

            if (Base.partsLoader.parts.ContainsKey(part.name))
            {
                Debug.LogWarning($"Custom Part \"{part.name}\" not injected due to conflict with existing part");
                return false;
            }

            return true;
        }

        public static void RegisterPart(Part part, Action<SFS.Parts.Part, SFS.Parts.UsePartData> onPartUsed)
        {
            if (VerifyPart(part))
            {
                if (onPartUsed != null)
                {
                    onPartUsedHandlers.Add(part.name, onPartUsed);
                }

                Inject(part);
            }
        }

        public static void RegisterPart(Part part)
        {
            if (VerifyPart(part))
            {
                Inject(part);
            }
        }

        static class Patches
        {
            static class PartsLoader
            {
                [HarmonyPatch(typeof(SFS.Parts.PartsLoader), "CreatePart", typeof(Part), typeof(Action<Part>), typeof(Action<Part>))]
                static class CreatePart
                {
                    private static readonly MethodInfo set_name = typeof(UnityEngine.Object).GetProperty("name").SetMethod;

                    public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
                    {
                        var codes = instructions.ToList();
                        var i = codes.FindIndex(ci => ci.Calls(set_name)) - 3;
                        codes.InsertRange(i, new CodeInstruction[]
                        {
                            new CodeInstruction(OpCodes.Ldloc_0),
                            new CodeInstruction(OpCodes.Ldarg_0),
                            new CodeInstruction(OpCodes.Call, typeof(CreatePart).GetMethod(nameof(CopyVars)))
                        });

                        return codes;
                    }

                    public static void CopyVars(Part copy, Part prefab)
                    {
                        var pvars = prefab.variablesModule;
                        var cvars = copy.variablesModule;
                        var save = (true, true);
                        cvars.boolVariables.LoadDictionary(pvars.boolVariables.GetSaveDictionary(), save);
                        cvars.doubleVariables.LoadDictionary(pvars.doubleVariables.GetSaveDictionary(), save);
                        cvars.stringVariables.LoadDictionary(pvars.stringVariables.GetSaveDictionary(), save);

                        copy.gameObject.SetActive(true);
                    }
                }
            }

            static class Rocket
            {
                [HarmonyPatch(typeof(SFS.World.Rocket), "UseParts")]
                static class UseParts
                {
                    public static void Postfix(Part[] regions, ref UsePartData[] __result)
                    {
                        for (int i = 0; i < regions.Length; i++)
                        {
                            var p = regions[i];
                            if (onPartUsedHandlers.TryGetValue(p.name, out var handler))
                            {
                                handler(p, __result[i]);
                            }
                        }
                    }
                }
            }
        }
    }
}
