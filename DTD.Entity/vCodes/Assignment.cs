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
        //public Enums.InstructionType InstructionType { set; get; }
        public Instruction Instruction { set; get; }
        public string Variable { set; get; }//it should be replaced by a variable later else conversion might occure issues
        public string AssignmentString { get; set; }//cheating to convert vCodetoCode;
        public List<Variable> LocalVariables { get; set; }

        public Assignment()
        {
            VType = Enums.VType.Assignment;
        }
    }
}
