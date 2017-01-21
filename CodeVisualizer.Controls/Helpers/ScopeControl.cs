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
        public GlobalScope GlobalScope { get; set; }
        private bool IsGlobalScope { get; set; }
        private Queue<VBlock> VBlocks { get; set; }
        public ScopeControl()
        {
            InitializeComponent();
            VBlocks=new Queue<VBlock>();
           
        }

       


        //ClickEventsOnToolTip
        private void iFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vif= new Vif();
            VBlocks.Enqueue(vif);
            ScopePanel.Controls.Add(vif);
          

        }

        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vFunc = new Vfunction();
            VBlocks.Enqueue(vFunc);
            ScopePanel.Controls.Add(vFunc);
        }

        private void whileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vWhile = new Vwhile();
            VBlocks.Enqueue(vWhile);
            ScopePanel.Controls.Add(vWhile);
        }

        private void intToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vVariable = new Vvariable(new Variable<int>());
            VBlocks.Enqueue(vVariable);
            ScopePanel.Controls.Add(vVariable);
        }

        private void floatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vVariable = new Vvariable(new Variable<float>());
            VBlocks.Enqueue(vVariable);
            ScopePanel.Controls.Add(vVariable);
    
        }

        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vVariable = new Vvariable(new Variable<double>());
            VBlocks.Enqueue(vVariable);
            ScopePanel.Controls.Add(vVariable);
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vVariable = new Vvariable(new Variable<string>());
            VBlocks.Enqueue(vVariable);
            ScopePanel.Controls.Add(vVariable);
        }

        private void boolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vVariable = new Vvariable(new Variable<bool>());
            VBlocks.Enqueue(vVariable);
            ScopePanel.Controls.Add(vVariable);
        }
    }
}
