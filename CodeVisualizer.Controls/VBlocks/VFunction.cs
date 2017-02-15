using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeVisualizer.Controls.PropertiesForm;
using DTD.Entity;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.VBlocks
{
    public partial class Vfunction : VBlock
    {
        public Function Function { get; set; }
        public Vfunction(VCode vCode)
        {
            InitializeComponent();


            Function = (Function)vCode;
            VCode = Function;
            
            scopeControl.Scope=new Scope();
            Function.Scope = scopeControl.Scope;
            ScopeControl = scopeControl;
            
          
            NameLable.Text = Function.Name;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            FunctionProperties functionProperties = new FunctionProperties(Function);
            if (functionProperties.ShowDialog() != DialogResult.OK) return;
            Function = functionProperties.Function;
            VCode = Function;
            NameLable.Text = Function.Name;
        }
    }
}
