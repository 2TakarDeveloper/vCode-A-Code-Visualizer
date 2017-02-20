using System.Collections.Generic;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.VBlocks.Conditionals
{
    public partial class Vif : VBlock
    {
       
        //TODO add function list later
        public Vif()
        {
            InitializeComponent();
           
            NameLable.Text = @"If";
            scopeControl.Scope=new Scope();
            ScopeControl = scopeControl;
            conditionControl1.Condition = new Condition();
            var iIf = new If
            {
                Scope = scopeControl.Scope,
                Condition = conditionControl1.Condition
            };
            VCode = iIf;
        }


        public Vif(If iif)
        {
            InitializeComponent();

            NameLable.Text = @"If";
            scopeControl.Scope = iif.Scope;
            ScopeControl = scopeControl;
            conditionControl1.Condition = iif.Condition;
            VCode = iif;
        }



        public void PopulateScopeVariables(List<DTD.Entity.vCodes.Variable> varList )
        {
           
            
            foreach (var variable in varList)
            {
              
                conditionControl1.LeftBox.Items.Add(variable.Name);
                conditionControl1.RightBox.Items.Add(variable.Name);
            }
         

  
        }

      
    }
}
