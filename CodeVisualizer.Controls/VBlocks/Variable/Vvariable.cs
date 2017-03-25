using System;
using System.Windows.Forms;
using CodeVisualizer.Controls.PropertiesForm;
using DTD.Entity;
using DTD.Entity.Enum;

namespace CodeVisualizer.Controls.VBlocks.Variable
{
    public partial class Vvariable: VBlock
    {
        private DTD.Entity.vCodes.Variable Variable { get; set; }
        public Vvariable(VCode variable)
        {
            InitializeComponent();
            VCode = variable;        
            Variable = (DTD.Entity.vCodes.Variable)variable;
            PopulateProperties();
            
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            VariableProperties variableProperties= new VariableProperties(VCode);
            if (variableProperties.ShowDialog() != DialogResult.OK) return;
            Variable = variableProperties.Variable;
            VCode = Variable;
            PopulateProperties();
            
        }


        private void PopulateProperties()
        {
            NameLable.Text = Variable.Name;

            if (Variable.IsArray)
            {

               
                if (Variable.ArrayType == "1D")
                {
                    numericUpDownRow.Visible = true;
                    if(Variable.Row>0)
                        numericUpDownRow.Maximum = Variable.Row - 1;

                }
                if (Variable.ArrayType == "2D")
                {
                    numericUpDownRow.Visible = true;
                    numericUpColumn.Visible = true;
                    if (Variable.Row > 0)
                        numericUpDownRow.Maximum = Variable.Row - 1;
                    if(Variable.Column>0)
                    numericUpColumn.Maximum = Variable.Column - 1;
                }
            }
            else
            {
                numericUpDownRow.Visible = false;
                numericUpColumn.Visible = false;
            }
        }

    

        private void ValueBox_TextChanged(object sender, EventArgs e)
        {
            dynamic value = 0;

            try
            {
                switch (Variable.Type)
                {
                    case Enums.Type.Int:
                        value = int.Parse(ValueBox.Text);
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
            }
        
            catch (Exception)
            {
               
                ValueBox.Clear();

            }
            int row = (int)numericUpDownRow.Value;
            int column = (int)numericUpColumn.Value;
            if (row < 0) row = 0;
            if (column < 0) column = 0;
            Variable.Value[row, column] = value;
        }

        private void numericUpDownRow_ValueChanged(object sender, EventArgs e)
        {
          UpdateValueBox();
        }

        private void numericUpColumn_ValueChanged(object sender, EventArgs e)
        {
            UpdateValueBox();
        }


        private void UpdateValueBox()
        {
            int row = (int)numericUpDownRow.Value;
            int column = (int)numericUpColumn.Value;
            if (row < 0) row = 0;
            if (column < 0) column = 0;


            if (ValueBox != null)
                ValueBox.Text = Variable.Value[row, column].ToString();
        }

    }
}
