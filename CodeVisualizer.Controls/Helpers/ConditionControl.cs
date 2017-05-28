using System;
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

        public void PopulateCondition(Condition condition)
        {
            Condition = condition;
            OperatorBox.Text = condition.BooleanOperator;
            LeftBox.Text = condition.LeftParameter;
            RightBox.Text = condition.RightParameter;
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
