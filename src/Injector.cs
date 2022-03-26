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

        public static void RegisterPart(Part part)
        {
            if (customParts.ContainsKey(part.name))
            {
                Debug.LogWarning($"Custom Part \"{part.name}\" already exists");
                return;
            }

            var parts = Base.partsLoader.parts;
            if (parts.ContainsKey(part.name))
            {
                Debug.LogWarning($"Custom Part \"{part.name}\" not injected due to conflict with existing part");
                return;
            }

            GameObject.DontDestroyOnLoad(part);

            customParts.Add(part.name, part);
            parts.Add(part.name, part);

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
    }
}
