using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;

namespace DTD.Entity.vCodes
{
    public class Function:VCode
    {

        public string Name { get; set; }
        public bool IsArray { get; set; }
        public bool IsStatic { get; set; }

        public Enums.Type Type { get; set; }
        
        public Enums.AccessModifier AccessModifier { get; set; }
        public Scope Scope { get; set; }

        public Function()
        {
            Name = "NewFunction";
            Type=Enums.Type.Int;
            AccessModifier=Enums.AccessModifier.Public;
            Scope=new Scope();
            VType=Enums.VType.Function;
        }
        
    }
}
