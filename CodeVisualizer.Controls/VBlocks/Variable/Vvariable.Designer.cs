namespace CodeVisualizer.Controls.VBlocks.Variable
{
    partial class Vvariable
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.numericUpColumn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRow = new System.Windows.Forms.NumericUpDown();
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(221, 28);
            this.Header.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(154, 1);
            this.settingsButton.Size = new System.Drawing.Size(33, 24);
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // NameLable
            // 
            this.NameLable.Size = new System.Drawing.Size(104, 19);
            this.NameLable.Text = "VariableName";
            this.NameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisposeButton
            // 
            this.DisposeButton.Location = new System.Drawing.Point(187, 1);
            this.DisposeButton.Size = new System.Drawing.Size(31, 24);
            // 
            // body
            // 
            this.body.Controls.Add(this.metroPanel1);
            this.body.Location = new System.Drawing.Point(10, 10);
            this.body.Size = new System.Drawing.Size(223, 114);
            this.body.Controls.SetChildIndex(this.Header, 0);
            this.body.Controls.SetChildIndex(this.metroPanel1, 0);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ValueBox);
            this.metroPanel1.Controls.Add(this.numericUpColumn);
            this.metroPanel1.Controls.Add(this.numericUpDownRow);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(221, 84);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ValueBox
            // 
            this.ValueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueBox.Location = new System.Drawing.Point(0, 40);
            this.ValueBox.Multiline = true;
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(221, 44);
            this.ValueBox.TabIndex = 6;
            this.ValueBox.TextChanged += new System.EventHandler(this.ValueBox_TextChanged);
            // 
            // numericUpColumn
            // 
            this.numericUpColumn.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpColumn.Location = new System.Drawing.Point(0, 20);
            this.numericUpColumn.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpColumn.Name = "numericUpColumn";
            this.numericUpColumn.Size = new System.Drawing.Size(221, 20);
            this.numericUpColumn.TabIndex = 5;
            this.numericUpColumn.ValueChanged += new System.EventHandler(this.numericUpColumn_ValueChanged);
            // 
            // numericUpDownRow
            // 
            this.numericUpDownRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownRow.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownRow.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownRow.Name = "numericUpDownRow";
            this.numericUpDownRow.Size = new System.Drawing.Size(221, 20);
            this.numericUpDownRow.TabIndex = 4;
            this.numericUpDownRow.ValueChanged += new System.EventHandler(this.numericUpDownRow_ValueChanged);
            // 
            // Vvariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Vvariable";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(243, 134);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.NumericUpDown numericUpColumn;
        private System.Windows.Forms.NumericUpDown numericUpDownRow;
        private System.Windows.Forms.TextBox ValueBox;
    }
}
