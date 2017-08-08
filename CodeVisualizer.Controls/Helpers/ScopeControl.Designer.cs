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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(429, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 336);
            this.panel1.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::CodeVisualizer.Controls.Properties.Resources.assignment;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 60);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.assignmentToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::CodeVisualizer.Controls.Properties.Resources.loop;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 60);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.whileToolStripMenuItem1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::CodeVisualizer.Controls.Properties.Resources._if;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 60);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ifToolStripMenuItem1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CodeVisualizer.Controls.Properties.Resources.function;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 60);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.userDefinedToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CodeVisualizer.Controls.Properties.Resources.variable;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 62);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.VariableToolStripMenuItemClick);
            // 
            // ScopePanel
            // 
            this.ScopePanel.AutoScroll = true;
            this.ScopePanel.BackColor = System.Drawing.Color.RoyalBlue;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
