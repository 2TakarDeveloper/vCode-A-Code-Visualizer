﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.VBlocks
{
    public partial class Vif : VBlock
    {
    
        public Vif()
        {
            InitializeComponent();
            NameLable.Text = @"If";
            scopeControl1.Scope=new Scope();
            conditionControl1.Condition = new Condition();
            var iIf = new If
            {
                Scope = scopeControl1.Scope,
                Condition = conditionControl1.Condition
            };
            VCode = (If) iIf;
        }

      
    }
}