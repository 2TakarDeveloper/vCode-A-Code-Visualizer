using CodeVisualizer.Controls.Helpers;

namespace CodeVisualizer.Controls.VBlocks
{
    partial class Vif
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
            this.scopeControl1 = new CodeVisualizer.Controls.Helpers.ScopeControl();
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(400, 33);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(305, 2);
            this.settingsButton.Size = new System.Drawing.Size(31, 28);
            // 
            // NameLable
            // 
            this.NameLable.Location = new System.Drawing.Point(21, 7);
            this.NameLable.Size = new System.Drawing.Size(20, 19);
            this.NameLable.Text = "IF";
            // 
            // DisposeButton
            // 
            this.DisposeButton.Location = new System.Drawing.Point(342, 2);
            this.DisposeButton.Size = new System.Drawing.Size(31, 28);
            // 
            // body
            // 
            this.body.Controls.Add(this.scopeControl1);
            this.body.Size = new System.Drawing.Size(400, 300);
            this.body.Controls.SetChildIndex(this.Header, 0);
            this.body.Controls.SetChildIndex(this.scopeControl1, 0);
            // 
            // scopeControl1
            // 
            this.scopeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scopeControl1.Location = new System.Drawing.Point(0, 33);
            this.scopeControl1.Name = "scopeControl1";
            this.scopeControl1.Scope = null;
            this.scopeControl1.Size = new System.Drawing.Size(400, 267);
            this.scopeControl1.TabIndex = 7;
            // 
            // Vif
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Green;
            this.Name = "Vif";
            this.Size = new System.Drawing.Size(400, 300);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ScopeControl scopeControl1;
    }
}
