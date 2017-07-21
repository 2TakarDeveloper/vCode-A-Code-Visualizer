using CodeVisualizer.Controls.Helpers;

namespace CodeVisualizer.Controls.VBlocks.Conditionals
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
            DTD.Entity.Helpers.Condition condition1 = new DTD.Entity.Helpers.Condition();
            this.scopeControl = new CodeVisualizer.Controls.Helpers.ScopeControl();
            this.conditionControl1 = new CodeVisualizer.Controls.Helpers.ConditionControl();
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.conditionControl1);
            this.Header.Size = new System.Drawing.Size(525, 23);
            this.Header.Controls.SetChildIndex(this.ExpandCollapseButton, 0);
            this.Header.Controls.SetChildIndex(this.metroButton1, 0);
            this.Header.Controls.SetChildIndex(this.DisposeButton, 0);
            this.Header.Controls.SetChildIndex(this.settingsButton, 0);
            this.Header.Controls.SetChildIndex(this.NameLable, 0);
            this.Header.Controls.SetChildIndex(this.conditionControl1, 0);
            // 
            // NameLable
            // 
            this.NameLable.Size = new System.Drawing.Size(18, 19);
            this.NameLable.Text = "If";
            // 
            // body
            // 
            this.body.Controls.Add(this.scopeControl);
            this.body.Size = new System.Drawing.Size(527, 25);
            this.body.Controls.SetChildIndex(this.Header, 0);
            this.body.Controls.SetChildIndex(this.scopeControl, 0);
            // 
            // ExpandCollapseButton
            // 
            this.ExpandCollapseButton.Location = new System.Drawing.Point(420, 1);
            this.ExpandCollapseButton.Size = new System.Drawing.Size(102, 19);
            this.ExpandCollapseButton.Click += new System.EventHandler(this.ExpandCollapseButton_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(345, 1);
            this.metroButton1.Visible = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(283, 1);
            // 
            // DisposeButton
            // 
            this.DisposeButton.Location = new System.Drawing.Point(314, 1);
            this.DisposeButton.Click += new System.EventHandler(this.DisposeButton_Click);
            // 
            // scopeControl
            // 
            this.scopeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scopeControl.Location = new System.Drawing.Point(0, 23);
            this.scopeControl.Name = "scopeControl";
            this.scopeControl.Scope = null;
            this.scopeControl.Size = new System.Drawing.Size(525, 0);
            this.scopeControl.TabIndex = 7;
            // 
            // conditionControl1
            // 
            condition1.BooleanOperator = "<=";
            condition1.LeftParameter = "x";
            condition1.RightParameter = "5";
            this.conditionControl1.Condition = condition1;
            this.conditionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.conditionControl1.Location = new System.Drawing.Point(19, 1);
            this.conditionControl1.Name = "conditionControl1";
            this.conditionControl1.Size = new System.Drawing.Size(202, 19);
            this.conditionControl1.TabIndex = 3;
            // 
            // Vif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "Vif";
            this.Size = new System.Drawing.Size(557, 55);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ScopeControl scopeControl;
        private ConditionControl conditionControl1;
    }
}
