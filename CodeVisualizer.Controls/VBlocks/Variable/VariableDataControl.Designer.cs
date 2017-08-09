namespace CodeVisualizer.Controls.VBlocks.Variable
{
    partial class VariableDataControl
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
            this.columnIndex = new MetroFramework.Controls.MetroComboBox();
            this.rowIndex = new MetroFramework.Controls.MetroComboBox();
            this.VariableName = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.columnIndex);
            this.metroPanel1.Controls.Add(this.rowIndex);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(254, 38);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // columnIndex
            // 
            this.columnIndex.FormattingEnabled = true;
            this.columnIndex.ItemHeight = 23;
            this.columnIndex.Location = new System.Drawing.Point(127, 3);
            this.columnIndex.Name = "columnIndex";
            this.columnIndex.Size = new System.Drawing.Size(121, 29);
            this.columnIndex.TabIndex = 3;
            this.columnIndex.UseSelectable = true;
            this.columnIndex.Visible = false;
            this.columnIndex.SelectedIndexChanged += new System.EventHandler(this.columnIndex_SelectedIndexChanged);
            // 
            // rowIndex
            // 
            this.rowIndex.FormattingEnabled = true;
            this.rowIndex.ItemHeight = 23;
            this.rowIndex.Location = new System.Drawing.Point(3, 3);
            this.rowIndex.Name = "rowIndex";
            this.rowIndex.Size = new System.Drawing.Size(121, 29);
            this.rowIndex.TabIndex = 2;
            this.rowIndex.UseSelectable = true;
            this.rowIndex.Visible = false;
            this.rowIndex.SelectedIndexChanged += new System.EventHandler(this.rowIndex_SelectedIndexChanged);
            // 
            // VariableName
            // 
            this.VariableName.AutoSize = true;
            this.VariableName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.VariableName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.VariableName.Location = new System.Drawing.Point(70, 0);
            this.VariableName.Name = "VariableName";
            this.VariableName.Size = new System.Drawing.Size(118, 25);
            this.VariableName.TabIndex = 2;
            this.VariableName.Text = "metroLabel1";
            this.VariableName.WrapToLine = true;
            // 
            // metroLink1
            // 
            this.metroLink1.Image = global::CodeVisualizer.Controls.Properties.Resources._1484856362_Close_Box_Red;
            this.metroLink1.Location = new System.Drawing.Point(228, -2);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(20, 23);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // VariableDataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.VariableName);
            this.Controls.Add(this.metroPanel1);
            this.Name = "VariableDataControl";
            this.Size = new System.Drawing.Size(254, 66);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected MetroFramework.Controls.MetroPanel metroPanel1;
        protected MetroFramework.Controls.MetroComboBox columnIndex;
        protected MetroFramework.Controls.MetroComboBox rowIndex;
        private MetroFramework.Controls.MetroLabel VariableName;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}
