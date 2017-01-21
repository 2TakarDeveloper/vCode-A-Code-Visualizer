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
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Size = new System.Drawing.Size(258, 29);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(163, 0);
            this.settingsButton.Size = new System.Drawing.Size(33, 26);
            // 
            // NameLable
            // 
            this.NameLable.Location = new System.Drawing.Point(15, 4);
            this.NameLable.Size = new System.Drawing.Size(104, 19);
            this.NameLable.Text = "VariableName";
            // 
            // DisposeButton
            // 
            this.DisposeButton.Location = new System.Drawing.Point(202, 0);
            this.DisposeButton.Size = new System.Drawing.Size(31, 26);
            // 
            // body
            // 
            this.body.Size = new System.Drawing.Size(258, 29);
            // 
            // Vvariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Vvariable";
            this.Size = new System.Drawing.Size(258, 29);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
