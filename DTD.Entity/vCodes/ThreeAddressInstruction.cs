using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity.vCodes;

namespace DTD.Entity.Helpers
{
    public class ThreeAddressInstruction:Instruction
    {
        public TypedvCodes LeftInstruction { get; set; }
        public TypedvCodes RightInstruction { get; set; }
        public string Operator { get; set; }
    }
}
