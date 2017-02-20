using System;
using System.Windows.Forms;
using CodeVisualizer.Controls.PropertiesForm;
using DTD.Entity;
using DTD.Entity.Helpers;

namespace CodeVisualizer.Controls.VBlocks.Function
{
    public partial class Vfunction : VBlock
    {
        
        public DTD.Entity.vCodes.Function Function { get; set; }
        public Vfunction(VCode vCode)
        {
            InitializeComponent();


            Function = (DTD.Entity.vCodes.Function)vCode;
            Function.IsBody = true;
            VCode = Function;
            
            scopeControl.Scope=new Scope();
            Function.Scope = scopeControl.Scope;
            ScopeControl = scopeControl;
            
            PopulateProperties();
           
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            FunctionProperties functionProperties = new FunctionProperties(Function);
            if (functionProperties.ShowDialog() != DialogResult.OK) return;
            Function = functionProperties.Function;
            VCode = Function;
            PopulateProperties();
        }


        private void PopulateProperties()
        {
            string parameters="";
            int len = Function.Parameters.Count;


            if (len>0)
            {
                for (int i = 0; i < len-1; i++)
                {
                    parameters += Function.Parameters[i].Type + " " + Function.Parameters[i].Name+",";
                }
                parameters +=Function.Parameters[len - 1].Type + " " + Function.Parameters[len - 1].Name;
            }

            NameLable.Text = Function.Type.ToString().ToLower()+@" "+Function.Name+ @"(" +parameters+@")";
            
        }

    }
}
