using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.vCodes;

namespace Core.Converter
{
    public static class VBlockToCode
    {
        public static void VCodeToCode(VCode vcode)
        {
            if (vcode.VType == Enums.VType.Function)
            {
                Function function=(Function)vcode;
            }


        }

        public static void ScopeToCode()
        {
            
        }

        public static void ConditionToCode()
        {
            
        }

    }
}
