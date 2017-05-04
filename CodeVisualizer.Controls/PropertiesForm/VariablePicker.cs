using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.PropertiesForm
{
    public partial class VariablePicker : MetroFramework.Forms.MetroForm
    {

        public Variable Variable { get; set; }

        public VariablePicker(List<Variable> scopeVariables,Variable selectedVariable)
        {
            InitializeComponent();

            foreach (var variable in scopeVariables)
            {
                if(variable.Type==selectedVariable.Type)
                    VariablePickerBox.Items.Add(variable);
            }

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.OK;
        }

        private void VariablePickerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variable = (Variable)VariablePickerBox.SelectedItem;
        }
    }
}
