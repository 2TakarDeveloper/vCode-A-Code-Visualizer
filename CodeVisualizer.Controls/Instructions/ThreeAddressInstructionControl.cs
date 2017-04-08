using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Entity.Helpers;

namespace CodeVisualizer.Controls.Instructions
{
    public partial class ThreeAddressInstructionControl : MetroFramework.Controls.MetroUserControl
    {
        public ThreeAddressInstruction ThreeAddressInstruction { get; set; }
        
        public ThreeAddressInstructionControl()
        {
            InitializeComponent();
        }
    }
}
