using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeVisualizer.Controls.VBlocks.Variable
{
    public partial class VariableDataControl : UserControl
    {
        public string Variable;
        public string name;
        public VariableDataControl(DTD.Entity.vCodes.Variable variable, List<DTD.Entity.vCodes.Variable> localVariables )
        {
            InitializeComponent();

            Variable = variable.Name;
            name = variable.Name;
            VariableName.Text = variable.Name;
        
            if (!variable.IsArray) return;

            for (int i = 0; i < variable.Row; i++)
            {
                rowIndex.Items.Add(i);
            }

            foreach (var var in localVariables)
            {
                rowIndex.Items.Add(var.Name);
            }

            if (variable.ArrayType == "1D")
            {
                rowIndex.Visible = true;
            }
            else
            {

                for (int i = 0; i < variable.Column; i++)
                {
                    columnIndex.Items.Add(i);
                }
                foreach (var var in localVariables)
                {
                    columnIndex.Items.Add(var.Name);
                }
                rowIndex.Visible = true;
                columnIndex.Visible = true;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void rowIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variable = name + "[" +rowIndex.Text+"]";
        }

        private void columnIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variable = name + "[" + rowIndex.Text + "]"+ "[" + columnIndex.Text + "]";
        }
    }
}
