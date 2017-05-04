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
    public class Function:TypedvCodes
    {
        public Scope Scope { get; set; }
        public List<Parameter> Parameters { get; set; }
        public Variable ReturnVariable { get; set; }
        public Function()
        {
            Name = "NewFunction";
            Type=Enums.Type.Int;
            AccessModifier=Enums.AccessModifier.Public;
            Scope=new Scope();
            Parameters= new List<Parameter>();
            VType=Enums.VType.Function;
            ReturnVariable=new Variable();
        }
        public Function(string name):this()
        {
            Name = name;
        }

        public Function(Function function)
        {
            Name = function.Name;
            Type = function.Type;
            AccessModifier = function.AccessModifier;
            Scope = function.Scope;
            Parameters = function.Parameters;
            VType = function.VType;
            ReturnVariable = function.ReturnVariable;
        }


        public override string ToString()
        {
            string returnName;
            returnName = Name+"(";
            foreach (var var in Parameters)
            {
                returnName += var.Type + " " + var.Name+",";
            }
            if(Parameters.Count>0)
                returnName = returnName.Remove(returnName.Length - 1);
            returnName += ")";
            return returnName;
        }
    }
}
