using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using UnityEngine;

using SFS.Translations;

namespace SFSEX.PartsInjector.Utils
{
    public static class Translations
    {
        private static readonly FieldInfo TranslatableName = AccessTools.Field(typeof(TranslationVariable), "TranslatableName");

        internal static Dictionary<string, (FieldReference, Field, TranslationVariable)> translations = new Dictionary<string, (FieldReference, Field, TranslationVariable)>();

        /// <summary>
        /// Create a new translation and returns a reference variable
        /// </summary>
        /// <param name="name">Variable name</param>
        /// <param name="translation">Translation values <para>Use <see cref="SFS.Translations.Field.Text(string)"/> for simple values</para></param>
        /// <returns></returns>
        public static TranslationVariable AddTranslation(string name, Field translation)
        {
            if (translations.TryGetValue(name, out var t))
            {
                Debug.LogWarning($"Translation \"${name}\" already exists");
                return t.Item3;
            }

            var fieldRef = new FieldReference(name, "");
            var transVar = new TranslationVariable()
            {
                field = translation
            };
            TranslatableName.SetValue(transVar, name);

            translations.Add(name, (fieldRef, translation, transVar));

            Loc.fields[fieldRef] = translation;

            return transVar;
        }

        public static TranslationVariable GetTranslation(string name)
        {
            if (translations.TryGetValue(name, out var t))
            {
                return t.Item3;
            }

            Debug.LogWarning($"Translation \"${name}\" doesn't exists");
            return new TranslationVariable();
        }
    }
}
