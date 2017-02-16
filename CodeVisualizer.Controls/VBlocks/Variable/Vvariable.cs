using System;
using System.Windows.Forms;
using CodeVisualizer.Controls.PropertiesForm;
using DTD.Entity;

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
        }

    }
}
