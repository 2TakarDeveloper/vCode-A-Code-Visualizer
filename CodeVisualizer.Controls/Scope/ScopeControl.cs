using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeVisualizer.Controls.Scope
{
    public partial class ScopeControl : UserControl
    {
        public DTD.Entity.Helpers.Scope Scope { get; set; }
        public ScopeControl()
        {
            InitializeComponent();
        }
    }
}
