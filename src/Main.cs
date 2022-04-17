using System;
using System.Collections.Generic;
using System.Linq;

using HarmonyLib;

using SFS.Translations;

namespace SFSEX.PartsInjector
{
    public class Main : ModLoader.SFSMod
    {
        public Main() : base("SFSEX.PartsInjector", "Parts Injector", "Exund", "v1.x.x", "v0.0.2", "")
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
    }
}
