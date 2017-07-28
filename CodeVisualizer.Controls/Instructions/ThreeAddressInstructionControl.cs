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
using CodeVisualizer.Controls.VBlocks;
using CodeVisualizer.Controls.VBlocks.Function;
using CodeVisualizer.Controls.VBlocks.Variable;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.Instructions
{
    public partial class ThreeAddressInstructionControl : MetroFramework.Controls.MetroUserControl
    {
        public ThreeAddressInstruction ThreeAddressInstruction { get; set; }
        public Variable SelectetVariable { get; set; }
        public List<Variable> LocalVariables { get; set; }

        public ThreeAddressInstructionControl(List<Variable> ScopeVariables,Variable selectedVariable )
        {
            InitializeComponent();
            ThreeAddressInstruction =
                new ThreeAddressInstruction {InstructionType = Enums.InstructionType.ThreeAddress};
            SelectetVariable = selectedVariable;
            LocalVariables = ScopeVariables;
            ThreeAddressInstruction.Operator = "+";
        }

        #region Left

        private void variableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablePicker variablePicker = new VariablePicker(LocalVariables, SelectetVariable);
            if (variablePicker.ShowDialog() == DialogResult.OK)
            {
                if (variablePicker.Variable == null) return;
                VariableDataControl vvariable = new VariableDataControl(variablePicker.Variable, LocalVariables);
                ThreeAddressInstruction.LeftInstruction = variablePicker.Variable;
                LeftPanel.Controls.Clear();
                LeftPanel.Controls.Add(vvariable);
            }
        }


        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionPicker functionPicker = new FunctionPicker(GlobalScope.FunctionList, SelectetVariable);
            if (functionPicker.ShowDialog() == DialogResult.OK)
            {
                if (functionPicker.Function == null) return;
                FunctionCall functionCall = new FunctionCall(functionPicker.Function, LocalVariables);
                ThreeAddressInstruction.LeftInstruction = functionPicker.Function;
                LeftPanel.Controls.Clear();
                LeftPanel.Controls.Add(functionCall);
            }
        }


        private void constantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConstantBlock constantBlock = new ConstantBlock(SelectetVariable);
            ThreeAddressInstruction.LeftInstruction = constantBlock.Constant;
            LeftPanel.Controls.Clear();
            LeftPanel.Controls.Add(constantBlock);
        }



        #endregion

        #region Right

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VariablePicker variablePicker = new VariablePicker(LocalVariables, SelectetVariable);
            if (variablePicker.ShowDialog() == DialogResult.OK)
            {
                if (variablePicker.Variable == null) return;
                VariableDataControl vvariable = new VariableDataControl(variablePicker.Variable, LocalVariables);
                ThreeAddressInstruction.RightInstruction = variablePicker.Variable;
                RightPanel.Controls.Clear();
                RightPanel.Controls.Add(vvariable);
            }
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FunctionPicker functionPicker = new FunctionPicker(GlobalScope.FunctionList, SelectetVariable);
            if (functionPicker.ShowDialog() == DialogResult.OK)
            {
                if (functionPicker.Function == null) return;
                FunctionCall functionCall = new FunctionCall(functionPicker.Function, LocalVariables);
                ThreeAddressInstruction.RightInstruction = functionPicker.Function;
                RightPanel.Controls.Clear();
                RightPanel.Controls.Add(functionCall);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ConstantBlock constantBlock = new ConstantBlock(SelectetVariable);
            ThreeAddressInstruction.RightInstruction = constantBlock.Constant;
            RightPanel.Controls.Clear();
            RightPanel.Controls.Add(constantBlock);
        }




        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThreeAddressInstruction.Operator = OperatorSelectionBox.Text;
        }
    }
}
