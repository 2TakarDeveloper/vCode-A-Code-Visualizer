using System.Windows.Forms;
using Core;
using DTD.Entity;
using MetroFramework.Controls;

namespace CodeVisualizer.Controls.VBlocks
{
    public partial class VBlock: MetroUserControl
    {
        protected VCode VCode { get; set; }
        protected VBlock()
        {
            InitializeComponent();
   
            ControlMoverOrResizer.Init(Header, this);//This Allows the Controls to be movable and resizable
  
        }

        private void DisposeButton_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }
    }
}
