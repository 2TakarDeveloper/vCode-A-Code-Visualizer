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
        public Queue<VBlock> VBlocks { get; set; }
        public ScopeControl()
        {
            InitializeComponent();
            VBlocks=new Queue<VBlock>();
           
        }

       


        //ClickEventsOnToolTip
        private void iFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vif= new Vif();
            
            ScopePanel.Controls.Add(vif);
          

        }

        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vFunc = new Vfunction();
        
            ScopePanel.Controls.Add(vFunc);
        }

        private void whileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vWhile = new Vwhile();
    
            ScopePanel.Controls.Add(vWhile);
        }

        private void intToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vVariable = new Vvariable(new Variable<int>());
     
            ScopePanel.Controls.Add(vVariable);
        }

        private void floatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScopePanel.Controls.Add(new Vvariable(new Variable<float>()));
        }

        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScopePanel.Controls.Add(new Vvariable(new Variable<double>()));
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScopePanel.Controls.Add(new Vvariable(new Variable<string>()));
        }

        private void boolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScopePanel.Controls.Add(new Vvariable(new Variable<bool>()));
        }
    }
}
