﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CodeVisualizer.Controls.PropertiesForm;
using CodeVisualizer.Controls.VBlocks;
using CodeVisualizer.Controls.VBlocks.Conditionals;
using CodeVisualizer.Controls.VBlocks.Function;
using CodeVisualizer.Controls.VBlocks.Variable;
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.vCodes;
using DTD.Entity.Helpers;



namespace CodeVisualizer.Controls.Helpers
{
    public partial class ScopeControl : UserControl
    {
        public Scope Scope { get; set; }
       


        public ScopeControl()
        {
            InitializeComponent();
            
        }

        #region UpdateScopeData

        private void AddItemToScope(VBlock vBlock)
        {
            vBlock.ScopeControl?.UpdateScope();
            Scope.Items.Enqueue(vBlock.VCode);
            
        }

        public void UpdateScope()
        {
            Scope.Items.Clear();
            

            foreach (VBlock vBlock in ScopePanel.Controls)
            {
               
                AddItemToScope(vBlock);
            }

            Scope.UpdateAccessibleVariableNames();
            
        }

        #endregion


        #region toolStripMenuItemClick

    

        private void whileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var vWhile = new Vwhile();
          
            ScopePanel.Controls.Add(vWhile);
          
        }

        private void ifToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var vif = new Vif();
            vif.PopulateScopeVariables(Scope.LocalVariables);
            ScopePanel.Controls.Add(vif);
            
        }



        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VariableProperties variableProperties= new VariableProperties();
            if (variableProperties.ShowDialog() == DialogResult.OK)
            {
                Vvariable vvariable = new Vvariable(variableProperties.Variable);
                ScopePanel.Controls.Add(vvariable);
                UpdateScope();
            }
        }

        #endregion


        #region vCodeConverter
        //Pass the the items of a scope and it will generate necessary controls

        public void VcodeToVblock(Scope scope)
        {
            foreach (VCode item in scope.Items)
            {
                switch (item.VType)
                {
                    case Enums.VType.Variable:
                            Vvariable vvariable= new Vvariable(item);
                            ScopePanel.Controls.Add(vvariable);
                        break;
                    case Enums.VType.Function:
                        Function function = (Function)item;

                        if (function.IsBody)
                        {
                            Vfunction vfunction = new Vfunction(function);
                            vfunction.ScopeControl.VcodeToVblock(function.Scope);
                            ScopePanel.Controls.Add(vfunction);
                        }
                        else
                        {
                            FunctionCall vFunctionCall=new FunctionCall(function,scope.ScopeVariables);
                            ScopePanel.Controls.Add(vFunctionCall);
                        }
                        
                        break;
                    case Enums.VType.If:
                        If iif = (If)item;
                        Vif vif = new Vif(iif);
                        vif.ScopeControl.VcodeToVblock(iif.Scope);
                        ScopePanel.Controls.Add(vif);
                        break;
                    case Enums.VType.While:
                        While wWhile = (While) item;
                        Vwhile vwhile=new Vwhile() {VCode=wWhile};
                        vwhile.ScopeControl.VcodeToVblock(wWhile.Scope);
                        ScopePanel.Controls.Add(vwhile);
                        break;
                    
                   
                }
            }
            
        }






        #endregion

      

        private void printToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Function PrintFunction = new Function();
            PrintFunction.Name = "printf";
            PrintFunction.IsBody = false;
            PrintFunction.VType=Enums.VType.Function;
      
            PrintFunction.Parameters.Add(new Parameter() { Name = "", Type = "string" });
            FunctionCall functionCall = new FunctionCall(PrintFunction, Scope.ScopeVariables);
            functionCall.ScopeControl = null;
            ScopePanel.Controls.Add(functionCall);
        }
    }
}
