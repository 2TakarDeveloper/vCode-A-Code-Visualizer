using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeVisualizer.Controls.Helpers;
using CodeVisualizer.Controls.VBlocks;
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.vCodes;

namespace Core.Converter
{
    class VCodeToVBlock
    {
        public ScopeControl ScopeControl { get; set; }


        public VCodeToVBlock(VCode vCode)
        {
            ScopeControl = new ScopeControl();
            VCodeToBlock(vCode);
        }

        private void VCodeToBlock(VCode vcode)
        {

            if (vcode.VType == Enums.VType.GlobalScope)
            {
                ScopeControl= new ScopeControl();
                

            }


            if (vcode.VType == Enums.VType.Variable)
            {
               Vvariable vvariable= new Vvariable(vcode);
               
            }


            if (vcode.VType == Enums.VType.If)
            {
                Vif vif = new Vif {VCode = vcode};
               

            }

            if (vcode.VType == Enums.VType.While)
            {
                Vwhile vwhile = new Vwhile {VCode = vcode};

            }


            if (vcode.VType == Enums.VType.Function)
            {
                Vfunction vfunction = new Vfunction {VCode = vcode};
            }


        }
    }
}
