using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CodeVisualizer.Controls.VBlocks;
using DTD.Entity.Enum;
using DTD.Entity.vCodes;
using DTD.Entity.Helpers;



namespace CodeVisualizer.Controls.Helpers
{
    public partial class ScopeControl : UserControl
    {
        public Scope Scope { get; set; }
        public GlobalScope GlobalScope { get; set; }//This is Required for The global scope//
      
      
        public ScopeControl()
        {
            InitializeComponent();
            
        }

        private void AddItemToScope(VBlock vBlock)
        {
            vBlock.ScopeControl?.UpdateScope();
            Scope.Items.Enqueue(vBlock.VCode);
            
        }

        public void UpdateScope()
        {
            Scope.Items.Clear();
            foreach (VBlock vBlock in ScopePanel.Controls)
            {
                AddItemToScope(vBlock);
            }
        }


        #region toolStripMenuItemClick

        private void intToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variable<int> x = new Variable<int>
            {
                Type = Enums.Type.Int,
                VType = Enums.VType.Variable
            };
            var vVariable = new Vvariable(x);
            
            ScopePanel.Controls.Add(vVariable);
          
        }

        private void floatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variable<float> x = new Variable<float>
            {
                Type = Enums.Type.Float,
                VType = Enums.VType.Variable
            };
            var vVariable = new Vvariable(x);
            
            ScopePanel.Controls.Add(vVariable);
     

        }

        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variable<double> x = new Variable<double>
            {
                Type = Enums.Type.Double,
                VType = Enums.VType.Variable
            };
            var vVariable = new Vvariable(x);

            ScopePanel.Controls.Add(vVariable);
            
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variable<string> x = new Variable<string>
            {
                Type = Enums.Type.String,
                VType = Enums.VType.Variable
            };
            var vVariable = new Vvariable(x);
            ScopePanel.Controls.Add(vVariable);
        }

        private void boolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variable<bool> x = new Variable<bool>
            {
                Type = Enums.Type.Bool,
                VType = Enums.VType.Variable
            };
            var vVariable = new Vvariable(x);
            ScopePanel.Controls.Add(vVariable);
           
        }

        private void whileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var vWhile = new Vwhile();
          
            ScopePanel.Controls.Add(vWhile);
          
        }

        private void ifToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var vif = new Vif();
      
            ScopePanel.Controls.Add(vif);
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vFunc = new Vfunction();
            ScopePanel.Controls.Add(vFunc);
            
        }

        #endregion

    }
}
