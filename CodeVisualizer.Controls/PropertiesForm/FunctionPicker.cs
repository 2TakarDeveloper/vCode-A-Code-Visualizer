using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Entity.vCodes;

namespace CodeVisualizer.Controls.PropertiesForm
{
    public partial class FunctionPicker : MetroFramework.Forms.MetroForm
    {
        public Function Function { get; set; }

        public FunctionPicker(List<Function> functions,Variable selectedVariable)
        {
            InitializeComponent();
            foreach (var func in functions)
            {
                if(func.Type==selectedVariable.Type)
                functionPickerBox.Items.Add(func);
            }



        }

        private void functionPickerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Function = (Function)functionPickerBox.SelectedItem;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
            
        }
    }
}
