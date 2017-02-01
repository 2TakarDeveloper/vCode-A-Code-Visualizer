namespace CodeVisualizer.Controls.PropertiesForm
{
    partial class VariableProperties
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numericUpDownRow = new System.Windows.Forms.NumericUpDown();
            this.columnlable = new MetroFramework.Controls.MetroLabel();
            this.staticCheck = new MetroFramework.Controls.MetroCheckBox();
            this.variableType = new MetroFramework.Controls.MetroComboBox();
            this.variableName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.variableAccessModifier = new MetroFramework.Controls.MetroComboBox();
            this.isArrayCheck = new MetroFramework.Controls.MetroCheckBox();
            this.arrytypelable = new MetroFramework.Controls.MetroLabel();
            this.ArrayType = new MetroFramework.Controls.MetroComboBox();
            this.rowsLable = new MetroFramework.Controls.MetroLabel();
            this.numericUpDownColumn = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownRow
            // 
            this.numericUpDownRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownRow.Location = new System.Drawing.Point(168, 236);
            this.numericUpDownRow.Name = "numericUpDownRow";
            this.numericUpDownRow.Size = new System.Drawing.Size(344, 20);
            this.numericUpDownRow.TabIndex = 16;
            this.numericUpDownRow.Visible = false;
            // 
            // columnlable
            // 
            this.columnlable.AutoSize = true;
            this.columnlable.Location = new System.Drawing.Point(3, 257);
            this.columnlable.Name = "columnlable";
            this.columnlable.Size = new System.Drawing.Size(60, 19);
            this.columnlable.TabIndex = 15;
            this.columnlable.Text = "Columns";
            this.columnlable.Visible = false;
            // 
            // staticCheck
            // 
            this.staticCheck.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.staticCheck, 2);
            this.staticCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staticCheck.Location = new System.Drawing.Point(3, 132);
            this.staticCheck.Name = "staticCheck";
            this.staticCheck.Size = new System.Drawing.Size(509, 28);
            this.staticCheck.TabIndex = 10;
            this.staticCheck.Text = "isStatic";
            this.staticCheck.UseSelectable = true;
            // 
            // variableType
            // 
            this.variableType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableType.FormattingEnabled = true;
            this.variableType.ItemHeight = 23;
            this.variableType.Items.AddRange(new object[] {
            "int",
            "float",
            "double",
            "string",
            "bool"});
            this.variableType.Location = new System.Drawing.Point(168, 53);
            this.variableType.Name = "variableType";
            this.variableType.Size = new System.Drawing.Size(344, 29);
            this.variableType.TabIndex = 5;
            this.variableType.UseSelectable = true;
            // 
            // variableName
            // 
            // 
            // 
            // 
            this.variableName.CustomButton.Image = null;
            this.variableName.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.variableName.CustomButton.Name = "";
            this.variableName.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.variableName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.variableName.CustomButton.TabIndex = 1;
            this.variableName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.variableName.CustomButton.UseSelectable = true;
            this.variableName.CustomButton.Visible = false;
            this.variableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableName.Lines = new string[0];
            this.variableName.Location = new System.Drawing.Point(168, 25);
            this.variableName.MaxLength = 32767;
            this.variableName.Name = "variableName";
            this.variableName.PasswordChar = '\0';
            this.variableName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.variableName.SelectedText = "";
            this.variableName.SelectionLength = 0;
            this.variableName.SelectionStart = 0;
            this.variableName.ShortcutsEnabled = true;
            this.variableName.Size = new System.Drawing.Size(344, 22);
            this.variableName.TabIndex = 3;
            this.variableName.UseSelectable = true;
            this.variableName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.variableName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "VType";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(168, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Variable";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 22);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 50);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Type";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 89);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(101, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Access Modifier";
            // 
            // variableAccessModifier
            // 
            this.variableAccessModifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableAccessModifier.FormattingEnabled = true;
            this.variableAccessModifier.ItemHeight = 23;
            this.variableAccessModifier.Items.AddRange(new object[] {
            "public",
            "private",
            "protected"});
            this.variableAccessModifier.Location = new System.Drawing.Point(168, 92);
            this.variableAccessModifier.Name = "variableAccessModifier";
            this.variableAccessModifier.Size = new System.Drawing.Size(344, 29);
            this.variableAccessModifier.TabIndex = 7;
            this.variableAccessModifier.UseSelectable = true;
            // 
            // isArrayCheck
            // 
            this.isArrayCheck.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.isArrayCheck, 2);
            this.isArrayCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isArrayCheck.Location = new System.Drawing.Point(3, 166);
            this.isArrayCheck.Name = "isArrayCheck";
            this.isArrayCheck.Size = new System.Drawing.Size(509, 28);
            this.isArrayCheck.TabIndex = 11;
            this.isArrayCheck.Text = "isArray";
            this.isArrayCheck.UseSelectable = true;
            this.isArrayCheck.CheckedChanged += new System.EventHandler(this.isArrayCheck_CheckedChanged);
            // 
            // arrytypelable
            // 
            this.arrytypelable.AutoSize = true;
            this.arrytypelable.Location = new System.Drawing.Point(3, 197);
            this.arrytypelable.Name = "arrytypelable";
            this.arrytypelable.Size = new System.Drawing.Size(68, 19);
            this.arrytypelable.TabIndex = 12;
            this.arrytypelable.Text = "ArrayType";
            this.arrytypelable.Visible = false;
            // 
            // ArrayType
            // 
            this.ArrayType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArrayType.FormattingEnabled = true;
            this.ArrayType.ItemHeight = 23;
            this.ArrayType.Items.AddRange(new object[] {
            "1D",
            "2D"});
            this.ArrayType.Location = new System.Drawing.Point(168, 200);
            this.ArrayType.Name = "ArrayType";
            this.ArrayType.Size = new System.Drawing.Size(344, 29);
            this.ArrayType.TabIndex = 13;
            this.ArrayType.UseSelectable = true;
            this.ArrayType.Visible = false;
            this.ArrayType.SelectedIndexChanged += new System.EventHandler(this.ArrayType_SelectedIndexChanged);
            // 
            // rowsLable
            // 
            this.rowsLable.AutoSize = true;
            this.rowsLable.Location = new System.Drawing.Point(3, 233);
            this.rowsLable.Name = "rowsLable";
            this.rowsLable.Size = new System.Drawing.Size(39, 19);
            this.rowsLable.TabIndex = 14;
            this.rowsLable.Text = "Rows";
            this.rowsLable.Visible = false;
            // 
            // numericUpDownColumn
            // 
            this.numericUpDownColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownColumn.Location = new System.Drawing.Point(168, 260);
            this.numericUpDownColumn.Name = "numericUpDownColumn";
            this.numericUpDownColumn.Size = new System.Drawing.Size(344, 20);
            this.numericUpDownColumn.TabIndex = 17;
            this.numericUpDownColumn.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.16374F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.83626F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownColumn, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.rowsLable, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ArrayType, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.arrytypelable, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.isArrayCheck, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.variableAccessModifier, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.variableName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.variableType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.staticCheck, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.columnlable, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownRow, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.metroGrid1, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.899285F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.132775F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.532557F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.7992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.471257F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.471257F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.910743F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.273829F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.372543F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.13655F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.metroGrid1, 2);
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 289);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(509, 165);
            this.metroGrid1.TabIndex = 18;
            // 
            // metroPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.metroPanel1, 2);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 460);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(509, 43);
            this.metroPanel1.TabIndex = 19;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(174, 11);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(160, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Save";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(340, 11);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(160, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Cancle";
            this.metroButton2.UseSelectable = true;
            // 
            // VariableProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VariableProperties";
            this.Text = "VariableProperties";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownRow;
        private MetroFramework.Controls.MetroLabel columnlable;
        private MetroFramework.Controls.MetroCheckBox staticCheck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDownColumn;
        private MetroFramework.Controls.MetroLabel rowsLable;
        private MetroFramework.Controls.MetroComboBox ArrayType;
        private MetroFramework.Controls.MetroLabel arrytypelable;
        private MetroFramework.Controls.MetroCheckBox isArrayCheck;
        private MetroFramework.Controls.MetroComboBox variableAccessModifier;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox variableName;
        private MetroFramework.Controls.MetroComboBox variableType;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}