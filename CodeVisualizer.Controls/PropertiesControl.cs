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
using MetroFramework.Controls;

namespace CodeVisualizer.Controls
{
    public partial class PropertiesControl : MetroUserControl
    {
        public PropertiesControl()
        {
            InitializeComponent();
        }

        public PropertiesControl(Function function)
        {
            InitializeComponent();
        }


        public PropertiesControl(If If)
        {
            InitializeComponent();
        }

        public PropertiesControl(While wWhile)
        {
            InitializeComponent();
        }

       


    }
}
