using System;
using System.Windows.Forms;
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.vCodes;
using MetroFramework;

namespace CodeVisualizer.Controls.PropertiesForm
{
    public partial class VariableProperties : MetroFramework.Forms.MetroForm
    {
        public Variable Variable { get; set; }
     

        public VariableProperties()
        {
            
            InitializeComponent();
            Variable =  new Variable();
            RowIndex.Maximum = numericUpDownRow.Value - 1;
            ColumnIndex.Maximum = numericUpDownColumn.Value - 1;
       
        }

        public VariableProperties(VCode vcode)
        {
            Variable = (Variable)vcode;
            InitializeComponent();
            PopulateProperties(Variable);
            RowIndex.Maximum = numericUpDownRow.Value - 1;
            ColumnIndex.Maximum = numericUpDownColumn.Value - 1;
        }

        private void PopulateProperties(Variable variable)
        {
            Variable = variable;
            variableNameTextBox.Text = Variable.Name;
            variableType.Text = Variable.Type.ToString().ToLower();
            variableAccessModifier.Text = Variable.AccessModifier.ToString().ToLower();
            staticCheck.CheckState = Variable.IsStatic ? CheckState.Checked : CheckState.Unchecked;
            isArrayCheck.CheckState = Variable.IsArray ? CheckState.Checked : CheckState.Unchecked;
            numericUpDownRow.Value = Variable.Row;
            numericUpDownColumn.Value = Variable.Column;
            ArrayType.Text = Variable.ArrayType;
            ValueBox.Text = Variable.Value[0,0].ToString();
        }


        #region Form Event
        private void isArrayCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (isArrayCheck.CheckState == CheckState.Checked)
            {
                arrytypelable.Visible = true;
                ArrayType.Visible = true;
                Variable.IsArray = isArrayCheck.Checked;
            }
            else
            {
                arrytypelable.Visible = false;
                ArrayType.Visible = false;
                numericUpDownColumn.Visible = false;
                numericUpDownRow.Visible = false;
                rowsLable.Visible = false;
                columnlable.Visible = false;

            }
        }

        private void ArrayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ArrayType.SelectedIndex == 0)
            {
                rowsLable.Visible = true;
                numericUpDownRow.Visible = true;
                columnlable.Visible = false;
                numericUpDownColumn.Visible = false;
                RowIndex.Visible = true;
                RowIndexLable.Visible = true;
                Variable.ArrayType = "1D";

            }
            if (ArrayType.SelectedIndex == 1)
            {
                rowsLable.Visible = true;
                numericUpDownRow.Visible = true;
                columnlable.Visible = true;
                numericUpDownColumn.Visible = true;
                RowIndex.Visible = true;
                RowIndexLable.Visible = true;
                ColumnIndex.Visible = true;
                ColumnIndexLable.Visible = true;
                Variable.ArrayType = "2D";
            }
        }



        private void CancleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

           DialogResult = DialogResult.OK;
            
        }


        #endregion

        private void numericUpDownRow_ValueChanged(object sender, EventArgs e)
        {
            RowIndex.Maximum = numericUpDownRow.Value-1;
            Variable.Row = (int)numericUpDownRow.Value;
            UpdateVariableValue();
        }

        private void numericUpDownColumn_ValueChanged(object sender, EventArgs e)
        {
            ColumnIndex.Maximum = numericUpDownColumn.Value-1;
            Variable.Column = (int)numericUpDownColumn.Value;
            UpdateVariableValue();
        }

        private void RowIndex_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                ValueBox.Text = Variable.Value[(int)RowIndex.Value, (int)ColumnIndex.Value].ToString();
            }
            catch (Exception )
            {
                //ignored
            }
        }

        private void ColumnIndex_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ValueBox.Text = Variable.Value[(int)RowIndex.Value, (int)ColumnIndex.Value].ToString();
            }
            catch (Exception)
            {
                //ignored
            }
        }

        private void variableType_SelectedIndexChanged(object sender, EventArgs e)
        {
          UpdateVariableValue();   
        }

        private void UpdateVariableValue()
        {
            switch (variableType.Text)
            {
                case "int":
                    Variable.Type = Enums.Type.Int;
                    Variable.Value = new int[Variable.Row + 1, Variable.Column + 1];
                    break;
                case "float":
                    Variable.Type = Enums.Type.Float;
                    Variable.Value = new float[Variable.Row + 1, Variable.Column + 1];
                    break;
                case "double":
                    Variable.Type = Enums.Type.Double;
                    Variable.Value = new double[Variable.Row + 1, Variable.Column + 1];
                    break;
                case "string":
                    Variable.Type = Enums.Type.String;
                    Variable.Value = new string[Variable.Row + 1, Variable.Column + 1];
                    break;
                case "bool":
                    Variable.Type = Enums.Type.Bool;
                    Variable.Value = new bool[Variable.Row + 1, Variable.Column + 1];
                    break;

            }
        }


        private void variableAccessModifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (variableAccessModifier.Text)
            {
                case "public":
                    Variable.AccessModifier = Enums.AccessModifier.Public;
                    break;
                case "private":
                    Variable.AccessModifier = Enums.AccessModifier.Private;
                    break;
                case "protected":
                    Variable.AccessModifier = Enums.AccessModifier.Protected;
                    break;

                default:
                    throw new Exception("AccessModifier  can't be empty");
            }

        }

        private void variableNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Variable.Name = variableNameTextBox.Text;
        }

        private void staticCheck_CheckedChanged(object sender, EventArgs e)
        {
            Variable.IsStatic = staticCheck.Checked;
        }

        private void ValueBox_TextChanged(object sender, EventArgs e)
        {
            dynamic value="0";
            
            switch (Variable.Type)
            {
                case Enums.Type.Int:
                    value = Int32.Parse(ValueBox.Text);
                    break;
                case Enums.Type.Float:
                    value = double.Parse(ValueBox.Text);
                    break;
                case Enums.Type.Double:
                    value = double.Parse(ValueBox.Text);
                    break;
                case Enums.Type.String:
                    value = ValueBox.Text;
                    break;
               
            }

            Variable.Value[(int)RowIndex.Value, (int)ColumnIndex.Value] = value;
        }
    }
}
