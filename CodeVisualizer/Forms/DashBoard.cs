using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Core.Beautifier;
using Core.Converter;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;
using MetroFramework.Forms;

namespace CodeVisualizer.Forms
{
    public partial class DashBoard : MetroForm
    {
        private string Code { get; set; }

        public DashBoard()
        {
            InitializeComponent();
            globalScopeControl.GlobalScope=new GlobalScope();
           
        }


        #region TextHighligher
        public Regex variable = new Regex("int|char|string|double|float|");
        public Regex conditional = new Regex("for|while|if|else|");
        public Regex accessModifier = new Regex("private|public|protected|");
        public Regex stringValue = new Regex("[\"]+([a-z]||[A-Z]||[0-9])+[\"]");
        public Regex floatNumberValue = new Regex("([0-9]*)+[.]+[0-9]*");
        public Regex intNumberValue = new Regex("[0-9]*");

        private void CodeEditor_TextChanged(object sender, EventArgs e)
        {

            int selPos = CodeEditor.SelectionStart;
            foreach (Match keyWordMatch in variable.Matches(CodeEditor.Text))
            {

                CodeEditor.Select(keyWordMatch.Index, keyWordMatch.Length);
                CodeEditor.SelectionColor = Color.Blue;

                CodeEditor.SelectionStart = selPos;
                CodeEditor.SelectionColor = Color.Black;


            }
            foreach (Match keyWordMatch in accessModifier.Matches(CodeEditor.Text))
            {

                CodeEditor.Select(keyWordMatch.Index, keyWordMatch.Length);
                CodeEditor.SelectionColor = Color.Red;

                CodeEditor.SelectionStart = selPos;
                CodeEditor.SelectionColor = Color.Black;
            }
            foreach (Match keyWordMatch in conditional.Matches(CodeEditor.Text))
            {

                CodeEditor.Select(keyWordMatch.Index, keyWordMatch.Length);
                CodeEditor.SelectionColor = Color.ForestGreen;

                CodeEditor.SelectionStart = selPos;
                CodeEditor.SelectionColor = Color.Black;
            }
            foreach (Match keyWordMatch in stringValue.Matches(CodeEditor.Text))
            {

                CodeEditor.Select(keyWordMatch.Index, keyWordMatch.Length);
                CodeEditor.SelectionColor = Color.DeepPink;

                CodeEditor.SelectionStart = selPos;
                CodeEditor.SelectionColor = Color.Black;
            }
            foreach (Match keyWordMatch in floatNumberValue.Matches(CodeEditor.Text))
            {

                CodeEditor.Select(keyWordMatch.Index, keyWordMatch.Length);
                CodeEditor.SelectionColor = Color.DeepPink;

                CodeEditor.SelectionStart = selPos;
                CodeEditor.SelectionColor = Color.Black;
            }
            foreach (Match keyWordMatch in intNumberValue.Matches(CodeEditor.Text))
            {

                CodeEditor.Select(keyWordMatch.Index, keyWordMatch.Length);
                CodeEditor.SelectionColor = Color.DeepPink;

                CodeEditor.SelectionStart = selPos;
                CodeEditor.SelectionColor = Color.Black;
            }

        }

        #endregion













        ////Code Editor





        private void visualToCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {


            globalScopeControl.UpdateScope();
            VCodeToCode vBlockToCode = new VCodeToCode(globalScopeControl.GlobalScope);
            Beautify beautifier = new Beautify(vBlockToCode.Code);
            CodeEditor.Text = beautifier.CodeOutput;

        }

        private void codeToVisualToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CodeToVCode codeToVCode = new CodeToVCode(CodeEditor.Text);
            globalScopeControl.VcodeToVblock(codeToVCode.Scope);
        }
    }
}
