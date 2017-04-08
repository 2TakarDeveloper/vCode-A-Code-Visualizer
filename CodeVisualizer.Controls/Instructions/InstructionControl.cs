using System;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.Instructions
{
    public partial class InstructionControl : MetroFramework.Controls.MetroUserControl
    {
        public Instruction Instruction { get; set; }
        public InstructionControl()
        {
            InitializeComponent();
        }

        private void InstructionPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Swap mini controls when index changes

        }
    }
}
