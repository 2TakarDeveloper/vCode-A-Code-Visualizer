using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity.Enum;

namespace DTD.Entity.vCodes
{
    public class Constant:TypedvCodes
    {
        public string Value { set; get; }

        public Constant()
        {
            VType = Enums.VType.Constant;
        }
    }
}
