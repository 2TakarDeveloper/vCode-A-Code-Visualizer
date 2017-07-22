namespace CodeVisualizer.Controls.VBlocks
{
    partial class Vwhile
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
            DTD.Entity.Helpers.Condition condition2 = new DTD.Entity.Helpers.Condition();
            this.conditionControl1 = new CodeVisualizer.Controls.Helpers.ConditionControl();
            this.scopeControl = new CodeVisualizer.Controls.Helpers.ScopeControl();
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.conditionControl1);
            this.Header.Size = new System.Drawing.Size(522, 24);
            this.Header.Controls.SetChildIndex(this.ExpandCollapseButton, 0);
            this.Header.Controls.SetChildIndex(this.metroButton1, 0);
            this.Header.Controls.SetChildIndex(this.DisposeButton, 0);
            this.Header.Controls.SetChildIndex(this.settingsButton, 0);
            this.Header.Controls.SetChildIndex(this.NameLable, 0);
            this.Header.Controls.SetChildIndex(this.conditionControl1, 0);
            // 
            // NameLable
            // 
            this.NameLable.Size = new System.Drawing.Size(47, 19);
            this.NameLable.Text = "While";
            // 
            // body
            // 
            this.body.Controls.Add(this.scopeControl);
            this.body.Size = new System.Drawing.Size(524, 26);
            this.body.Controls.SetChildIndex(this.Header, 0);
            this.body.Controls.SetChildIndex(this.scopeControl, 0);
            // 
            // ExpandCollapseButton
            // 
            this.ExpandCollapseButton.Location = new System.Drawing.Point(418, 1);
            this.ExpandCollapseButton.Size = new System.Drawing.Size(101, 20);
            this.ExpandCollapseButton.Click += new System.EventHandler(this.ExpandCollapseButton_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(343, 1);
            this.metroButton1.Size = new System.Drawing.Size(75, 20);
            this.metroButton1.Visible = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(281, 1);
            this.settingsButton.Size = new System.Drawing.Size(31, 20);
            this.settingsButton.Visible = false;
            // 
            // DisposeButton
            // 
            this.DisposeButton.Location = new System.Drawing.Point(312, 1);
            this.DisposeButton.Size = new System.Drawing.Size(31, 20);
            this.DisposeButton.Click += new System.EventHandler(this.DisposeButton_Click);
            // 
            // conditionControl1
            // 
            condition2.BooleanOperator = "<=";
            condition2.LeftParameter = "x";
            condition2.RightParameter = "5";
            this.conditionControl1.Condition = condition2;
            this.conditionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.conditionControl1.Location = new System.Drawing.Point(48, 1);
            this.conditionControl1.Name = "conditionControl1";
            this.conditionControl1.Size = new System.Drawing.Size(201, 20);
            this.conditionControl1.TabIndex = 3;
            // 
            // scopeControl
            // 
            this.scopeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scopeControl.Location = new System.Drawing.Point(0, 24);
            this.scopeControl.Name = "scopeControl";
            this.scopeControl.Scope = null;
            this.scopeControl.Size = new System.Drawing.Size(522, 0);
            this.scopeControl.TabIndex = 7;
            // 
            // Vwhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "Vwhile";
            this.Size = new System.Drawing.Size(554, 56);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Helpers.ScopeControl scopeControl1;
        private Helpers.ConditionControl conditionControl1;
        private Helpers.ScopeControl scopeControl;
    }
}
