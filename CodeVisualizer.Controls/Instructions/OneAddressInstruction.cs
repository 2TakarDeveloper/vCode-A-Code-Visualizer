using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CodeVisualizer.Controls.PropertiesForm;
using CodeVisualizer.Controls.VBlocks;
using CodeVisualizer.Controls.VBlocks.Function;
using CodeVisualizer.Controls.VBlocks.Variable;
using DTD.Entity.Enum;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.Instructions
{
    public partial class OneAddressInstruction : MetroFramework.Controls.MetroUserControl
    {
  
        public SingleInstruction SingleInstruction { get; set; }
        private List<Variable> ScopeVariables { get; set; }
        private Variable Variable { get; set; }

        public OneAddressInstruction(List<Variable> variables,Variable variable)
        {
            InitializeComponent();
            ScopeVariables = variables;
            Variable = variable;

            SingleInstruction = new SingleInstruction {InstructionType = Enums.InstructionType.SingleAddress};
        }

        private void variableToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            VariablePicker variablePicker = new VariablePicker(ScopeVariables,Variable);
            if (variablePicker.ShowDialog() == DialogResult.OK)
            {
                if(variablePicker.Variable==null)return;
                VariableDataControl vvariable = new VariableDataControl(variablePicker.Variable, ScopeVariables);
                SingleInstruction.Instruction = variablePicker.Variable;
                Panel.Controls.Clear();
                Panel.Controls.Add(vvariable);
            }
        }

        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionPicker functionPicker = new FunctionPicker(GlobalScope.FunctionList,Variable);
            if (functionPicker.ShowDialog() == DialogResult.OK)
            {
                if(functionPicker.Function==null)return;
                FunctionCall functionCall = new FunctionCall(functionPicker.Function, ScopeVariables);
                SingleInstruction.Instruction = functionPicker.Function;
                Panel.Controls.Clear();
                Panel.Controls.Add(functionCall);
            }
        }

        private void constantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ConstantBlock constantBlock = new ConstantBlock(Variable);
            SingleInstruction.Instruction = constantBlock.Constant;
            Panel.Controls.Clear();
            Panel.Controls.Add(constantBlock);
        }
    }
}
