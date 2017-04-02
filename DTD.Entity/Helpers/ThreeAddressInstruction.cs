using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTD.Entity.Helpers
{
    public class ThreeAddressInstruction:Instruction
    {
        public string LeftInstruction { get; set; }
        public string RightInstruction { get; set; }
        public string Operator { get; set; }
    }
}
