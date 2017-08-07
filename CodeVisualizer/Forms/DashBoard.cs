using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Core.Beautifier;
using Core.Converter;
using DTD.Entity;
using DTD.Entity.Enum;

using DTD.Entity.vCodes;
using MetroFramework.Forms;

namespace CodeVisualizer.Forms
{
    public partial class DashBoard : MetroForm
    {
        

        public DashBoard()
        {
            InitializeComponent();
            globalScopeControl.GlobalScope = new GlobalScope();
        }

        


        #region TextHighligher

        private readonly Regex _variable = new Regex("int|char|string|double|float|");
        private readonly Regex _conditional = new Regex("for|while|if|else|");
        private readonly Regex _accessModifier = new Regex("private|public|protected|");
        private readonly Regex _stringValue = new Regex("[\"]+([a-z]||[A-Z]||[0-9])+[\"]");
        private readonly Regex _floatNumberValue = new Regex("([0-9]*)+[.]+[0-9]*");
        private readonly Regex _intNumberValue = new Regex("[0-9]*");

        private void CodeEditor_TextChanged(object sender, EventArgs e)
        {

            int selPos = CodeEditor.SelectionStart;
            foreach (Match keyWordMatch in _variable.Matches(CodeEditor.Text))
            {

                CodeEditor.Select(keyWordMatch.Index, keyWordMatch.Length);
                CodeEditor.SelectionColor = Color.Blue;

                CodeEditor.SelectionStart = selPos;
                CodeEditor.SelectionColor = Color.Black;


            }
            foreach (Match keyWordMatch in _accessModifier.Matches(CodeEditor.Text))
            {

                CodeEditor.Select(keyWordMatch.Index, keyWordMatch.Length);
                CodeEditor.SelectionColor = Color.Red;

                CodeEditor.SelectionStart = selPos;
                CodeEditor.SelectionColor = Color.Black;
            }
            foreach (Match keyWordMatch in _conditional.Matches(CodeEditor.Text))
            {

                CodeEditor.Select(keyWordMatch.Index, keyWordMatch.Length);
                CodeEditor.SelectionColor = Color.ForestGreen;

                CodeEditor.SelectionStart = selPos;
                CodeEditor.SelectionColor = Color.Black;
            }
            foreach (Match keyWordMatch in _stringValue.Matches(CodeEditor.Text))
            {

                CodeEditor.Select(keyWordMatch.Index, keyWordMatch.Length);
                CodeEditor.SelectionColor = Color.DeepPink;

                CodeEditor.SelectionStart = selPos;
                CodeEditor.SelectionColor = Color.Black;
            }
            foreach (Match keyWordMatch in _floatNumberValue.Matches(CodeEditor.Text))
            {

                CodeEditor.Select(keyWordMatch.Index, keyWordMatch.Length);
                CodeEditor.SelectionColor = Color.DeepPink;

                CodeEditor.SelectionStart = selPos;
                CodeEditor.SelectionColor = Color.Black;
            }
            foreach (Match keyWordMatch in _intNumberValue.Matches(CodeEditor.Text))
            {

                CodeEditor.Select(keyWordMatch.Index, keyWordMatch.Length);
                CodeEditor.SelectionColor = Color.DeepPink;

                CodeEditor.SelectionStart = selPos;
                CodeEditor.SelectionColor = Color.Black;
            }

            try
            {
                ToUi();
            }
            catch (Exception )
            {
                //
            }
            

        }

        #endregion













        ////Code Editor





        private void visualToCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ToCode();
            TreeDraw();
        }

        private void ToCode()
        {

            globalScopeControl.UpdateScope();
            VCodeToCode vBlockToCode = new VCodeToCode(globalScopeControl.GlobalScope);
            Beautify beautifier = new Beautify(vBlockToCode.Code);
            CodeEditor.Text = beautifier.CodeOutput;
        }


        private void codeToVisualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToUi();
        }

        private void ToUi()
        {
            CodeToVCode codeToVCode = new CodeToVCode(CodeEditor.Text);
            globalScopeControl.VcodeToVblock(codeToVCode.Scope);

            TreeNode root = null;

            UpdateTreeView(ref root, codeToVCode.Scope.Items);
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(root);
        }


        private void TreeDraw()
        {
            CodeToVCode codeToVCode = new CodeToVCode(CodeEditor.Text);
           
            TreeNode root = null;

            UpdateTreeView(ref root, codeToVCode.Scope.Items);
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(root);
        }

        private void UpdateTreeView(ref TreeNode root, Queue<VCode> vCodes)
        {
            if (root == null)
            {
                root = new TreeNode()
                {
                    Text = @"Root",
                    Tag = null
                };
                // get all departments in the list with parent is null

                foreach (VCode vCode in vCodes)
                {

                    switch (vCode.VType)
                    {
                        case Enums.VType.Variable:
                            var child = new TreeNode()
                            {
                                Text = vCode.ToString()

                            };
                            root.Nodes.Add(child);
                            break;
                        case Enums.VType.Function:
                            Function func = (Function) vCode;
                            child = new TreeNode()
                            {
                                Text = func.ToString()

                            };
                            UpdateTreeView(ref child, func.Scope.Items);
                            root.Nodes.Add(child);

                            break;
                        case Enums.VType.If:
                            If vif = (If) vCode;
                            child = new TreeNode()
                            {
                                Text = vif.ToString()

                            };
                            UpdateTreeView(ref child, vif.Scope.Items);
                            root.Nodes.Add(child);

                            break;
                        case Enums.VType.While:
                            While wWhile = (While) vCode;
                            child = new TreeNode()
                            {
                                Text = wWhile.ToString()

                            };
                            UpdateTreeView(ref child, wWhile.Scope.Items);
                            root.Nodes.Add(child);
                            break;
                        case Enums.VType.Constant:
                            Constant constant = (Constant) vCode;
                            child = new TreeNode()
                            {
                                Text = constant.ToString()

                            };

                            root.Nodes.Add(child);
                            break;
                        case Enums.VType.Assignment:
                            Assignment assignment = (Assignment) vCode;
                            child = new TreeNode()
                            {
                                Text = assignment.AssignmentString

                            };

                            root.Nodes.Add(child);


                            break;

                    }


                }
            }
            else
            {


                foreach (VCode vCode in vCodes)
                {

                    switch (vCode.VType)
                    {
                        case Enums.VType.Variable:
                            var child = new TreeNode()
                            {
                                Text = vCode.ToString()

                            };
                            root.Nodes.Add(child);
                            break;
                        case Enums.VType.Function:
                            Function func = (Function) vCode;
                            child = new TreeNode()
                            {
                                Text = func.ToString()

                            };
                            UpdateTreeView(ref child, func.Scope.Items);
                            root.Nodes.Add(child);

                            break;
                        case Enums.VType.If:
                            If vif = (If) vCode;
                            child = new TreeNode()
                            {
                                Text = vif.ToString()

                            };
                            UpdateTreeView(ref child, vif.Scope.Items);
                            root.Nodes.Add(child);

                            break;
                        case Enums.VType.While:
                            While wWhile = (While) vCode;
                            child = new TreeNode()
                            {
                                Text = wWhile.ToString()

                            };
                            UpdateTreeView(ref child, wWhile.Scope.Items);
                            root.Nodes.Add(child);
                            break;
                        case Enums.VType.Constant:
                            Constant constant = (Constant) vCode;
                            child = new TreeNode()
                            {
                                Text = constant.ToString()

                            };

                            root.Nodes.Add(child);
                            break;
                        case Enums.VType.Assignment:
                            Assignment assignment = (Assignment) vCode;
                            child = new TreeNode()
                            {
                                Text = assignment.AssignmentString

                            };

                            root.Nodes.Add(child);


                            break;

                    }
                }
            }

        }
    }
}
