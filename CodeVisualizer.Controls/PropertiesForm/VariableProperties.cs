using System;
using System.Windows.Forms;
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.vCodes;
using MetroFramework;

namespace CodeVisualizer.Controls.PropertiesForm
{
    public partial class VariableProperties : Form
    {
        public Variable Variable { get; set; }
        public VCode VCode { get; set; }

    public VariableProperties()
        {
            
            InitializeComponent();
            Variable =  new Variable();
        }

        public VariableProperties(VCode vcode)
        {
            Variable = (Variable)vcode;
            InitializeComponent();
            PopulateProperties(Variable);
        }

        private void PopulateProperties(Variable variable)
        {
            
        }


        #region Form Event
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
            if (ArrayType.SelectedIndex == 0)
            {
                rowsLable.Visible = true;
                numericUpDownRow.Visible = true;
                columnlable.Visible = false;
                numericUpDownColumn.Visible = false;

            }
            if (ArrayType.SelectedIndex == 1)
            {
                rowsLable.Visible = true;
                numericUpDownRow.Visible = true;
                columnlable.Visible = true;
                numericUpDownColumn.Visible = true;
            }
        }



        private void CancleButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (variableType.Text)
                {
                    case "int":
                        Variable.Type =Enums.Type.Int;
                        break;
                    case "float":
                        Variable.Type = Enums.Type.Float;
                        break;
                    case "double":
                        Variable.Type = Enums.Type.Double;
                        break;
                    case "string":
                        Variable.Type = Enums.Type.String;
                        break;
                    case "bool":
                        Variable.Type = Enums.Type.Bool;
                        break;
                    default:
                        MetroMessageBox.Show(this,"Type Can't be Empty");
                        break;
                }
                Variable.Name = variableName.Text;

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
                        MetroMessageBox.Show(this, "Access Modifier Can't be Empty");
                        break;
                }
                Variable.IsStatic = staticCheck.Checked;
                Variable.IsArray = isArrayCheck.Checked;
                if (Variable.IsArray)
                {
                    switch (ArrayType.Text)
                    {
                        case "1D":
                            Variable.Row = numericUpDownRow.DecimalPlaces;
                            break;
                        case "2D":
                            Variable.Row = numericUpDownRow.DecimalPlaces;
                            Variable.Column = numericUpDownColumn.DecimalPlaces;
                            break;
                        default:
                            MetroMessageBox.Show(this, "Array Type Can't be Empty");
                            break;

                    }
                }


                switch (Variable.Type)
                {
                    case Enums.Type.Int:
                        Variable.Value = new int[Variable.Row,Variable.Column];
                        Variable.Value[0][0] = Convert.ToInt32(ValueBox.Text);
                        break;
                    case Enums.Type.Float:
                        Variable.Value = new float[Variable.Row, Variable.Column];
                        break;
                    case Enums.Type.Double:
                        Variable.Value = new double[Variable.Row, Variable.Column];
                        break;
                    case Enums.Type.String:
                        Variable.Value = new string[Variable.Row, Variable.Column];
                        break;
                    case Enums.Type.Bool:
                        Variable.Value = new bool[Variable.Row, Variable.Column];
                        break;
                      
                }
                

                DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }

            
        }
        

        #endregion

    }
}
