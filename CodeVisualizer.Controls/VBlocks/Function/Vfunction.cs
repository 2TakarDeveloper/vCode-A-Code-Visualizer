using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Windows.Forms;
using CodeVisualizer.Controls.PropertiesForm;
using DTD.Entity;
using DTD.Entity.Enum;
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

            if (Function.Type == Enums.Type.Void)
            {
                returnLable.Visible = false;
                returnPicker.Visible = false;
            }

            PopulateProperties();
          
        }


        public void SetReturnVar()
        {
            if (Function.Type == Enums.Type.Void)
            {
                returnPicker.Visible = false;
                returnLable.Visible = false;
            }
            else
            {
                foreach (DTD.Entity.vCodes.Variable variable in Function.Scope.ScopeAccessVariable)
                {
                    if (variable.Type == Function.Type)
                        returnPicker.Items.Add(variable);
                }
            }

            if(Function.Scope.ScopeAccessVariable.Count<=0)return;
                returnPicker.SelectedIndex = 0;
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
                    parameters += Function.Parameters[i].Type.ToString().ToLower() + " " + Function.Parameters[i].Name+",";
                }
                parameters +=Function.Parameters[len - 1].Type.ToString().ToLower() + " " + Function.Parameters[len - 1].Name;
            }

            NameLable.Text = Function.Type.ToString().ToLower()+@" "+Function.Name+ @"(" +parameters+@")";
            
        }

        private void returnPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Function.ReturnVariable = (DTD.Entity.vCodes.Variable) returnPicker.SelectedItem;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
       
            returnPicker.Items.Clear();
            foreach (var var in Function.Scope.LocalVariables)
            {
                if (Function.Type != var.Type) continue;
                        
                    returnPicker.Items.Add(var);
            }

            foreach (var var in Function.Scope.ScopeAccessVariable)
            {
                if (Function.Type != var.Type) continue;
                    if(returnPicker.Items.Contains(var))continue;
                    returnPicker.Items.Add(var);
            }

            foreach (var parameter in Function.Parameters)
            {
                var var= new DTD.Entity.vCodes.Variable(parameter.Name) {Type = parameter.Type};
                if (Function.Type != var.Type) continue;

                returnPicker.Items.Add(var);
            }
           

        }
    }
}
