namespace CodeVisualizer.Controls.VBlocks
{
    partial class Vfunction
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
            this.scopeControl = new CodeVisualizer.Controls.Helpers.ScopeControl();
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Location = new System.Drawing.Point(10, 10);
            this.Header.Size = new System.Drawing.Size(457, 24);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(394, 1);
            this.settingsButton.Size = new System.Drawing.Size(31, 22);
            // 
            // NameLable
            // 
            this.NameLable.Size = new System.Drawing.Size(65, 19);
            this.NameLable.Text = "Function";
            // 
            // DisposeButton
            // 
            this.DisposeButton.Location = new System.Drawing.Point(425, 1);
            this.DisposeButton.Size = new System.Drawing.Size(31, 22);
            // 
            // body
            // 
            this.body.Controls.Add(this.scopeControl);
            this.body.Padding = new System.Windows.Forms.Padding(10);
            this.body.Size = new System.Drawing.Size(479, 261);
            this.body.Controls.SetChildIndex(this.Header, 0);
            this.body.Controls.SetChildIndex(this.scopeControl, 0);
            // 
            // scopeControl
            // 
            this.scopeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scopeControl.GlobalScope = null;
            this.scopeControl.Location = new System.Drawing.Point(10, 34);
            this.scopeControl.Name = "scopeControl";
            this.scopeControl.Scope = null;
            this.scopeControl.Size = new System.Drawing.Size(457, 215);
            this.scopeControl.TabIndex = 7;
            // 
            // Vfunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "Vfunction";
            this.Size = new System.Drawing.Size(509, 291);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Helpers.ScopeControl scopeControl;
    }
}
