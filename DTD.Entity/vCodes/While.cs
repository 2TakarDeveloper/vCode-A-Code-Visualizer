using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;

namespace DTD.Entity.vCodes
{
    public class While : VCode
    {
        public Condition Condition { get; set; }
        public Scope Scope { get; set; }

        public While()
        {
            Condition=new Condition();
            Scope=new Scope();
            VType=Enums.VType.While;
        }

        public override string ToString()
        {
            return "While("+Condition.LeftParameter+Condition.BooleanOperator+Condition.RightParameter+")";
        }
    }
}
