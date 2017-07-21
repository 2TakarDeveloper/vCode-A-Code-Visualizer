using System;
using System.Collections.Generic;
using System.Drawing;
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
            ScopeControl.Scope = iif.Scope;
            conditionControl1.Condition = iif.Condition;
            PopulateCondition(conditionControl1.Condition);
            VCode = iif;
           
        }


        public void PopulateCondition(Condition condition)
        {
            conditionControl1.PopulateCondition(condition);
        }

        public void PopulateScopeVariables(List<DTD.Entity.vCodes.Variable> varList )
        {

            
            foreach (var variable in varList)
            {
              
                conditionControl1.LeftBox.Items.Add(variable.Name);
                conditionControl1.RightBox.Items.Add(variable.Name);
            }
         

  
        }

        private bool _isCollasped = true;

        private void ExpandCollapseButton_Click(object sender, EventArgs e)
        {
            _isCollasped = !_isCollasped;
            Size = _isCollasped ? new Size(Size.Width, 55) : new Size(Size.Width, 256);
        }

        private void DisposeButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
