using CodeVisualizer.Controls.Helpers;

namespace CodeVisualizer.Forms
{
    partial class DashBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualToCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToVisualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.midPanel = new System.Windows.Forms.Panel();
            this.SplitPanel1 = new System.Windows.Forms.SplitContainer();
            this.CodeEditor = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.globalScopeControl = new CodeVisualizer.Controls.Helpers.GlobalScopeControl();
            this.header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.botPanel = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.midPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPanel1)).BeginInit();
            this.SplitPanel1.Panel1.SuspendLayout();
            this.SplitPanel1.Panel2.SuspendLayout();
            this.SplitPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.header.SuspendLayout();
            this.botPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.topPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.midPanel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.botPanel, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel.Location = new System.Drawing.Point(20, 30);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.71171F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.75676F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.306306F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(723, 493);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.panel3);
            this.topPanel.Controls.Add(this.menuStrip);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(717, 51);
            this.topPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 27);
            this.panel3.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.compileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(717, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualToCodeToolStripMenuItem,
            this.codeToVisualToolStripMenuItem});
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.compileToolStripMenuItem.Text = "Convert";
            // 
            // visualToCodeToolStripMenuItem
            // 
            this.visualToCodeToolStripMenuItem.Name = "visualToCodeToolStripMenuItem";
            this.visualToCodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visualToCodeToolStripMenuItem.Text = "Visual To Code";
            this.visualToCodeToolStripMenuItem.Click += new System.EventHandler(this.visualToCodeToolStripMenuItem_Click);
            // 
            // codeToVisualToolStripMenuItem
            // 
            this.codeToVisualToolStripMenuItem.Name = "codeToVisualToolStripMenuItem";
            this.codeToVisualToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.codeToVisualToolStripMenuItem.Text = "Code To Visual";
            this.codeToVisualToolStripMenuItem.Click += new System.EventHandler(this.codeToVisualToolStripMenuItem_Click);
            // 
            // midPanel
            // 
            this.midPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.midPanel.Controls.Add(this.SplitPanel1);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(3, 60);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(717, 397);
            this.midPanel.TabIndex = 1;
            // 
            // SplitPanel1
            // 
            this.SplitPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitPanel1.Location = new System.Drawing.Point(0, 0);
            this.SplitPanel1.Name = "SplitPanel1";
            // 
            // SplitPanel1.Panel1
            // 
            this.SplitPanel1.Panel1.AccessibleName = "codeEditor";
            this.SplitPanel1.Panel1.Controls.Add(this.CodeEditor);
            this.SplitPanel1.Panel1.Controls.Add(this.panel1);
            // 
            // SplitPanel1.Panel2
            // 
            this.SplitPanel1.Panel2.Controls.Add(this.globalScopeControl);
            this.SplitPanel1.Panel2.Controls.Add(this.header);
            this.SplitPanel1.Size = new System.Drawing.Size(713, 393);
            this.SplitPanel1.SplitterDistance = 244;
            this.SplitPanel1.TabIndex = 0;
            // 
            // CodeEditor
            // 
            this.CodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeEditor.Location = new System.Drawing.Point(0, 22);
            this.CodeEditor.Name = "CodeEditor";
            this.CodeEditor.Size = new System.Drawing.Size(244, 371);
            this.CodeEditor.TabIndex = 3;
            this.CodeEditor.Text = "";
            this.CodeEditor.TextChanged += new System.EventHandler(this.CodeEditor_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 22);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Editor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // globalScopeControl
            // 
            this.globalScopeControl.BackColor = System.Drawing.Color.DarkCyan;
            this.globalScopeControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.globalScopeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.globalScopeControl.GlobalScope = null;
            this.globalScopeControl.Location = new System.Drawing.Point(0, 22);
            this.globalScopeControl.Name = "globalScopeControl";
            this.globalScopeControl.Size = new System.Drawing.Size(465, 371);
            this.globalScopeControl.TabIndex = 6;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Thistle;
            this.header.Controls.Add(this.label2);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(465, 22);
            this.header.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code Visualizer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botPanel
            // 
            this.botPanel.Controls.Add(this.metroPanel1);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botPanel.Location = new System.Drawing.Point(3, 463);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(717, 27);
            this.botPanel.TabIndex = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(717, 27);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 543);
            this.Controls.Add(this.tableLayoutPanel);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.Color.Teal;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "DashBoard";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.tableLayoutPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.midPanel.ResumeLayout(false);
            this.SplitPanel1.Panel1.ResumeLayout(false);
            this.SplitPanel1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitPanel1)).EndInit();
            this.SplitPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.botPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.SplitContainer SplitPanel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox CodeEditor;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualToCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToVisualToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label2;
        private GlobalScopeControl globalScopeControl;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}

