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
using CodeVisualizer.Controls.VBlocks;
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.Helpers
{
    public partial class GlobalScopeControl : UserControl
    {
        public GlobalScope GlobalScope { get; set; }

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
            GlobalScope.Scope.UpdateAccessibleVariableNames();
          

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
                        Vvariable vvariable = new Vvariable(item);
                        GlobalScopePanel.Controls.Add(vvariable);
                        break;
                    case Enums.VType.Function:
                        Function function = (Function)item;
                        Vfunction vfunction = new Vfunction(function);
                        vfunction.ScopeControl.VcodeToVblock(function.Scope);
                        GlobalScopePanel.Controls.Add(vfunction);
                        break;
                  


                }
            }

        }








        #endregion

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariableProperties variableProperties = new VariableProperties();
            if (variableProperties.ShowDialog() != DialogResult.OK) return;
            Vvariable vvariable = new Vvariable(variableProperties.Variable);
            GlobalScopePanel.Controls.Add(vvariable);
            UpdateScope();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            FunctionProperties functionProperties = new FunctionProperties();
            if (functionProperties.ShowDialog() != DialogResult.OK) return;
            Vfunction vFunc = new Vfunction(functionProperties.Function);
            vFunc.Function.Scope.ScopeVariables = GlobalScope.Scope.LocalVariables;
            GlobalScopePanel.Controls.Add(vFunc);

            UpdateScope();
        }
    }
}
