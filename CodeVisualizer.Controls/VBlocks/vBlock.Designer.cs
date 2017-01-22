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
            this.settingsButton = new MetroFramework.Controls.MetroLink();
            this.NameLable = new MetroFramework.Controls.MetroLabel();
            this.DisposeButton = new MetroFramework.Controls.MetroLink();
            this.body = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.settingsButton);
            this.Header.Controls.Add(this.NameLable);
            this.Header.Controls.Add(this.DisposeButton);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(1);
            this.Header.Size = new System.Drawing.Size(616, 23);
            this.Header.TabIndex = 6;
            this.Header.Paint += new System.Windows.Forms.PaintEventHandler(this.Header_Paint);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Gray;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsButton.Image = global::CodeVisualizer.Controls.Properties.Resources._1484856678_cog;
            this.settingsButton.Location = new System.Drawing.Point(553, 1);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(31, 21);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.UseSelectable = true;
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
            // DisposeButton
            // 
            this.DisposeButton.BackColor = System.Drawing.Color.Gray;
            this.DisposeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DisposeButton.Image = global::CodeVisualizer.Controls.Properties.Resources._1484856362_Close_Box_Red;
            this.DisposeButton.Location = new System.Drawing.Point(584, 1);
            this.DisposeButton.Name = "DisposeButton";
            this.DisposeButton.Size = new System.Drawing.Size(31, 21);
            this.DisposeButton.TabIndex = 3;
            this.DisposeButton.UseSelectable = true;
            this.DisposeButton.Click += new System.EventHandler(this.DisposeButton_Click);
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
            this.BackColor = System.Drawing.Color.PaleTurquoise;
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
        protected MetroFramework.Controls.MetroLink settingsButton;
        protected MetroFramework.Controls.MetroLabel NameLable;
        protected MetroFramework.Controls.MetroLink DisposeButton;
        protected System.Windows.Forms.Panel body;
    }
}
