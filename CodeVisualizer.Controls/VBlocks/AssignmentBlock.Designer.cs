namespace CodeVisualizer.Controls.VBlocks
{
    partial class AssignmentBlock
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
            this.AssignmentStringLable = new MetroFramework.Controls.MetroLabel();
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(310, 23);
            // 
            // NameLable
            // 
            this.NameLable.Size = new System.Drawing.Size(86, 19);
            this.NameLable.Text = "Assignment";
            this.NameLable.UseCustomBackColor = true;
            this.NameLable.UseCustomForeColor = true;
            // 
            // body
            // 
            this.body.Controls.Add(this.AssignmentStringLable);
            this.body.Size = new System.Drawing.Size(312, 24);
            this.body.Controls.SetChildIndex(this.Header, 0);
            this.body.Controls.SetChildIndex(this.AssignmentStringLable, 0);
            // 
            // ExpandCollapseButton
            // 
            this.ExpandCollapseButton.Location = new System.Drawing.Point(124, 1);
            this.ExpandCollapseButton.Visible = false;
            this.ExpandCollapseButton.Click += new System.EventHandler(this.ExpandCollapseButton_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(184, 1);
            this.metroButton1.Visible = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(245, 1);
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // DisposeButton
            // 
            this.DisposeButton.Location = new System.Drawing.Point(276, 1);
            this.DisposeButton.Click += new System.EventHandler(this.DisposeButton_Click);
            // 
            // AssignmentStringLable
            // 
            this.AssignmentStringLable.AutoSize = true;
            this.AssignmentStringLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignmentStringLable.Location = new System.Drawing.Point(0, 23);
            this.AssignmentStringLable.Name = "AssignmentStringLable";
            this.AssignmentStringLable.Size = new System.Drawing.Size(81, 19);
            this.AssignmentStringLable.TabIndex = 7;
            this.AssignmentStringLable.Text = "metroLabel1";
            // 
            // AssignmentBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Name = "AssignmentBlock";
            this.Size = new System.Drawing.Size(342, 54);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel AssignmentStringLable;
    }
}
