using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Entity.Enum;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.VBlocks
{
    public partial class ConstantBlock : UserControl
    {
        public Constant Constant { get; set; }
        private Enums.Type variableType { get; set; }

        public ConstantBlock(DTD.Entity.vCodes.Variable variable)
        {
            InitializeComponent();
            Constant=new Constant();
            Constant.VType=Enums.VType.Constant;
            variableType = variable.Type;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            switch (variableType)
            {
                case Enums.Type.Int:
                    Constant.Value = textBox1.Text;
                    break;
                case Enums.Type.Float:
                    Constant.Value = textBox1.Text;
                    break;
                case Enums.Type.Double:
                    Constant.Value = textBox1.Text;
                    break;
                case Enums.Type.String:
                    Constant.Value = "\"" + textBox1.Text + "\"";
                    break;
                case Enums.Type.Bool:
                    Constant.Value = textBox1.Text;
                    break;
               
                case Enums.Type.Char:
                    Constant.Value = "'" + textBox1.Text + "'";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            
           
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
