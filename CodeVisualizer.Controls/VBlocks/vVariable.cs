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
using MetroFramework.Controls;

namespace CodeVisualizer.Controls.VBlocks
{
    public partial class Vvariable: VBlock
    {
   
        public Vvariable(VCode vCode)
        {
            InitializeComponent();
            VCode = vCode;
        }

       

        
    }
}
