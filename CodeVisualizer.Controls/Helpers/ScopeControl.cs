using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CodeVisualizer.Controls.VBlocks;
using Core;
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
            Scope=new Scope();
            //GlobalScope=new GlobalScope();
            
        }

        private void AddItemToScope(VBlock vBlock)
        {
            Scope.Items.Enqueue(vBlock.VCode);
            //GlobalScope.Scope = Scope;
        }


        #region AddControls

        private void intToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vVariable = new Vvariable(new Variable<int>());
            //VBlocks.Enqueue(vVariable);
            ScopePanel.Controls.Add(vVariable);
        }

        private void floatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vVariable = new Vvariable(new Variable<float>());
            //VBlocks.Enqueue(vVariable);
            ScopePanel.Controls.Add(vVariable);
    
        }

        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vVariable = new Vvariable(new Variable<double>());
            //VBlocks.Enqueue(vVariable);
            ScopePanel.Controls.Add(vVariable);
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vVariable = new Vvariable(new Variable<string>());
            //VBlocks.Enqueue(vVariable);
            ScopePanel.Controls.Add(vVariable);
        }

        private void boolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vVariable = new Vvariable(new Variable<bool>());
           // VBlocks.Enqueue(vVariable);
            ScopePanel.Controls.Add(vVariable);
        }

        private void whileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var vWhile = new Vwhile();
            AddItemToScope(vWhile);
            ScopePanel.Controls.Add(vWhile);
        }

        private void ifToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var vif = new Vif();
            AddItemToScope(vif);
            ScopePanel.Controls.Add(vif);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vFunc = new Vfunction();
            ScopePanel.Controls.Add(vFunc);
            AddItemToScope(vFunc);
        }

        #endregion
    }
}
