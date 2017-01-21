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

        public GlobalScope()
        {
            Scope=new Scope();
            VType=Enums.VType.GlobalScope;
        }
    }
}
