using System;
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
















        ////Code Editor
       
     

        private void CodeEditor_TextChanged(object sender, EventArgs e)
        {
          
           //Code

        }

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
