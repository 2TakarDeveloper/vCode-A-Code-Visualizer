namespace CodeVisualizer.Controls.Helpers
{
    partial class ParameterControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypePicker = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CloseButton = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // TypePicker
            // 
            this.TypePicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.TypePicker.FormattingEnabled = true;
            this.TypePicker.Items.AddRange(new object[] {
            "int",
            "float",
            "double",
            "string",
            "bool"});
            this.TypePicker.Location = new System.Drawing.Point(0, 0);
            this.TypePicker.Name = "TypePicker";
            this.TypePicker.Size = new System.Drawing.Size(121, 21);
            this.TypePicker.TabIndex = 0;
            this.TypePicker.SelectedIndexChanged += new System.EventHandler(this.TypePicker_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            // 
            // 
            // 
            this.NameTextBox.CustomButton.Image = null;
            this.NameTextBox.CustomButton.Location = new System.Drawing.Point(95, 2);
            this.NameTextBox.CustomButton.Name = "";
            this.NameTextBox.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.NameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTextBox.CustomButton.TabIndex = 1;
            this.NameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTextBox.CustomButton.UseSelectable = true;
            this.NameTextBox.CustomButton.Visible = false;
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameTextBox.Lines = new string[0];
            this.NameTextBox.Location = new System.Drawing.Point(121, 0);
            this.NameTextBox.MaxLength = 32767;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.SelectionLength = 0;
            this.NameTextBox.SelectionStart = 0;
            this.NameTextBox.ShortcutsEnabled = true;
            this.NameTextBox.Size = new System.Drawing.Size(115, 22);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.UseSelectable = true;
            this.NameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = global::CodeVisualizer.Controls.Properties.Resources._1484856362_Close_Box_Red;
            this.CloseButton.Location = new System.Drawing.Point(260, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseSelectable = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ParameterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TypePicker);
            this.Name = "ParameterControl";
            this.Size = new System.Drawing.Size(286, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TypePicker;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        public MetroFramework.Controls.MetroLink CloseButton;
    }
}
