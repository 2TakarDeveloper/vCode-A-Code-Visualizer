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
        public Function Function { get; set; }
        public Vfunction()
        {
            InitializeComponent();


            Function = new Function();
            VCode = Function;
            
            scopeControl.Scope=new Scope();
            Function.Scope = scopeControl.Scope;
            ScopeControl = scopeControl;
            
          
            NameLable.Text = Function.Name;
        }
    }
}
