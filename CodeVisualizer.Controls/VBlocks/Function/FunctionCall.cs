
using System.Collections.Generic;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;
using MetroFramework.Controls;

namespace CodeVisualizer.Controls.VBlocks.Function
{
    public partial class FunctionCall : VBlock
    {
        public  DTD.Entity.vCodes.Function Function { get; set; }
        private List<DTD.Entity.vCodes.Variable> ScopeVariables { get; set; }
        public FunctionCall(DTD.Entity.vCodes.Function function,List<DTD.Entity.vCodes.Variable> scopeVariables)
        {
            
            InitializeComponent();
            Function = new DTD.Entity.vCodes.Function(function) {IsBody = false};

            ScopeControl = null;
            Function.VType=Enums.VType.Function;
            
            ScopeVariables = scopeVariables;
           
            PopulateProperties();
            VCode = Function;
        }

        private void PopulateProperties()
        {
            functionName.Text = Function.Name;
            foreach (Parameter parameter in Function.Parameters)
            {

                var combo = new MetroComboBox();

                if(ScopeVariables==null)return;
                foreach (var variable in ScopeVariables)
                {
                    if (variable.Type.ToString().ToLower() == parameter.Type)
                        combo.Items.Add(variable.Name);
                }
                FlowPanel.Controls.Add(combo);
               
            }
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }
    }
}
