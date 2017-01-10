using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity.Enum;

namespace DTD.Entity.Helpers
{
    public class Condition
    {
        public string LeftParameter { get; set; }
        public string RightParameter { get; set; }
        public Enums.BooleanOperator BooleanOperator { get; set; }
    }
}
