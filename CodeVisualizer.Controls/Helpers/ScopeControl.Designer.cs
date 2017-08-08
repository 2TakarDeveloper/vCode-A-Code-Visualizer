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
            this.AssignmentButton = new System.Windows.Forms.Button();
            this.WhileButton = new System.Windows.Forms.Button();
            this.ifButton = new System.Windows.Forms.Button();
            this.variableButton = new System.Windows.Forms.Button();
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
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
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
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.AssignmentButton);
            this.panel1.Controls.Add(this.WhileButton);
            this.panel1.Controls.Add(this.ifButton);
            this.panel1.Controls.Add(this.variableButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(405, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 336);
            this.panel1.TabIndex = 4;
            // 
            // AssignmentButton
            // 
            this.AssignmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AssignmentButton.Location = new System.Drawing.Point(0, 69);
            this.AssignmentButton.Name = "AssignmentButton";
            this.AssignmentButton.Padding = new System.Windows.Forms.Padding(2);
            this.AssignmentButton.Size = new System.Drawing.Size(80, 26);
            this.AssignmentButton.TabIndex = 3;
            this.AssignmentButton.Text = "Assignment";
            this.AssignmentButton.UseVisualStyleBackColor = true;
            this.AssignmentButton.Click += new System.EventHandler(this.assignmentToolStripMenuItem_Click);
            // 
            // WhileButton
            // 
            this.WhileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.WhileButton.Location = new System.Drawing.Point(0, 46);
            this.WhileButton.Name = "WhileButton";
            this.WhileButton.Size = new System.Drawing.Size(80, 23);
            this.WhileButton.TabIndex = 2;
            this.WhileButton.Text = "While";
            this.WhileButton.UseVisualStyleBackColor = true;
            this.WhileButton.Click += new System.EventHandler(this.whileToolStripMenuItem1_Click);
            // 
            // ifButton
            // 
            this.ifButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ifButton.Location = new System.Drawing.Point(0, 23);
            this.ifButton.Name = "ifButton";
            this.ifButton.Size = new System.Drawing.Size(80, 23);
            this.ifButton.TabIndex = 1;
            this.ifButton.Text = "if";
            this.ifButton.UseVisualStyleBackColor = true;
            this.ifButton.Click += new System.EventHandler(this.ifToolStripMenuItem1_Click);
            // 
            // variableButton
            // 
            this.variableButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.variableButton.Location = new System.Drawing.Point(0, 0);
            this.variableButton.Name = "variableButton";
            this.variableButton.Size = new System.Drawing.Size(80, 23);
            this.variableButton.TabIndex = 0;
            this.variableButton.Text = "Variable";
            this.variableButton.UseVisualStyleBackColor = true;
            this.variableButton.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
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
            this.ScopePanel.Size = new System.Drawing.Size(405, 336);
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
        private System.Windows.Forms.Button AssignmentButton;
        private System.Windows.Forms.Button WhileButton;
        private System.Windows.Forms.Button ifButton;
        private System.Windows.Forms.Button variableButton;
        public System.Windows.Forms.FlowLayoutPanel ScopePanel;
    }
}
