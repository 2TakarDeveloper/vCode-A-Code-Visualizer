﻿using System;

using System.Windows.Forms;
using CodeVisualizer.Controls.PropertiesForm;
using CodeVisualizer.Controls.VBlocks;
using CodeVisualizer.Controls.VBlocks.Function;
using CodeVisualizer.Controls.VBlocks.Variable;
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;
using MetroFramework;

namespace CodeVisualizer.Controls.Helpers
{
    public partial class GlobalScopeControl : UserControl
    {
        public GlobalScope GlobalScope { get; set; }

        private  bool MainFunctionDeclared { get; set; }
        
        public GlobalScopeControl()
        {
            InitializeComponent();
           
        }


        #region UpdateScopeData

        private void AddItemToScope(VBlock vBlock)
        {
            vBlock.ScopeControl?.UpdateScope();
            GlobalScope.Scope.Items.Enqueue(vBlock.VCode);

        }

        public void UpdateScope()
        {
            GlobalScope.Scope.Items.Clear();
           
            
            foreach (VBlock vBlock in GlobalScopePanel.Controls)
            {
                AddItemToScope(vBlock);
            }

            GlobalScope.UpdateFunctionNames();
            GlobalScope.Scope.UpdateLocalVariables();
          

        }

        #endregion


        #region vCodeConverter
        //Pass the the items of a scope and it will generate necessary controls

        public void VcodeToVblock(Scope scope)
        {
            GlobalScopePanel.Controls.Clear();
            foreach (VCode item in scope.Items)
            {
                switch (item.VType)
                {
                    case Enums.VType.Variable:
                        Vvariable vvariable = new Vvariable(item);
                        
                        GlobalScopePanel.Controls.Add(vvariable);
                        break;
                    case Enums.VType.Function:
                        Function function = (Function)item;
                        Vfunction vfunction = new Vfunction(function) { Width = GlobalScopePanel.Width };
                        
                        vfunction.ScopeControl.VcodeToVblock(function.Scope);
                        GlobalScopePanel.Controls.Add(vfunction);
                        
                        break;
                  


                }
            }

        }








        #endregion

        private void variableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariableProperties variableProperties = new VariableProperties() ;
            if (variableProperties.ShowDialog() != DialogResult.OK) return;
            Vvariable vvariable = new Vvariable(variableProperties.Variable);
            
            GlobalScopePanel.Controls.Add(vvariable);
            UpdateScope();
        }

        private void FunctionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            FunctionProperties functionProperties = new FunctionProperties() ;
            if (functionProperties.ShowDialog() != DialogResult.OK) return;
            Vfunction vFunc = new Vfunction(functionProperties.Function) { Width = GlobalScopePanel.Width };
            


            foreach (var variable in GlobalScope.Scope.LocalVariables)
            {
                vFunc.Function.Scope.ScopeAccessVariable.Add(variable);
            }
            foreach (var var in functionProperties.Function.Parameters)
            {
                vFunc.Function.Scope.ScopeAccessVariable.Add(new Variable(var.Name)
                {
                    Type = var.Type
                    
                });
            }


            vFunc.SetReturnVar();
            GlobalScopePanel.Controls.Add(vFunc);
            GlobalScope.FunctionList.Add(functionProperties.Function);
            

            UpdateScope();
           

          
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Function mainFunction = new Function
            {
                Name = "Main",
                IsBody = true,
                VType = Enums.VType.Function,
                Type = Enums.Type.Void
            };



            Vfunction vFunc = new Vfunction(mainFunction)
            {
                Width = GlobalScopePanel.Width,
                settingsButton = {Visible = false}
            };





            vFunc.Function.Scope.ScopeAccessVariable = GlobalScope.Scope.LocalVariables;

            GlobalScopePanel.Controls.Add(vFunc);
            MainFunctionDeclared = true;
            UpdateScope();
        }

       
    }
}
