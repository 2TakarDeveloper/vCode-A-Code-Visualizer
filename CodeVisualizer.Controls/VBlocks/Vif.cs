using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.VBlocks
{
    public partial class Vif : VBlock
    {
       
        //TODO add function list later
        public Vif()
        {
            InitializeComponent();
           
            NameLable.Text = @"If";
            scopeControl.Scope=new Scope();
            ScopeControl = scopeControl;
            conditionControl1.Condition = new Condition();
            var iIf = new If
            {
                Scope = scopeControl.Scope,
                Condition = conditionControl1.Condition
            };
            VCode = iIf;
        }

        public void PopulateScopeVariables(List<Variable> varList )
        {
            List<string> leftParameters=new List<string>();
            
            foreach (var variable in varList)
            {
                leftParameters.Add(variable.Name);
            }
            List<string> rightParameters=new List<string>(leftParameters);

            conditionControl1.LeftBox.DataSource = leftParameters;
            conditionControl1.RightBox.DataSource = rightParameters;
            //Reason for 2 list is that both combobox switch when another is changed.
        }

      
    }
}
