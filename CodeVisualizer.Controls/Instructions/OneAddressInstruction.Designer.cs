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
            this.VariableButton = new System.Windows.Forms.Button();
            this.FunctionButton = new System.Windows.Forms.Button();
            this.ConstantButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel = new MetroFramework.Controls.MetroPanel();
            this.Menu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.functionToolStripMenuItem.Text = "Variable";
            this.functionToolStripMenuItem.Click += new System.EventHandler(this.variableToolStripMenuItem_Click);
            // 
            // variableToolStripMenuItem
            // 
            this.variableToolStripMenuItem.Name = "variableToolStripMenuItem";
            this.variableToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.variableToolStripMenuItem.Text = "Function";
            this.variableToolStripMenuItem.Click += new System.EventHandler(this.functionToolStripMenuItem_Click);
            // 
            // constantToolStripMenuItem
            // 
            this.constantToolStripMenuItem.Name = "constantToolStripMenuItem";
            this.constantToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.constantToolStripMenuItem.Text = "Constant";
            this.constantToolStripMenuItem.Click += new System.EventHandler(this.constantToolStripMenuItem_Click);
            // 
            // VariableButton
            // 
            this.VariableButton.Location = new System.Drawing.Point(3, 3);
            this.VariableButton.Name = "VariableButton";
            this.VariableButton.Size = new System.Drawing.Size(75, 23);
            this.VariableButton.TabIndex = 2;
            this.VariableButton.Text = "Variable";
            this.VariableButton.UseVisualStyleBackColor = true;
            this.VariableButton.Click += new System.EventHandler(this.variableToolStripMenuItem_Click);
            // 
            // FunctionButton
            // 
            this.FunctionButton.Location = new System.Drawing.Point(84, 3);
            this.FunctionButton.Name = "FunctionButton";
            this.FunctionButton.Size = new System.Drawing.Size(75, 23);
            this.FunctionButton.TabIndex = 3;
            this.FunctionButton.Text = "Function";
            this.FunctionButton.UseVisualStyleBackColor = true;
            this.FunctionButton.Click += new System.EventHandler(this.functionToolStripMenuItem_Click);
            // 
            // ConstantButton
            // 
            this.ConstantButton.Location = new System.Drawing.Point(165, 3);
            this.ConstantButton.Name = "ConstantButton";
            this.ConstantButton.Size = new System.Drawing.Size(75, 23);
            this.ConstantButton.TabIndex = 4;
            this.ConstantButton.Text = "Constant";
            this.ConstantButton.UseVisualStyleBackColor = true;
            this.ConstantButton.Click += new System.EventHandler(this.constantToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.VariableButton);
            this.flowLayoutPanel1.Controls.Add(this.FunctionButton);
            this.flowLayoutPanel1.Controls.Add(this.ConstantButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(490, 30);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Panel
            // 
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel.ContextMenuStrip = this.Menu;
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.HorizontalScrollbarBarColor = true;
            this.Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel.HorizontalScrollbarSize = 10;
            this.Panel.Location = new System.Drawing.Point(0, 30);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(490, 165);
            this.Panel.TabIndex = 6;
            this.Panel.VerticalScrollbarBarColor = true;
            this.Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Panel.VerticalScrollbarSize = 10;
            // 
            // OneAddressInstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "OneAddressInstruction";
            this.Size = new System.Drawing.Size(490, 195);
            this.Menu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroContextMenu Menu;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem constantToolStripMenuItem;
        private System.Windows.Forms.Button VariableButton;
        private System.Windows.Forms.Button FunctionButton;
        private System.Windows.Forms.Button ConstantButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroPanel Panel;
    }
}
