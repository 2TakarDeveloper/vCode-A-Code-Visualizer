using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.Instructions
{
    public partial class OneAddressInstruction : MetroFramework.Controls.MetroUserControl
    {
        public SingleInstruction SingleInstruction { get; set; }
        public OneAddressInstruction()
        {
            InitializeComponent();
        }
    }
}
