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
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ifToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.switchCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemDefinedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDefinedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.ifLink = new MetroFramework.Controls.MetroLink();
            this.FunctionLink = new MetroFramework.Controls.MetroLink();
            this.VariableLink = new MetroFramework.Controls.MetroLink();
            this.ScopePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ContextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variableToolStripMenuItem,
            this.iFToolStripMenuItem,
            this.functionToolStripMenuItem,
            this.whileToolStripMenuItem,
            this.assignmentToolStripMenuItem});
            this.ContextMenuStrip.Name = "ContextMenu";
            this.ContextMenuStrip.Size = new System.Drawing.Size(142, 114);
            this.ContextMenuStrip.Text = "Component";
            // 
            // variableToolStripMenuItem
            // 
            this.variableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1});
            this.variableToolStripMenuItem.Name = "variableToolStripMenuItem";
            this.variableToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.variableToolStripMenuItem.Text = "Variable";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.VariableToolStripMenuItemClick);
            // 
            // iFToolStripMenuItem
            // 
            this.iFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ifToolStripMenuItem1,
            this.switchCaseToolStripMenuItem});
            this.iFToolStripMenuItem.Name = "iFToolStripMenuItem";
            this.iFToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.iFToolStripMenuItem.Text = "Conditionals";
            // 
            // ifToolStripMenuItem1
            // 
            this.ifToolStripMenuItem1.Name = "ifToolStripMenuItem1";
            this.ifToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.ifToolStripMenuItem1.Text = "If";
            this.ifToolStripMenuItem1.Click += new System.EventHandler(this.ifToolStripMenuItem1_Click);
            // 
            // switchCaseToolStripMenuItem
            // 
            this.switchCaseToolStripMenuItem.Enabled = false;
            this.switchCaseToolStripMenuItem.Name = "switchCaseToolStripMenuItem";
            this.switchCaseToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.switchCaseToolStripMenuItem.Text = "Switch Case";
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemDefinedToolStripMenuItem,
            this.userDefinedToolStripMenuItem});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // systemDefinedToolStripMenuItem
            // 
            this.systemDefinedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.systemDefinedToolStripMenuItem.Name = "systemDefinedToolStripMenuItem";
            this.systemDefinedToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.systemDefinedToolStripMenuItem.Text = "System Defined";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click_1);
            // 
            // userDefinedToolStripMenuItem
            // 
            this.userDefinedToolStripMenuItem.Name = "userDefinedToolStripMenuItem";
            this.userDefinedToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.userDefinedToolStripMenuItem.Text = "User Defined";
            this.userDefinedToolStripMenuItem.Click += new System.EventHandler(this.userDefinedToolStripMenuItem_Click);
            // 
            // whileToolStripMenuItem
            // 
            this.whileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forToolStripMenuItem,
            this.whileToolStripMenuItem1});
            this.whileToolStripMenuItem.Name = "whileToolStripMenuItem";
            this.whileToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.whileToolStripMenuItem.Text = "Loop";
            // 
            // forToolStripMenuItem
            // 
            this.forToolStripMenuItem.Enabled = false;
            this.forToolStripMenuItem.Name = "forToolStripMenuItem";
            this.forToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.forToolStripMenuItem.Text = "For";
            // 
            // whileToolStripMenuItem1
            // 
            this.whileToolStripMenuItem1.Name = "whileToolStripMenuItem1";
            this.whileToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.whileToolStripMenuItem1.Text = "While";
            this.whileToolStripMenuItem1.Click += new System.EventHandler(this.whileToolStripMenuItem1_Click);
            // 
            // assignmentToolStripMenuItem
            // 
            this.assignmentToolStripMenuItem.Name = "assignmentToolStripMenuItem";
            this.assignmentToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.assignmentToolStripMenuItem.Text = "Assignment";
            this.assignmentToolStripMenuItem.Click += new System.EventHandler(this.assignmentToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.metroLink2);
            this.panel1.Controls.Add(this.metroLink1);
            this.panel1.Controls.Add(this.ifLink);
            this.panel1.Controls.Add(this.FunctionLink);
            this.panel1.Controls.Add(this.VariableLink);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(429, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 336);
            this.panel1.TabIndex = 4;
            // 
            // metroLink2
            // 
            this.metroLink2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroLink2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLink2.Image = global::CodeVisualizer.Controls.Properties.Resources.assignment;
            this.metroLink2.ImageSize = 60;
            this.metroLink2.Location = new System.Drawing.Point(0, 267);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(56, 63);
            this.metroLink2.TabIndex = 4;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.assignmentToolStripMenuItem_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroLink1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLink1.Image = global::CodeVisualizer.Controls.Properties.Resources.loop;
            this.metroLink1.ImageSize = 60;
            this.metroLink1.Location = new System.Drawing.Point(0, 195);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(56, 72);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.whileToolStripMenuItem1_Click);
            // 
            // ifLink
            // 
            this.ifLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.ifLink.Image = global::CodeVisualizer.Controls.Properties.Resources._if;
            this.ifLink.ImageSize = 60;
            this.ifLink.Location = new System.Drawing.Point(0, 131);
            this.ifLink.Name = "ifLink";
            this.ifLink.Size = new System.Drawing.Size(56, 64);
            this.ifLink.TabIndex = 2;
            this.ifLink.UseSelectable = true;
            this.ifLink.Click += new System.EventHandler(this.ifToolStripMenuItem1_Click);
            // 
            // FunctionLink
            // 
            this.FunctionLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionLink.Image = global::CodeVisualizer.Controls.Properties.Resources.function;
            this.FunctionLink.ImageSize = 60;
            this.FunctionLink.Location = new System.Drawing.Point(0, 65);
            this.FunctionLink.Name = "FunctionLink";
            this.FunctionLink.Size = new System.Drawing.Size(56, 66);
            this.FunctionLink.TabIndex = 1;
            this.FunctionLink.UseSelectable = true;
            this.FunctionLink.Click += new System.EventHandler(this.userDefinedToolStripMenuItem_Click);
            // 
            // VariableLink
            // 
            this.VariableLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.VariableLink.Image = global::CodeVisualizer.Controls.Properties.Resources.variable;
            this.VariableLink.ImageSize = 60;
            this.VariableLink.Location = new System.Drawing.Point(0, 0);
            this.VariableLink.Name = "VariableLink";
            this.VariableLink.Size = new System.Drawing.Size(56, 65);
            this.VariableLink.TabIndex = 0;
            this.VariableLink.UseSelectable = true;
            this.VariableLink.Click += new System.EventHandler(this.VariableToolStripMenuItemClick);
            // 
            // ScopePanel
            // 
            this.ScopePanel.AutoScroll = true;
            this.ScopePanel.BackColor = System.Drawing.Color.Tan;
            this.ScopePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScopePanel.ContextMenuStrip = this.ContextMenuStrip;
            this.ScopePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScopePanel.Location = new System.Drawing.Point(0, 0);
            this.ScopePanel.Name = "ScopePanel";
            this.ScopePanel.Size = new System.Drawing.Size(429, 336);
            this.ScopePanel.TabIndex = 5;
            // 
            // ScopeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScopePanel);
            this.Controls.Add(this.panel1);
            this.Name = "ScopeControl";
            this.Size = new System.Drawing.Size(485, 336);
            this.ContextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private new MetroFramework.Controls.MetroContextMenu ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem variableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ifToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem switchCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem systemDefinedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userDefinedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel ScopePanel;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink ifLink;
        private MetroFramework.Controls.MetroLink FunctionLink;
        private MetroFramework.Controls.MetroLink VariableLink;
        private MetroFramework.Controls.MetroLink metroLink2;
    }
}
