using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void VariableToCode<T>(VCode vCode)
        {
            var variable = (Variable<T>)vCode;
            Code += variable.AccessModifier.ToString().ToLower()+" ";
            Code += variable.Type.ToString().ToLower()+" ";
            Code += variable.Name+" ";
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
                switch (vcode.Type)
                {
                    case Enums.Type.Int:
                        VariableToCode<int>(vcode);
                        break;
                    case Enums.Type.Float:
                        VariableToCode<float>(vcode);
                        break;
                    case Enums.Type.Double:
                        VariableToCode<double>(vcode);
                        break;
                    case Enums.Type.String:
                        VariableToCode<string>(vcode);
                        break;
                    case Enums.Type.Bool:
                        VariableToCode<bool>(vcode);
                        break;
                    
                }
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
                var function=(Function)vcode;
                Code += function.AccessModifier.ToString().ToLower();
                Code += function.Type.ToString().ToLower();
                Code += function.Name;
                Code += "(";
                //For each on parameters later
                Code += ")";
                ScopeToCode(function.Scope);
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
