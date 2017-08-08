namespace CodeVisualizer.Controls.VBlocks
{
    partial class VBlock
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
            this.Header = new System.Windows.Forms.Panel();
            this.ExpandCollapseButton = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.settingsButton = new MetroFramework.Controls.MetroLink();
            this.DisposeButton = new MetroFramework.Controls.MetroLink();
            this.NameLable = new MetroFramework.Controls.MetroLabel();
            this.body = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Header.Controls.Add(this.ExpandCollapseButton);
            this.Header.Controls.Add(this.metroButton1);
            this.Header.Controls.Add(this.settingsButton);
            this.Header.Controls.Add(this.DisposeButton);
            this.Header.Controls.Add(this.NameLable);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(1);
            this.Header.Size = new System.Drawing.Size(616, 23);
            this.Header.TabIndex = 6;
            // 
            // ExpandCollapseButton
            // 
            this.ExpandCollapseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExpandCollapseButton.Location = new System.Drawing.Point(430, 1);
            this.ExpandCollapseButton.Name = "ExpandCollapseButton";
            this.ExpandCollapseButton.Size = new System.Drawing.Size(60, 19);
            this.ExpandCollapseButton.TabIndex = 14;
            this.ExpandCollapseButton.Text = "+/-";
            this.ExpandCollapseButton.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.LightGray;
            this.metroButton1.BackgroundImage = global::CodeVisualizer.Controls.Properties.Resources.icon_ios7_refresh_empty_128;
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroButton1.Location = new System.Drawing.Point(490, 1);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(61, 19);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Refresh";
            this.metroButton1.UseSelectable = true;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsButton.Image = global::CodeVisualizer.Controls.Properties.Resources._1484856678_cog;
            this.settingsButton.Location = new System.Drawing.Point(551, 1);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(31, 19);
            this.settingsButton.TabIndex = 12;
            this.settingsButton.UseCustomBackColor = true;
            this.settingsButton.UseSelectable = true;
            // 
            // DisposeButton
            // 
            this.DisposeButton.BackColor = System.Drawing.Color.Gray;
            this.DisposeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DisposeButton.Image = global::CodeVisualizer.Controls.Properties.Resources._1484856362_Close_Box_Red;
            this.DisposeButton.Location = new System.Drawing.Point(582, 1);
            this.DisposeButton.Name = "DisposeButton";
            this.DisposeButton.Size = new System.Drawing.Size(31, 19);
            this.DisposeButton.TabIndex = 11;
            this.DisposeButton.UseSelectable = true;
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Dock = System.Windows.Forms.DockStyle.Left;
            this.NameLable.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.NameLable.Location = new System.Drawing.Point(1, 1);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(75, 19);
            this.NameLable.TabIndex = 2;
            this.NameLable.Text = "SomeText";
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.White;
            this.body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.body.Controls.Add(this.Header);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(15, 15);
            this.body.Margin = new System.Windows.Forms.Padding(1);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(618, 316);
            this.body.TabIndex = 7;
            // 
            // VBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.body);
            this.Name = "VBlock";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(648, 346);
            this.UseCustomBackColor = true;
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel Header;
        protected MetroFramework.Controls.MetroLabel NameLable;
        protected System.Windows.Forms.Panel body;
        public MetroFramework.Controls.MetroButton ExpandCollapseButton;
        public MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroLink settingsButton;
        protected MetroFramework.Controls.MetroLink DisposeButton;
    }
}
