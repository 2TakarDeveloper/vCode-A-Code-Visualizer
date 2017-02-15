using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;

namespace DTD.Entity.vCodes
{
    public class GlobalScope:VCode
    {
        public Scope Scope { get; set; }
        public List<Function> FunctionList { get; set; }


        public GlobalScope()
        {
            Scope=new Scope();
            VType=Enums.VType.GlobalScope;
            FunctionList=new List<Function>();
        }

        public void UpdateFunctionNames()
        {
            FunctionList.Clear();
            foreach (VCode vCode in Scope.Items)
            {
                if(vCode.VType!=Enums.VType.Function)return;
               
                Function f = (Function)vCode;
                FunctionList.Add(f);
            }
        }


    }
}
