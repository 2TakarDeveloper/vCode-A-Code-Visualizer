namespace CodeVisualizer.Controls.Helpers
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
            this.components = new System.ComponentModel.Container();
            this.ContextMenuStrip = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.variableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScopePanel = new System.Windows.Forms.Panel();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variableToolStripMenuItem,
            this.iFToolStripMenuItem,
            this.functionToolStripMenuItem,
            this.whileToolStripMenuItem});
            this.ContextMenuStrip.Name = "ContextMenu";
            this.ContextMenuStrip.Size = new System.Drawing.Size(122, 92);
            this.ContextMenuStrip.Text = "Component";
            // 
            // variableToolStripMenuItem
            // 
            this.variableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intToolStripMenuItem,
            this.floatToolStripMenuItem,
            this.doubleToolStripMenuItem,
            this.stringToolStripMenuItem,
            this.boolToolStripMenuItem});
            this.variableToolStripMenuItem.Name = "variableToolStripMenuItem";
            this.variableToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.variableToolStripMenuItem.Text = "Variable";
            // 
            // intToolStripMenuItem
            // 
            this.intToolStripMenuItem.Name = "intToolStripMenuItem";
            this.intToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.intToolStripMenuItem.Text = "int";
            this.intToolStripMenuItem.Click += new System.EventHandler(this.intToolStripMenuItem_Click);
            // 
            // floatToolStripMenuItem
            // 
            this.floatToolStripMenuItem.Name = "floatToolStripMenuItem";
            this.floatToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.floatToolStripMenuItem.Text = "float";
            this.floatToolStripMenuItem.Click += new System.EventHandler(this.floatToolStripMenuItem_Click);
            // 
            // doubleToolStripMenuItem
            // 
            this.doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
            this.doubleToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.doubleToolStripMenuItem.Text = "double";
            this.doubleToolStripMenuItem.Click += new System.EventHandler(this.doubleToolStripMenuItem_Click);
            // 
            // stringToolStripMenuItem
            // 
            this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            this.stringToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.stringToolStripMenuItem.Text = "string";
            this.stringToolStripMenuItem.Click += new System.EventHandler(this.stringToolStripMenuItem_Click);
            // 
            // boolToolStripMenuItem
            // 
            this.boolToolStripMenuItem.Name = "boolToolStripMenuItem";
            this.boolToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.boolToolStripMenuItem.Text = "bool";
            this.boolToolStripMenuItem.Click += new System.EventHandler(this.boolToolStripMenuItem_Click);
            // 
            // iFToolStripMenuItem
            // 
            this.iFToolStripMenuItem.Name = "iFToolStripMenuItem";
            this.iFToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.iFToolStripMenuItem.Text = "IF";
            this.iFToolStripMenuItem.Click += new System.EventHandler(this.iFToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.functionToolStripMenuItem.Text = "Function";
            this.functionToolStripMenuItem.Click += new System.EventHandler(this.functionToolStripMenuItem_Click);
            // 
            // whileToolStripMenuItem
            // 
            this.whileToolStripMenuItem.Name = "whileToolStripMenuItem";
            this.whileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.whileToolStripMenuItem.Text = "While";
            this.whileToolStripMenuItem.Click += new System.EventHandler(this.whileToolStripMenuItem_Click);
            // 
            // ScopePanel
            // 
            this.ScopePanel.AutoScroll = true;
            this.ScopePanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ScopePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScopePanel.ContextMenuStrip = this.ContextMenuStrip;
            this.ScopePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScopePanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ScopePanel.Location = new System.Drawing.Point(0, 0);
            this.ScopePanel.Name = "ScopePanel";
            this.ScopePanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScopePanel.Size = new System.Drawing.Size(475, 376);
            this.ScopePanel.TabIndex = 1;
            // 
            // ScopeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScopePanel);
            this.Name = "ScopeControl";
            this.Size = new System.Drawing.Size(475, 376);
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private new MetroFramework.Controls.MetroContextMenu ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem variableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boolToolStripMenuItem;
        private System.Windows.Forms.Panel ScopePanel;
    }
}
