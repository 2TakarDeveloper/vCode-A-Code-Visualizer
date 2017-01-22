using CodeVisualizer.Controls.Helpers;

namespace CodeVisualizer
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualToCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.midPanel = new System.Windows.Forms.Panel();
            this.TextPanel1 = new System.Windows.Forms.SplitContainer();
            this.CodeEditor = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.scopeControl1 = new CodeVisualizer.Controls.Helpers.ScopeControl();
            this.header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.botPanel = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.midPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextPanel1)).BeginInit();
            this.TextPanel1.Panel1.SuspendLayout();
            this.TextPanel1.Panel2.SuspendLayout();
            this.TextPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.header.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.531531F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.38739F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.306306F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(723, 444);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.menuStrip);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(717, 22);
            this.topPanel.TabIndex = 0;
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
            this.visualToCodeToolStripMenuItem});
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.compileToolStripMenuItem.Text = "Compile";
            // 
            // visualToCodeToolStripMenuItem
            // 
            this.visualToCodeToolStripMenuItem.Name = "visualToCodeToolStripMenuItem";
            this.visualToCodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visualToCodeToolStripMenuItem.Text = "Visual To Code";
            this.visualToCodeToolStripMenuItem.Click += new System.EventHandler(this.visualToCodeToolStripMenuItem_Click);
            // 
            // midPanel
            // 
            this.midPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.midPanel.Controls.Add(this.TextPanel1);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(3, 31);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(717, 381);
            this.midPanel.TabIndex = 1;
            // 
            // TextPanel1
            // 
            this.TextPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel1.Location = new System.Drawing.Point(0, 0);
            this.TextPanel1.Name = "TextPanel1";
            // 
            // TextPanel1.Panel1
            // 
            this.TextPanel1.Panel1.AccessibleName = "codeEditor";
            this.TextPanel1.Panel1.Controls.Add(this.CodeEditor);
            this.TextPanel1.Panel1.Controls.Add(this.panel1);
            // 
            // TextPanel1.Panel2
            // 
            this.TextPanel1.Panel2.Controls.Add(this.splitContainer);
            this.TextPanel1.Size = new System.Drawing.Size(713, 377);
            this.TextPanel1.SplitterDistance = 233;
            this.TextPanel1.TabIndex = 0;
            // 
            // CodeEditor
            // 
            this.CodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeEditor.Location = new System.Drawing.Point(0, 22);
            this.CodeEditor.Name = "CodeEditor";
            this.CodeEditor.Size = new System.Drawing.Size(233, 355);
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
            this.panel1.Size = new System.Drawing.Size(233, 22);
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
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AccessibleName = "visualPanel";
            this.splitContainer.Panel1.Controls.Add(this.scopeControl1);
            this.splitContainer.Panel1.Controls.Add(this.header);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AccessibleName = "PropertiesPanel";
            this.splitContainer.Panel2.Controls.Add(this.panel3);
            this.splitContainer.Panel2.Controls.Add(this.panel2);
            this.splitContainer.Size = new System.Drawing.Size(476, 377);
            this.splitContainer.SplitterDistance = 355;
            this.splitContainer.TabIndex = 0;
            // 
            // scopeControl1
            // 
            this.scopeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scopeControl1.GlobalScope = null;
            this.scopeControl1.Location = new System.Drawing.Point(0, 22);
            this.scopeControl1.Name = "scopeControl1";
            this.scopeControl1.Scope = null;
            this.scopeControl1.Size = new System.Drawing.Size(355, 355);
            this.scopeControl1.TabIndex = 2;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Thistle;
            this.header.Controls.Add(this.label2);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(355, 22);
            this.header.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 355);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 22);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Properties";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botPanel
            // 
            this.botPanel.Controls.Add(this.statusStrip);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.botPanel.Location = new System.Drawing.Point(3, 418);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(717, 23);
            this.botPanel.TabIndex = 2;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 1);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(717, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 494);
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
            this.TextPanel1.Panel1.ResumeLayout(false);
            this.TextPanel1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextPanel1)).EndInit();
            this.TextPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.botPanel.ResumeLayout(false);
            this.botPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.SplitContainer TextPanel1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox CodeEditor;
        private ScopeControl scopeControl1;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualToCodeToolStripMenuItem;
    }
}

