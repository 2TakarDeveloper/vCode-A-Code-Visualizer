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
    public partial class Vfunction : VBlock
    {
        
        public Vfunction()
        {
            InitializeComponent();
            
            
            Function f = new Function();
            scopeControl1.Scope=new Scope();
            f.Scope = scopeControl1.Scope;
            
            VCode = (Function) f;
            NameLable.Text = f.Name;
        }
    }
}
