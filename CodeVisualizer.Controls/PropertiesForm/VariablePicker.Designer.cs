namespace CodeVisualizer.Controls.PropertiesForm
{
    partial class VariablePicker
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
            this.VariablePickerBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // VariablePickerBox
            // 
            this.VariablePickerBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.VariablePickerBox.FormattingEnabled = true;
            this.VariablePickerBox.Location = new System.Drawing.Point(20, 60);
            this.VariablePickerBox.Name = "VariablePickerBox";
            this.VariablePickerBox.Size = new System.Drawing.Size(171, 21);
            this.VariablePickerBox.TabIndex = 0;
            this.VariablePickerBox.SelectedIndexChanged += new System.EventHandler(this.VariablePickerBox_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.submitButton.Location = new System.Drawing.Point(20, 81);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(171, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Confirm";
            this.submitButton.UseSelectable = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // VariablePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 128);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.VariablePickerBox);
            this.Name = "VariablePicker";
            this.Text = "VariablePicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox VariablePickerBox;
        private MetroFramework.Controls.MetroButton submitButton;
    }
}