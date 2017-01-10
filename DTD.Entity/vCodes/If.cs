using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity.Helpers;

namespace DTD.Entity.vCodes
{
    public class If:vCode
    {
        public Condition Condition { get; set; }
        public Scope Scope { get; set; }
    }
}
