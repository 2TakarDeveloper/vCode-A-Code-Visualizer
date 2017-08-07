namespace CodeVisualizer.Controls.Helpers
{
    partial class GlobalScopeControl
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
            this.VBlockMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.variableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.FunctionLink = new MetroFramework.Controls.MetroLink();
            this.VariableLink = new MetroFramework.Controls.MetroLink();
            this.GlobalScopePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.VBlockMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VBlockMenu
            // 
            this.VBlockMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variableToolStripMenuItem,
            this.functionToolStripMenuItem});
            this.VBlockMenu.Name = "VBlockMenu";
            this.VBlockMenu.Size = new System.Drawing.Size(122, 48);
            // 
            // variableToolStripMenuItem
            // 
            this.variableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.variableToolStripMenuItem.Name = "variableToolStripMenuItem";
            this.variableToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.variableToolStripMenuItem.Text = "Variable";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.variableToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.mainToolStripMenuItem});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.FunctionToolStripMenuItem1_Click);
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.metroLink1);
            this.panel1.Controls.Add(this.FunctionLink);
            this.panel1.Controls.Add(this.VariableLink);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(514, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 415);
            this.panel1.TabIndex = 1;
            // 
            // metroLink1
            // 
            this.metroLink1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLink1.Image = global::CodeVisualizer.Controls.Properties.Resources.main;
            this.metroLink1.ImageSize = 60;
            this.metroLink1.Location = new System.Drawing.Point(0, 122);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(62, 61);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // FunctionLink
            // 
            this.FunctionLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionLink.Image = global::CodeVisualizer.Controls.Properties.Resources.function;
            this.FunctionLink.ImageSize = 60;
            this.FunctionLink.Location = new System.Drawing.Point(0, 61);
            this.FunctionLink.Name = "FunctionLink";
            this.FunctionLink.Size = new System.Drawing.Size(62, 61);
            this.FunctionLink.TabIndex = 2;
            this.FunctionLink.UseSelectable = true;
            this.FunctionLink.Click += new System.EventHandler(this.FunctionToolStripMenuItem1_Click);
            // 
            // VariableLink
            // 
            this.VariableLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.VariableLink.Image = global::CodeVisualizer.Controls.Properties.Resources.variable;
            this.VariableLink.ImageSize = 60;
            this.VariableLink.Location = new System.Drawing.Point(0, 0);
            this.VariableLink.Name = "VariableLink";
            this.VariableLink.Size = new System.Drawing.Size(62, 61);
            this.VariableLink.TabIndex = 1;
            this.VariableLink.UseSelectable = true;
            this.VariableLink.Click += new System.EventHandler(this.variableToolStripMenuItem_Click);
            // 
            // GlobalScopePanel
            // 
            this.GlobalScopePanel.AutoScroll = true;
            this.GlobalScopePanel.BackColor = System.Drawing.Color.CadetBlue;
            this.GlobalScopePanel.ContextMenuStrip = this.VBlockMenu;
            this.GlobalScopePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalScopePanel.Location = new System.Drawing.Point(0, 0);
            this.GlobalScopePanel.Name = "GlobalScopePanel";
            this.GlobalScopePanel.Size = new System.Drawing.Size(514, 415);
            this.GlobalScopePanel.TabIndex = 2;
            // 
            // GlobalScopeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.GlobalScopePanel);
            this.Controls.Add(this.panel1);
            this.Name = "GlobalScopeControl";
            this.Size = new System.Drawing.Size(576, 415);
            this.VBlockMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroContextMenu VBlockMenu;
        private System.Windows.Forms.ToolStripMenuItem variableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel GlobalScopePanel;
        private MetroFramework.Controls.MetroLink VariableLink;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink FunctionLink;
    }
}
