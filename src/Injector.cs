using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

using SFS;
using SFS.Parts;
using SFS.Parts.Modules;

namespace SFSEX.PartsInjector
{
    public static class Injector
    {
        private static Dictionary<string, Part> customParts = new Dictionary<string, Part>();

        public static Action Ready;

        public static void RegisterPart(Part part)
        {
            if (customParts.ContainsKey(part.name))
            {
                Debug.LogWarning($"Custom Part \"{part.name}\" already exists");
                return;
            }

            GameObject.DontDestroyOnLoad(part);

            customParts.Add(part.name, part);
        }

        internal static void InjectParts()
        {
            var parts = Base.partsLoader.parts;
            var variants = Base.partsLoader.partVariants;

            foreach (Part part in customParts.Values)
            {
                if (parts.ContainsKey(part.name))
                {
                    Debug.LogWarning($"Custom Part \"{part.name}\" not injected due to conflict with existing part");
                    continue;
                }   

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
        }
    }
}
