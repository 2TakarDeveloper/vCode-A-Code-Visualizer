﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeVisualizer.Controls.Helpers;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;
using GlobalLibrary;
using MetroFramework;

namespace CodeVisualizer.Controls.PropertiesForm
{
    public partial class FunctionProperties : MetroFramework.Forms.MetroForm
    {
        public Function Function { get; set; }


        private string tooltipText = @"Function name must start with letters(A-Z/a-z) or _  also can't contain
any other special character, But it can contain numbers(0-9).";
        RegexPatterns _regexPatterns = new RegexPatterns();


        public FunctionProperties()
        {
            Function= new Function();
            InitializeComponent();
        }

        public FunctionProperties(Function function)
        {
            Function = function;
            InitializeComponent();
          
            FunctionNameTextBox.Text = Function.Name;
            ReturnType.Text = Function.Type.ToString().ToLower();
            FunctionAccessModifier.Text = Function.AccessModifier.ToString().ToLower();
            staticCheck.CheckState = Function.IsStatic ? CheckState.Checked : CheckState.Unchecked;
            if(Function.Parameters.Count<=0)return;
            HasParameter.Checked = true;
            foreach (Parameter parameter in Function.Parameters)
            {
                ParameterFlow.Controls.Add(new ParameterControl(parameter));
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {

                switch (ReturnType.Text)
                {
                    case "int":
                        Function.Type = Enums.Type.Int;
                        break;
                    case "float":
                        Function.Type = Enums.Type.Float;
                        break;
                    case "double":
                        Function.Type = Enums.Type.Double;
                        break;
                    case "string":
                        Function.Type = Enums.Type.String;
                        break;
                    case "bool":
                        Function.Type = Enums.Type.Bool;
                        break;
                    case "void":
                        Function.Type = Enums.Type.Void;
                        break;
                    default:
                        throw new Exception("Return type can't be empty");
                        
                }
               

                //switch (FunctionAccessModifier.Text)
                //{
                //    case "public":
                //        Function.AccessModifier = Enums.AccessModifier.Public;
                //        break;
                //    case "private":
                //        Function.AccessModifier = Enums.AccessModifier.Private;
                //        break;
                //    case "protected":
                //        Function.AccessModifier = Enums.AccessModifier.Protected;
                //        break;

                //    default:
                //        throw new Exception("AccessModifier  can't be empty");
                      
                //}
                //Function.IsStatic = staticCheck.Checked;


                Function.Parameters.Clear();


                foreach (ParameterControl parameterControl  in ParameterFlow.Controls)
                {
                    Function.Parameters.Add(parameterControl.Parameter);
                }


                if (_regexPatterns.IsVariable(FunctionNameTextBox.Text))
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroMessageBox.Show(this, tooltipText, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

              
            }
            catch (Exception exception)
            {
                MetroMessageBox.Show(this, exception.Message);
            }
        }

        private void AddNewParameter_Click(object sender, EventArgs e)
        {
           ParameterFlow.Controls.Add(new ParameterControl());
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void HasParameter_CheckedChanged(object sender, EventArgs e)
        {
            AddNewParameter.Visible = HasParameter.Checked;
            ParameterFlow.Controls.Clear();
        }

        private void FunctionNameTextBox_TextChanged(object sender, EventArgs e)
        {
            RegexPatterns RegexPatterns= new RegexPatterns();

            if (!RegexPatterns.IsVariable(FunctionNameTextBox.Text))
            {
                metroToolTip1.Show(tooltipText, FunctionNameTextBox);
            }
            else
            {
                metroToolTip1.Hide(FunctionNameTextBox);
                Function.Name = FunctionNameTextBox.Text;
            }
            
        }
    }
}
