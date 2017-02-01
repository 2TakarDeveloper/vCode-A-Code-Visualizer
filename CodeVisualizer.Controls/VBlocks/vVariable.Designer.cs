namespace CodeVisualizer.Controls.VBlocks
{
    partial class Vvariable
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
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(213, 23);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(148, 1);
            this.settingsButton.Size = new System.Drawing.Size(33, 21);
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // NameLable
            // 
            this.NameLable.Size = new System.Drawing.Size(104, 19);
            this.NameLable.Text = "VariableName";
            this.NameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisposeButton
            // 
            this.DisposeButton.Location = new System.Drawing.Point(181, 1);
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(10, 10);
            this.body.Size = new System.Drawing.Size(215, 25);
            // 
            // Vvariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Vvariable";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(235, 45);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
