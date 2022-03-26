using System;
using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using UnityEngine;

using SFS.Variables;

namespace SFSEX.PartsInjector.Utils
{
    public static class Variables
    {
        private static void AssignName<T>(ReferenceVariable<T> variable, string name)
        {
            AccessTools.Field(typeof(ReferenceVariable<T>), "variableName").SetValue(variable, name);

            var _ = variable.Value;
        }

        public static String_Reference CreateStringRef(string name = "", VariablesModule variables = null)
        {
            var variable = new String_Reference()
            {
                referenceToVariables = variables,
            };

            AssignName(variable, name);

            return variable;
        }

        public static Bool_Reference CreateBoolRef(string name = "", VariablesModule variables = null)
        {
            var variable = new Bool_Reference()
            {
                referenceToVariables = variables
            };

            AssignName(variable, name);

            return variable;
        }

        public static Double_Reference CreateDoubleRef(string name = "", VariablesModule variables = null)
        {
            var variable = new Double_Reference()
            {
                referenceToVariables = variables
            };

            AssignName(variable, name);

            return variable;
        }

        public static Float_Reference CreateFloatRef(string name = "", VariablesModule variables = null)
        {
            var variable = new Float_Reference()
            {
                referenceToVariables = variables
            };

            AssignName(variable, name);

            return variable;
        }

        private static void AssignVariables<T>(Composed<T> composed, VariablesModule variables)
        {
            AccessTools.Field(typeof(Composed<T>), "variables").SetValue(composed, variables);
        }

        /// <summary>
        /// Create a new composed variable with a defined equation
        /// </summary>
        /// <param name="input">Equation</param>
        /// <param name="variables"></param>
        /// <returns></returns>
        public static Composed_Float CreateComposedFloat(string input, VariablesModule variables = null)
        {
            var composed = new Composed_Float(input);

            AssignVariables(composed, variables);

            return composed;
        }

        public static Composed_Double CreateComposedDouble(string input, VariablesModule variables = null)
        {
            var composed = new Composed_Double()
            {
                input = input
            };

            AssignVariables(composed, variables);

            return composed;
        }
    }
}
