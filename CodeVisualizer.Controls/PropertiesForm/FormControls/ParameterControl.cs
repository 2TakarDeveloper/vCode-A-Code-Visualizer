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

namespace CodeVisualizer.Controls.PropertiesForm.FormControls
{
    public partial class ParameterControl : MetroFramework.Controls.MetroUserControl
    {
        public Parameter Parameter { get; set; }
        public ParameterControl()
        {
            InitializeComponent();
            Parameter=new Parameter();
        }

        public ParameterControl(Parameter parameter)
        {
            Parameter = parameter;
            InitializeComponent();
            TypePicker.Text = Parameter.Type;
            NameTextBox.Text = Parameter.Name;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parameter.Type = TypePicker.Text;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Parameter.Name = NameTextBox.Text;
        }
    }
}
