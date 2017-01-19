using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CodeVisualizer
{
    public partial class DashBoard : MetroForm
    {
        private string Code { get; set; }

        public DashBoard()
        {
            InitializeComponent();
            
        }
















        ////Code Editor
       
        //RegexPatterns
        private string[] _typepatterns =
        {
            "int", "float", "string", "bool", "void"
        };


        private string[] _codePatterns =
        {
            "if", "else", "while"
        };

        private void CodeEditor_TextChanged(object sender, EventArgs e)
        {
           Code = CodeEditor.Text;//get All text as string from CodeEditor
           

        }

    }
}
