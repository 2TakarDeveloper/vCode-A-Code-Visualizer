using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;

namespace DTD.Entity.vCodes
{
    public class Assignment:VCode
    {
        public Enums.InstructionType InstructionType { set; get; }
        public Instruction Instruction { set; get; }
        public string Variable { set; get; } 
    }
}
