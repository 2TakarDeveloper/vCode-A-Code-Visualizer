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
            this.MainFunctionButton = new System.Windows.Forms.Button();
            this.FunctionButton = new System.Windows.Forms.Button();
            this.variableButton = new System.Windows.Forms.Button();
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
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
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
            this.panel1.Controls.Add(this.MainFunctionButton);
            this.panel1.Controls.Add(this.FunctionButton);
            this.panel1.Controls.Add(this.variableButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(506, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 415);
            this.panel1.TabIndex = 1;
            // 
            // MainFunctionButton
            // 
            this.MainFunctionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainFunctionButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainFunctionButton.Location = new System.Drawing.Point(0, 46);
            this.MainFunctionButton.Name = "MainFunctionButton";
            this.MainFunctionButton.Padding = new System.Windows.Forms.Padding(2);
            this.MainFunctionButton.Size = new System.Drawing.Size(70, 23);
            this.MainFunctionButton.TabIndex = 2;
            this.MainFunctionButton.Text = "Main";
            this.MainFunctionButton.UseVisualStyleBackColor = true;
            this.MainFunctionButton.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // FunctionButton
            // 
            this.FunctionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FunctionButton.Location = new System.Drawing.Point(0, 23);
            this.FunctionButton.Name = "FunctionButton";
            this.FunctionButton.Size = new System.Drawing.Size(70, 23);
            this.FunctionButton.TabIndex = 1;
            this.FunctionButton.Text = "Function";
            this.FunctionButton.UseVisualStyleBackColor = true;
            this.FunctionButton.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // variableButton
            // 
            this.variableButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.variableButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.variableButton.Location = new System.Drawing.Point(0, 0);
            this.variableButton.Name = "variableButton";
            this.variableButton.Size = new System.Drawing.Size(70, 23);
            this.variableButton.TabIndex = 0;
            this.variableButton.Text = "Variable";
            this.variableButton.UseVisualStyleBackColor = true;
            this.variableButton.Click += new System.EventHandler(this.variableToolStripMenuItem_Click);
            // 
            // GlobalScopePanel
            // 
            this.GlobalScopePanel.AutoScroll = true;
            this.GlobalScopePanel.BackColor = System.Drawing.Color.CadetBlue;
            this.GlobalScopePanel.ContextMenuStrip = this.VBlockMenu;
            this.GlobalScopePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalScopePanel.Location = new System.Drawing.Point(0, 0);
            this.GlobalScopePanel.Name = "GlobalScopePanel";
            this.GlobalScopePanel.Size = new System.Drawing.Size(506, 415);
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
        private System.Windows.Forms.Button FunctionButton;
        private System.Windows.Forms.Button variableButton;
        private System.Windows.Forms.Button MainFunctionButton;
        public System.Windows.Forms.FlowLayoutPanel GlobalScopePanel;
    }
}
