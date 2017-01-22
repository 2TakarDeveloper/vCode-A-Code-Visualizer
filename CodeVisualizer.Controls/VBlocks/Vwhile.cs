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
            scopeControl1.Scope=new Scope();
            While wWhile = new While {Scope = scopeControl1.Scope};
            VCode = (While) wWhile;
        }
    }
}
