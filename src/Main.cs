using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

using HarmonyLib;

using SFS.Parts;
using SFS.Parts.Modules;
using SFS.Translations;

namespace SFSEX.PartsInjector
{
    public class Main : ModLoader.SFSMod
    {
        public Main() : base("SFSEX.PartsInjector", "Parts Injector", "Exund", "v1.x.x", "v0.0.1", "")
        {
        }

        public override void early_load()
        {
            var harmony = new Harmony("SFSEX.PartsInjector");
            harmony.PatchAll();

            Loc.OnChange += () =>
            {
                foreach (var (fieldRef, field, _) in Utils.Translations.translations.Values)
                {
                    Loc.fields[fieldRef] = field;
                }
            };
        }

        public override void load()
        {
        }

        public override void unload()
        {
        }

        public static class Patches
        {
            public static class PartsLoader
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
        }
    }
}
