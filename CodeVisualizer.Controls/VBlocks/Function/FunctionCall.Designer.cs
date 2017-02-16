namespace CodeVisualizer.Controls.VBlocks.Function
{
    partial class FunctionCall
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
            this.functionName = new MetroFramework.Controls.MetroLabel();
            this.CloseButton = new MetroFramework.Controls.MetroLink();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.functionName);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(162, 88);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // functionName
            // 
            this.functionName.AutoSize = true;
            this.functionName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.functionName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.functionName.Location = new System.Drawing.Point(12, 30);
            this.functionName.Name = "functionName";
            this.functionName.Size = new System.Drawing.Size(136, 25);
            this.functionName.TabIndex = 2;
            this.functionName.Text = "FunctionName";
            // 
            // CloseButton
            // 
            this.CloseButton.Image = global::CodeVisualizer.Controls.Properties.Resources._1484856362_Close_Box_Red;
            this.CloseButton.Location = new System.Drawing.Point(499, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseSelectable = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FlowPanel
            // 
            this.FlowPanel.AutoScroll = true;
            this.FlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowPanel.Location = new System.Drawing.Point(162, 0);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(324, 88);
            this.FlowPanel.TabIndex = 2;
            // 
            // FunctionCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FlowPanel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FunctionCall";
            this.Size = new System.Drawing.Size(524, 88);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel functionName;
        private MetroFramework.Controls.MetroLink CloseButton;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
    }
}
