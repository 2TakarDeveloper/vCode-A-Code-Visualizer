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


        private void ParseInstruction(TypedvCodes typedvCodes)
        {
            if (typedvCodes.VType == Enums.VType.Function)
            {
                DTD.Entity.vCodes.Function function = (DTD.Entity.vCodes.Function)typedvCodes;
                AssignmentString += function.Name + "(";
                foreach (var var in function.Parameters)
                {
                    AssignmentString += var.Type + " " + var.Name + ",";
                }
                if (function.Parameters.Count > 0)
                    AssignmentString = AssignmentString.Remove(AssignmentString.Length - 1);

                AssignmentString += ")";

            }
            else if (typedvCodes.VType == Enums.VType.Variable)
            {
               
               
                //DTD.Entity.vCodes.Variable variable = (DTD.Entity.vCodes.Variable) vCode;

                AssignmentString += typedvCodes.Name;
                //if (variable.IsArray)
                //{
                //    AssignmentString += "[" + variable.Row + "]";
                //    if (variable.ArrayType == "2D")
                //        AssignmentString += "[" + variable.Column + "]";
                //}


            }
            else if (typedvCodes.VType == Enums.VType.Constant)
            {
                Constant constant = (Constant)typedvCodes;
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


        private bool _isCollasped = true;

        private void ExpandCollapseButton_Click(object sender, EventArgs e)
        {
            _isCollasped = !_isCollasped;
            Size = _isCollasped ? new Size(Size.Width, 55) : new Size(Size.Width, 77);
        }

        private void DisposeButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }


    

}
