using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Entity;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.VBlocks
{
    public partial class Vwhile : VBlock
    {
       
        private While While { get; set; }

        public Vwhile()
        {
            InitializeComponent();
            scopeControl1 = scopeControl;//Some vs error just ignore it.
            scopeControl.Scope=new Scope();
            ScopeControl = scopeControl;
            conditionControl1.Condition=new Condition();
            While = new While
            {
                Scope = scopeControl.Scope,
                Condition = conditionControl1.Condition
            };
            VCode = While;
        }

        public Vwhile(While wWhile)
        {
            InitializeComponent();

          
            scopeControl.Scope = wWhile.Scope;

            ScopeControl = scopeControl;
            ScopeControl.Scope = wWhile.Scope;
            conditionControl1.Condition = wWhile.Condition;
            PopulateCondition(conditionControl1.Condition);
            VCode = wWhile;
        }


        private void PopulateCondition(Condition condition)
        {
            conditionControl1.PopulateCondition(condition);
        }


        public void PopulateScopeVariables(List<DTD.Entity.vCodes.Variable> varList)
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
            Size = _isCollasped ? new Size(Size.Width, 56) : new Size(Size.Width, 384);
        }

        private void DisposeButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
