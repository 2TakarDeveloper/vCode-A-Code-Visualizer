namespace CodeVisualizer.Controls.Instructions
{
    partial class OneAddressInstruction
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
            this.Menu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel = new MetroFramework.Controls.MetroPanel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionToolStripMenuItem,
            this.variableToolStripMenuItem,
            this.constantToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(123, 70);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // variableToolStripMenuItem
            // 
            this.variableToolStripMenuItem.Name = "variableToolStripMenuItem";
            this.variableToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.variableToolStripMenuItem.Text = "Variable";
            // 
            // constantToolStripMenuItem
            // 
            this.constantToolStripMenuItem.Name = "constantToolStripMenuItem";
            this.constantToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.constantToolStripMenuItem.Text = "Constant";
            // 
            // Panel
            // 
            this.Panel.ContextMenuStrip = this.Menu;
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.HorizontalScrollbarBarColor = true;
            this.Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel.HorizontalScrollbarSize = 10;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(582, 174);
            this.Panel.TabIndex = 1;
            this.Panel.VerticalScrollbarBarColor = true;
            this.Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Panel.VerticalScrollbarSize = 10;
            // 
            // OneAddressInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Name = "OneAddressInstruction";
            this.Size = new System.Drawing.Size(582, 174);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroContextMenu Menu;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem constantToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel Panel;
    }
}
