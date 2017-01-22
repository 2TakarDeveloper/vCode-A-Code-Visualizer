using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Entity.Helpers;

namespace CodeVisualizer.Controls.Helpers
{
    public partial class ConditionControl : UserControl
    {
        public Condition Condition { get; set; }
        public ConditionControl()
        {
            InitializeComponent();
            Condition=new Condition();
        }

        private void OperatorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Condition.BooleanOperator = OperatorBox.Text;
        }

        private void RightBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Condition.RightParameter = RightBox.Text;
        }

        private void leftBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Condition.LeftParameter = LeftBox.Text;
        }
    }
}
