namespace CodeVisualizer.Controls.VBlocks
{
    partial class Vvariable
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
            this.NameLable = new MetroFramework.Controls.MetroLabel();
            this.settingsButton = new MetroFramework.Controls.MetroLink();
            this.DisposeButton = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLable.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.NameLable.Location = new System.Drawing.Point(0, 0);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(104, 19);
            this.NameLable.TabIndex = 2;
            this.NameLable.Text = "VariableName";
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsButton.Image = global::CodeVisualizer.Controls.Properties.Resources._1484856678_cog;
            this.settingsButton.Location = new System.Drawing.Point(180, 0);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(31, 23);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.UseSelectable = true;
            // 
            // DisposeButton
            // 
            this.DisposeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DisposeButton.Image = global::CodeVisualizer.Controls.Properties.Resources._1484856362_Close_Box_Red;
            this.DisposeButton.Location = new System.Drawing.Point(211, 0);
            this.DisposeButton.Name = "DisposeButton";
            this.DisposeButton.Size = new System.Drawing.Size(31, 23);
            this.DisposeButton.TabIndex = 3;
            this.DisposeButton.UseSelectable = true;
            // 
            // vVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.DisposeButton);
            this.Controls.Add(this.NameLable);
            this.Name = "vVariable";
            this.Size = new System.Drawing.Size(242, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel NameLable;
        private MetroFramework.Controls.MetroLink DisposeButton;
        private MetroFramework.Controls.MetroLink settingsButton;
    }
}
