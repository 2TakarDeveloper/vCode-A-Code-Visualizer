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
       
        public Vwhile()
        {
            InitializeComponent();
            scopeControl1 = scopeControl;//Some vs error just ignore it.
            scopeControl.Scope=new Scope();
            ScopeControl = scopeControl;
            conditionControl1.Condition=new Condition();
            While wWhile = new While
            {
                Scope = scopeControl.Scope,
                Condition = conditionControl1.Condition
            };
            VCode = (While) wWhile;
        }
    }
}
