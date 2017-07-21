namespace CodeVisualizer.Controls.VBlocks.Function
{
    partial class Vfunction
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
            this.scopeControl = new CodeVisualizer.Controls.Helpers.ScopeControl();
            this.returnPicker = new System.Windows.Forms.ComboBox();
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Location = new System.Drawing.Point(10, 10);
            this.Header.Size = new System.Drawing.Size(594, 31);
            // 
            // NameLable
            // 
            this.NameLable.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.NameLable.Size = new System.Drawing.Size(86, 25);
            this.NameLable.Text = "Function";
            // 
            // body
            // 
            this.body.Controls.Add(this.scopeControl);
            this.body.Padding = new System.Windows.Forms.Padding(10);
            this.body.Size = new System.Drawing.Size(616, 65);
            this.body.Controls.SetChildIndex(this.Header, 0);
            this.body.Controls.SetChildIndex(this.scopeControl, 0);
            // 
            // ExpandCollapseButton
            // 
            this.ExpandCollapseButton.Location = new System.Drawing.Point(353, 1);
            this.ExpandCollapseButton.Size = new System.Drawing.Size(101, 27);
            this.ExpandCollapseButton.Click += new System.EventHandler(this.ExpandCollapseButton_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(454, 1);
            this.metroButton1.Size = new System.Drawing.Size(75, 27);
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(529, 1);
            this.settingsButton.Size = new System.Drawing.Size(31, 27);
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // DisposeButton
            // 
            this.DisposeButton.Location = new System.Drawing.Point(560, 1);
            this.DisposeButton.Size = new System.Drawing.Size(31, 27);
            // 
            // scopeControl
            // 
            this.scopeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scopeControl.Location = new System.Drawing.Point(10, 41);
            this.scopeControl.Name = "scopeControl";
            this.scopeControl.Scope = null;
            this.scopeControl.Size = new System.Drawing.Size(594, 12);
            this.scopeControl.TabIndex = 7;
            // 
            // returnPicker
            // 
            this.returnPicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.returnPicker.FormattingEnabled = true;
            this.returnPicker.Location = new System.Drawing.Point(15, 59);
            this.returnPicker.Name = "returnPicker";
            this.returnPicker.Size = new System.Drawing.Size(616, 21);
            this.returnPicker.TabIndex = 8;
            this.returnPicker.SelectedIndexChanged += new System.EventHandler(this.returnPicker_SelectedIndexChanged);
            // 
            // Vfunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.returnPicker);
            this.Name = "Vfunction";
            this.Size = new System.Drawing.Size(646, 95);
            this.Controls.SetChildIndex(this.body, 0);
            this.Controls.SetChildIndex(this.returnPicker, 0);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Helpers.ScopeControl scopeControl;
        private System.Windows.Forms.ComboBox returnPicker;
    }
}
