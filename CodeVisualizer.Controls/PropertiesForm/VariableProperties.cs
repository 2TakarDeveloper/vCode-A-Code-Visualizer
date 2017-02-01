using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.PropertiesForm
{
    public partial class VariableProperties : Form
    {
        private VCode Vcode { get; set; }
        public VariableProperties(VCode vCode)
        {
            Vcode = vCode;
            InitializeComponent();
            PopulateProperties(vCode);
        }

        private void PopulateProperties(VCode vCode)
        {
            switch (vCode.Type)
            {
                case Enums.Type.Int:
                    IntVar((Variable<int>) vCode);
                    break;
                case Enums.Type.Float:
                    break;
                case Enums.Type.Double:
                    break;
                case Enums.Type.String:
                    break;
                case Enums.Type.Bool:
                    break;
               
            }
        }

        private void IntVar(Variable<int> variable)
        {
            variableName.Text = variable.Name;
            variableAccessModifier.Text = variable.AccessModifier.ToString();
            variableType.Text = variable.Type.ToString();
            if (variable.IsStatic)
            {
                staticCheck.CheckState = CheckState.Checked;
            }
            if (variable.IsArray)
            {
                isArrayCheck.CheckState = CheckState.Checked;
            }


        }

        private void isArrayCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (isArrayCheck.CheckState == CheckState.Checked)
            {
                arrytypelable.Visible = true;
                ArrayType.Visible = true;
            }
            else
            {
                arrytypelable.Visible = false;
                ArrayType.Visible = false;
            }
        }

        private void ArrayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ArrayType.SelectedIndex==0)
            {
                rowsLable.Visible = true;
                numericUpDownRow.Visible = true;
                columnlable.Visible = false;
                numericUpDownColumn.Visible = false;

            }
            if (ArrayType.SelectedIndex==1)
            {
                rowsLable.Visible = true;
                numericUpDownRow.Visible = true;
                columnlable.Visible = true;
                numericUpDownColumn.Visible = true;
            }
        }
    }
}
