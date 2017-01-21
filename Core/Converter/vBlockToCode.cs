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
    public static class VBlockToCode
    {
        public static void VCodeToCode(VCode vcode,out string code)
        {
          
            if (vcode.VType == Enums.VType.Function)
            {
                Function function=vcode;
                code += function.AccessModifier;
                code += function.Type;
                code += function.Name;
                code += "(";
                code += ")";
                ScopeToCode(function.Scope,out code);
            }

            code = "";
        }

        public static void ScopeToCode(Scope scope,out string code)
        {
            code += "{";
            foreach (VCode item in scope.Items)
            {
                VCodeToCode(item,out code);
            }
            code += "}";

        }

        public static void ConditionToCode()
        {
            
        }

    }
}
