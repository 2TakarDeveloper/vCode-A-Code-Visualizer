﻿
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;

namespace Core.Converter
{
    public  class VCodeToCode
    {
        public string Code { get; private set; }

        public VCodeToCode(VCode vcode)
        {
            Code = "";
            VCodeToString(vcode);
            
        }

        private void VariableToCode(Variable variable)
        {
         
            Code += variable.AccessModifier.ToString().ToLower()+" ";
            Code += variable.Type.ToString().ToLower()+" ";
            Code += variable.Name+" ";
            Code += "="+" ";
            if (variable.IsArray)
            {
                Code += "{";

                switch (variable.ArrayType)
                {
                    case "1D":
                        for (int i = 0; i < variable.Row; i++)
                        {
                            Code += variable.Value[i, 0].ToString()+",";
                        }
                        Code = Code.Remove(Code.Length - 1);
                        break;
                    case "2D":
                        for (int i = 0; i < variable.Row; i++)
                        {
                            Code += "{";
                            for (int j = 0; j < variable.Column; j++)
                            {
                                Code += variable.Value[i, j].ToString()+",";
                            }
                            Code = Code.Remove(Code.Length - 1);
                            Code += "},";
                        }

                        Code = Code.Remove(Code.Length - 1);
                        break;
                }

                Code += "}";

            }
            else
            {
                Code += variable.Value[0, 0].ToString();
            }




            Code += ";";
        }

        private void VCodeToString(VCode vcode)
        {

            if (vcode.VType == Enums.VType.GlobalScope)
            {
                var globalScope = (GlobalScope)vcode;
                GlobalScopeToCode(globalScope.Scope);

            }


            if (vcode.VType == Enums.VType.Variable)
            {
                Variable variable = (Variable) vcode;
                VariableToCode(variable);
            }


            if (vcode.VType == Enums.VType.If)
            {
                var If = (If) vcode;
                Code += "if";
                ConditionToCode(If.Condition);
                ScopeToCode(If.Scope);
                
            }

            if (vcode.VType == Enums.VType.While)
            {
                var wWhile = (While) vcode;
                Code += "while";
                ConditionToCode(wWhile.Condition);
                ScopeToCode(wWhile.Scope);

            }


            if (vcode.VType == Enums.VType.Function)
            {
                var function = (Function) vcode;
                Code += function.AccessModifier.ToString().ToLower() + " ";
                Code += function.Type.ToString().ToLower() + " ";
                Code += function.Name;
                Code += "(";
                string parameter = "";

                if (function.Parameters != null)
                {
                    foreach (Parameter p in function.Parameters)
                    {
                        parameter += p.Type + " " + p.Name + ",";
                    }
                    parameter =parameter.Remove(parameter.Length-1);
                }


                Code += parameter;
                Code += ")";


                if (function.IsBody)
                {
                    ScopeToCode(function.Scope);
                }
                else
                {
                    Code +=";";
                }
        }

            
        }

        private  void ScopeToCode(Scope scope)
        {
            
            Code += "{";
            foreach (VCode item in scope.Items)
            {
                VCodeToString(item);
               
            }
            Code += "}";

        }

        private void GlobalScopeToCode(Scope scope)
        {

            foreach (VCode item in scope.Items)
            {
                VCodeToString(item);
            }
          
        }

        private  void ConditionToCode(Condition condition)
        {
            Code += "(";
            Code += condition.LeftParameter;
            Code += condition.BooleanOperator;
            Code += condition.RightParameter;
            Code += ")";
        }

    }
}
