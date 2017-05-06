using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeVisualizer.Controls.Instructions;
using DTD.Entity.Enum;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.PropertiesForm
{
    public partial class AssignmentForm : MetroFramework.Forms.MetroForm
    {
        public Assignment Assignment { get; set; }
        public List<Variable> ScopeVariables { get; set; }
        private InstructionControl InstructionControl { get; set; }
        private Variable SelectedVariable { get; set; }


        public AssignmentForm(List<Variable> scopeVariable)
        {
            InitializeComponent();
            Assignment= new Assignment();
            Assignment.VType=Enums.VType.Assignment;
            ScopeVariables = scopeVariable;
            Assignment.LocalVariables = scopeVariable;
            foreach (var variable in ScopeVariables)
            {
                AssignmentVariable.Items.Add(variable);
            }

            

        }

        public AssignmentForm(Assignment assignment)
        {
            InitializeComponent();
            Assignment = assignment;
            ScopeVariables = assignment.LocalVariables;
            foreach (var variable in ScopeVariables)
            {
                AssignmentVariable.Items.Add(variable);
            }

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Assignment.Variable = AssignmentVariable.Text;
            if (SelectedVariable.IsArray)
            {
                Assignment.Variable += "["+Rows.Text+"]";
                if (SelectedVariable.ArrayType == "2D")
                {
                    Assignment.Variable += "[" + Columns.Text + "]";
                }
                Assignment.Variable += ";";
            }

            Assignment.Instruction = InstructionControl.Instruction;
            if (AssignmentVariable.SelectedItem == null)MessageBox.Show(this,@"Assignment must be done on a variable");
            else DialogResult=DialogResult.OK;
        }

        private void AssignmentVariable_SelectedIndexChanged(object sender, EventArgs e)
        {
             SelectedVariable = (Variable)AssignmentVariable.SelectedItem;

            InstructionControl = new InstructionControl(ScopeVariables,SelectedVariable) { Dock = DockStyle.Fill };

            InstructionPanel.Controls.Clear();
            InstructionPanel.Controls.Add(InstructionControl);
            Assignment.Instruction = InstructionControl.Instruction;

            if (SelectedVariable.IsArray)
            {
                Rows.Items.Clear();
                Columns.Items.Clear();

                if (SelectedVariable.ArrayType == "1D")
                {
                    Rows.Visible = true;
                    
                    for (int i=0;i< SelectedVariable.Row;i++)
                    {
                        Rows.Items.Add(i);
                    }
                    if (SelectedVariable.Row == 0)
                    {
                        Rows.Items.Add(0);
                    }

                    foreach (var variable in ScopeVariables)
                    {
                        if (!variable.IsArray &&variable.Type == Enums.Type.Int)
                        {
                            Rows.Items.Add(variable);
                        }
                    }

                    Columns.Visible = false;
                }
                if (SelectedVariable.ArrayType == "2D")
                {
                    Rows.Visible = true;
                    for (int i = 0; i < SelectedVariable.Row; i++)
                    {
                        Rows.Items.Add(i);
                    }
                    if (SelectedVariable.Row == 0)
                    {
                        Rows.Items.Add(0);
                    }

                    Columns.Visible = true;
                    for (int i = 0; i < SelectedVariable.Column; i++)
                    {
                        Columns.Items.Add(i);
                    }
                    if (SelectedVariable.Column == 0)
                    {
                        Columns.Items.Add(0);
                    }


                    foreach (var variable in ScopeVariables)
                    {
                        if (!variable.IsArray && variable.Type == Enums.Type.Int)
                        {
                            Rows.Items.Add(variable);
                            Columns.Items.Add(variable);
                        }
                    }


                }
            }
            else
            {
                Rows.Items.Clear();
                Columns.Items.Clear();
                
                Rows.Visible = false;
                Columns.Visible = false;
            }

           

        }
    }
}
