namespace CodeVisualizer.Controls.VBlocks.Variable
{
    partial class VariableDataControl
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.ValueTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroComboBox2);
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(251, 40);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(3, 3);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(127, 3);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.TabIndex = 3;
            this.metroComboBox2.UseSelectable = true;
            // 
            // ValueTextBox
            // 
            // 
            // 
            // 
            this.ValueTextBox.CustomButton.Image = null;
            this.ValueTextBox.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.ValueTextBox.CustomButton.Name = "";
            this.ValueTextBox.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.ValueTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ValueTextBox.CustomButton.TabIndex = 1;
            this.ValueTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ValueTextBox.CustomButton.UseSelectable = true;
            this.ValueTextBox.CustomButton.Visible = false;
            this.ValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueTextBox.Lines = new string[0];
            this.ValueTextBox.Location = new System.Drawing.Point(0, 40);
            this.ValueTextBox.MaxLength = 32767;
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.PasswordChar = '\0';
            this.ValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ValueTextBox.SelectedText = "";
            this.ValueTextBox.SelectionLength = 0;
            this.ValueTextBox.SelectionStart = 0;
            this.ValueTextBox.ShortcutsEnabled = true;
            this.ValueTextBox.Size = new System.Drawing.Size(251, 56);
            this.ValueTextBox.TabIndex = 1;
            this.ValueTextBox.UseSelectable = true;
            this.ValueTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ValueTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // VariableDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.metroPanel1);
            this.Name = "VariableDataControl";
            this.Size = new System.Drawing.Size(251, 96);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected MetroFramework.Controls.MetroPanel metroPanel1;
        protected MetroFramework.Controls.MetroComboBox metroComboBox2;
        protected MetroFramework.Controls.MetroComboBox metroComboBox1;
        protected MetroFramework.Controls.MetroTextBox ValueTextBox;
    }
}
