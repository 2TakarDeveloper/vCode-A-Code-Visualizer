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
    public  class VBlockToCode
    {
        public string Code { get; set; }

        public VBlockToCode(VCode vcode)
        {
            Code = "";
            VCodeToCode(vcode);
            
        }


        private void VCodeToCode(VCode vcode)
        {

            if (vcode.VType == Enums.VType.GlobalScope)
            {
                var globalScope = (GlobalScope)vcode;
                GlobalScopeToCode(globalScope.Scope);

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
                Code += function.AccessModifier.ToString().ToLower()+" ";
                Code += function.Type.ToString().ToLower() + " ";
                Code += function.Name;
                Code += "(";
                //For each on parameters later
                Code += ")";
                ScopeToCode(function.Scope);
            }

            
        }

        private  void ScopeToCode(Scope scope)
        {
            
            Code += "{\n\t";
            foreach (VCode item in scope.Items)
            {
                VCodeToCode(item);
               
            }
            Code += "}\n";

        }

        private void GlobalScopeToCode(Scope scope)
        {

            foreach (VCode item in scope.Items)
            {
                VCodeToCode(item);
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
