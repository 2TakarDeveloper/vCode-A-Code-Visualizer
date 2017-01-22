using System.Windows.Forms;
using Core;
using DTD.Entity;
using MetroFramework.Controls;

namespace CodeVisualizer.Controls.VBlocks
{
    public partial class VBlock: MetroUserControl
    {
        public VCode VCode { get; set; }
        protected VBlock()
        {
            InitializeComponent();
   
            ControlMoverOrResizer.Init(this);//This Allows the Controls to be movable and resizable
  
        }

        private void DisposeButton_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
