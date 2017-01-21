using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;

namespace DTD.Entity.vCodes
{
    public class If:VCode
    {
        public Condition Condition { get; set; }
        public Scope Scope { get; set; }

        public If()
        {
            Condition=new Condition();
            Scope=new Scope();
            VType=Enums.VType.If;
        }
    }
}
