using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Entity;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.VBlocks
{
    public partial class Vfunction : VBlock
    {
        
        public Vfunction()
        {
            InitializeComponent();
            VCode=new Function();
            Function f = (Function)VCode;
            NameLable.Text = f.Name;
        }
    }
}
