using System.Windows.Forms;
using CodeVisualizer.Controls.Helpers;
using DTD.Entity;
using GlobalLibrary;
using MetroFramework.Controls;

namespace CodeVisualizer.Controls.VBlocks
{
    public partial class VBlock: MetroUserControl
    {
       

        public VCode VCode { get; set; }
        public ScopeControl ScopeControl { get; set; }
        public VBlock()
        {
            InitializeComponent();
            
            ControlMoverOrResizer.Init(this);//This Allows the Controls to be movable and resizable
            ControlMoverOrResizer.WorkType = ControlMoverOrResizer.MoveOrResize.Resize;

        }

        private void DisposeButton_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }



    }
}
