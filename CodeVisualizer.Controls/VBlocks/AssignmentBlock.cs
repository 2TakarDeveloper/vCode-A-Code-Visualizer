using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeVisualizer.Controls.PropertiesForm;
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.VBlocks
{
    public partial class AssignmentBlock : VBlock
    {
        
        public string AssignmentString { get; set; }
        public Assignment Assignment { get; set; }

        public AssignmentBlock(Assignment assignment)
        {
            InitializeComponent();
            Assignment = assignment;
            assignment.VType=Enums.VType.Assignment;
            VCode = Assignment;
            SetString(Assignment);
        }


        private void ParseInstruction(VCode vCode)
        {
            if (vCode.VType == Enums.VType.Function)
            {
                DTD.Entity.vCodes.Function function = (DTD.Entity.vCodes.Function)vCode;
                AssignmentString += function.Name + "(";
                foreach (var var in function.Parameters)
                {
                    AssignmentString += var.Type + " " + var.Name + ",";
                }
                if (function.Parameters.Count > 0)
                    AssignmentString = AssignmentString.Remove(AssignmentString.Length - 1);

                AssignmentString += ")";

            }
            else if (vCode.VType == Enums.VType.Variable)
            {
                DTD.Entity.vCodes.Variable variable = (DTD.Entity.vCodes.Variable)vCode;
                AssignmentString += variable.Name;
                if (variable.IsArray)
                {
                    AssignmentString += "[" + variable.Row + "]";
                    if (variable.ArrayType == "2D")
                        AssignmentString += "[" + variable.Column + "]";
                }


            }
            else if (vCode.VType == Enums.VType.Constant)
            {
                Constant constant = (Constant)vCode;
                AssignmentString += constant.Value;

            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            AssignmentForm assignmentForm = new AssignmentForm(Assignment);
            if (assignmentForm.ShowDialog() != DialogResult.OK) return;
            Assignment = assignmentForm.Assignment;
            SetString(Assignment);
            
        }



        private void SetString(Assignment assignment)
        {
            AssignmentString = assignment.Variable;





            AssignmentString += "=";
            if (assignment.Instruction.InstructionType == Enums.InstructionType.SingleAddress)
            {
                SingleInstruction instruction = (SingleInstruction)assignment.Instruction;
                if (instruction == null) return;
                ParseInstruction(instruction.Instruction);



            }

            else if (Assignment.Instruction.InstructionType == Enums.InstructionType.ThreeAddress)
            {
                ThreeAddressInstruction instruction = (ThreeAddressInstruction)assignment.Instruction;
                if (instruction == null) return;
                ParseInstruction(instruction.LeftInstruction);

                AssignmentString += instruction.Operator;

                ParseInstruction(instruction.RightInstruction);




            }

            AssignmentString += ";";

            AssignmentStringLable.Text = AssignmentString;
            Assignment.AssignmentString = AssignmentString;
        }

    }


    

}
