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
    public class Function:FuncAndVar
    {
        public Scope Scope { get; set; }
        public List<Parameter> Parameters { get; set; }
        public Function()
        {
            Name = "NewFunction";
            Type=Enums.Type.Int;
            AccessModifier=Enums.AccessModifier.Public;
            Scope=new Scope();
            Parameters= new List<Parameter>();
            VType=Enums.VType.Function;
        }
        public Function(string name):this()
        {
            Name = name;
        }
    }
}
