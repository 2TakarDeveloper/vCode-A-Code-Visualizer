using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTD.Entity.Enum;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.Instructions
{
    public partial class InstructionControl : MetroFramework.Controls.MetroUserControl
    {
        private List<Variable> ScopeVariable { get; set; }
        private Variable Variable { get; set; }
        public Instruction Instruction { get; set; }

        public InstructionControl(List<Variable> scopeVariable,Variable selectedVariable)
        {
            InitializeComponent();
            Variable = selectedVariable;
            ScopeVariable = scopeVariable;
            OneAddressInstruction oneaddress = new OneAddressInstruction(ScopeVariable,Variable) { Dock = DockStyle.Fill };
            InstructionPanel.Controls.Clear();
            InstructionPanel.Controls.Add(oneaddress);
            Instruction = oneaddress.SingleInstruction;
            Instruction.InstructionType=Enums.InstructionType.SingleAddress;
            
        }

        private void InstructionPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InstructionPicker.Text == "Single Address")
            {
                 OneAddressInstruction oneaddress= new OneAddressInstruction(ScopeVariable,Variable) {Dock = DockStyle.Fill};
          
                InstructionPanel.Controls.Clear();
                InstructionPanel.Controls.Add(oneaddress);
                Instruction = oneaddress.SingleInstruction;
                Instruction.InstructionType = Enums.InstructionType.SingleAddress;

            }
            else if (InstructionPicker.Text == "Three Address")
            {
                ThreeAddressInstructionControl ThreeAddress= new ThreeAddressInstructionControl(ScopeVariable, Variable) {Dock = DockStyle.Fill};
               
                InstructionPanel.Controls.Clear();
                InstructionPanel.Controls.Add(ThreeAddress);
                Instruction = ThreeAddress.ThreeAddressInstruction;
                Instruction.InstructionType = Enums.InstructionType.ThreeAddress;
            }

        }
    }
}
