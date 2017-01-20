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
        private VCode _vCode;
        public Vvariable(VCode variable)
        {
            InitializeComponent();
            _vCode = variable;
        }

        //public Vvariable(Variable<int> variable)
        //{
        //    InitializeComponent();
        //    _vCode = variable;
        //}

        //public Vvariable(Variable<float> variable)
        //{
        //    InitializeComponent();
        //    _vCode = variable;
        //}

        //public Vvariable(Variable<double> variable)
        //{
        //    InitializeComponent();
        //    _vCode = variable;
        //}

        //public Vvariable(Variable<string> variable)
        //{
        //    InitializeComponent();
        //    _vCode = variable;
        //}

        //public Vvariable(Variable<bool> variable)
        //{
        //    InitializeComponent();
        //    _vCode = variable;
        //}

        
    }
}
