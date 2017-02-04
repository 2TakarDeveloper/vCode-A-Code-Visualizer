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
            scopeControl.Scope=new Scope();
            scopeControl.GlobalScope = new GlobalScope {Scope = scopeControl.Scope};
        }
















        ////Code Editor
       
     

        private void CodeEditor_TextChanged(object sender, EventArgs e)
        {
          
           //Code

        }

        private void visualToCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            scopeControl.UpdateScope();
            VCodeToCode vBlockToCode = new VCodeToCode(scopeControl.GlobalScope);
            Beautify beautifier= new Beautify(vBlockToCode.Code);
            CodeEditor.Text = beautifier.CodeOutput;
            
        }

        private void codeToVisualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CodeToVCode codeToVCode = new CodeToVCode(CodeEditor.Text);
            scopeControl.VcodeToVblock(codeToVCode.Scope.Items);
        }
    }
}
