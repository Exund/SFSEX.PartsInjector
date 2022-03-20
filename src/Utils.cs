using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;

using UnityEngine;

using SFS.Translations;
using SFS.Variables;

namespace SFSEX.PartsInjector.Utils
{
    public static class Variables
    {
        private static readonly FieldInfo stringVariableName = AccessTools.Field(typeof(ReferenceVariable<string>), "variableName");


        private static void AssignName<T>(ReferenceVariable<T> variable, string name)
        {
            AccessTools.Field(typeof(ReferenceVariable<T>), "variableName").SetValue(variable, name);
        }

        public static String_Reference CreateStringRef(string name = "", VariablesModule variables = null)
        {
            var variable = new String_Reference()
            {
                referenceToVariables = variables
            };

            AssignName(variable, name);

            var _ = variable.Value;

            return variable;
        }

        public static Bool_Reference CreateBoolRef(string name = "", VariablesModule variables = null)
        {
            var variable = new Bool_Reference()
            {
                referenceToVariables = variables
            };

            AssignName(variable, name);

            var _ = variable.Value;

            return variable;
        }

        public static Double_Reference CreateDoubleRef(string name = "", VariablesModule variables = null)
        {
            var variable = new Double_Reference()
            {
                referenceToVariables = variables
            };

            AssignName(variable, name);

            var _ = variable.Value;

            return variable;
        }

        public static Float_Reference CreateFloatRef(string name = "", VariablesModule variables = null)
        {
            var variable = new Float_Reference()
            {
                referenceToVariables = variables
            };

            AssignName(variable, name);

            var _ = variable.Value;

            return variable;
        }
    }

    public static class Translations
    {
        private static readonly FieldInfo TranslatableName = AccessTools.Field(typeof(TranslationVariable), "TranslatableName");

        internal static Dictionary<string, (FieldReference, Field, TranslationVariable)> translations = new Dictionary<string, (FieldReference, Field, TranslationVariable)>();

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
