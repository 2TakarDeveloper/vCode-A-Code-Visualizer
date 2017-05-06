using System;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;

namespace CodeVisualizer.Controls.Helpers
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
            TypePicker.Text = Parameter.Type.ToString();
            NameTextBox.Text = Parameter.Name;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypePicker.Text)
            {
                case "int":
                    Parameter.Type = Enums.Type.Int;
                    break;
                case "float":
                    Parameter.Type = Enums.Type.Float;
                    break;
                case "double":
                    Parameter.Type = Enums.Type.Double;
                    break;
                case "string":
                    Parameter.Type = Enums.Type.String;
                    break;
                case "char":
                    Parameter.Type = Enums.Type.Char;
                    break;
                case "bool":
                    Parameter.Type = Enums.Type.Bool;
                    break;
            }

           
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Parameter.Name = NameTextBox.Text;
        }
    }
}
