namespace CodeVisualizer.Controls.PropertiesForm
{
    partial class FunctionPicker
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.functionPickerBox = new System.Windows.Forms.ComboBox();
            this.ConfirmButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // functionPickerBox
            // 
            this.functionPickerBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.functionPickerBox.FormattingEnabled = true;
            this.functionPickerBox.Location = new System.Drawing.Point(20, 60);
            this.functionPickerBox.Name = "functionPickerBox";
            this.functionPickerBox.Size = new System.Drawing.Size(228, 21);
            this.functionPickerBox.TabIndex = 0;
            this.functionPickerBox.SelectedIndexChanged += new System.EventHandler(this.functionPickerBox_SelectedIndexChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConfirmButton.Location = new System.Drawing.Point(20, 83);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(228, 23);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseSelectable = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // FunctionPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 126);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.functionPickerBox);
            this.Name = "FunctionPicker";
            this.Text = "FunctionPicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox functionPickerBox;
        private MetroFramework.Controls.MetroButton ConfirmButton;
    }
}