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
        public FuncAndVar LeftInstruction { get; set; }
        public FuncAndVar RightInstruction { get; set; }
        public string Operator { get; set; }
    }
}
