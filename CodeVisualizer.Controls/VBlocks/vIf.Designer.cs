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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.settingsButton = new MetroFramework.Controls.MetroLink();
            this.DisposeButton = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.scope = new CodeVisualizer.Controls.Scope.ScopeControl();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Snow;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.settingsButton);
            this.metroPanel1.Controls.Add(this.DisposeButton);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(521, 24);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsButton.Image = global::CodeVisualizer.Controls.Properties.Resources._1484856678_cog;
            this.settingsButton.Location = new System.Drawing.Point(457, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(31, 22);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.UseSelectable = true;
            // 
            // DisposeButton
            // 
            this.DisposeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DisposeButton.Image = global::CodeVisualizer.Controls.Properties.Resources._1484856362_Close_Box_Red;
            this.DisposeButton.Location = new System.Drawing.Point(488, 0);
            this.DisposeButton.Name = "DisposeButton";
            this.DisposeButton.Size = new System.Drawing.Size(31, 22);
            this.DisposeButton.TabIndex = 5;
            this.DisposeButton.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "IF";
            // 
            // scope
            // 
            this.scope.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scope.Location = new System.Drawing.Point(0, 24);
            this.scope.Name = "scope";
            this.scope.Scope = null;
            this.scope.Size = new System.Drawing.Size(521, 215);
            this.scope.TabIndex = 1;
            // 
            // Vif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scope);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Vif";
            this.Size = new System.Drawing.Size(521, 239);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Scope.ScopeControl scope;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink settingsButton;
        private MetroFramework.Controls.MetroLink DisposeButton;
    }
}
