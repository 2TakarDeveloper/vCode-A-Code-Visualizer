namespace CodeVisualizer.Controls.Scope
{
    partial class ScopeControl
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
            this.newComponentButton = new MetroFramework.Controls.MetroButton();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // newComponentButton
            // 
            this.newComponentButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.newComponentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newComponentButton.ForeColor = System.Drawing.Color.Cyan;
            this.newComponentButton.Location = new System.Drawing.Point(0, 0);
            this.newComponentButton.Name = "newComponentButton";
            this.newComponentButton.Size = new System.Drawing.Size(483, 23);
            this.newComponentButton.TabIndex = 0;
            this.newComponentButton.Text = "New Component";
            this.newComponentButton.UseCustomBackColor = true;
            this.newComponentButton.UseCustomForeColor = true;
            this.newComponentButton.UseSelectable = true;
            // 
            // FlowPanel
            // 
            this.FlowPanel.BackColor = System.Drawing.Color.Peru;
            this.FlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel.Location = new System.Drawing.Point(0, 23);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(483, 198);
            this.FlowPanel.TabIndex = 1;
            // 
            // Scope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlowPanel);
            this.Controls.Add(this.newComponentButton);
            this.Name = "Scope";
            this.Size = new System.Drawing.Size(483, 221);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton newComponentButton;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
    }
}
