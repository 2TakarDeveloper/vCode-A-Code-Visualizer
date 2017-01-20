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

namespace CodeVisualizer.Controls.VBlocks
{
    public partial class Vwhile : VBlock
    {
        private VCode vCode { get; set; }
        public Vwhile()
        {
            InitializeComponent();
        }
    }
}
