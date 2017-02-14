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
            this.numericUpDownRow = new System.Windows.Forms.NumericUpDown();
            this.columnlable = new MetroFramework.Controls.MetroLabel();
            this.staticCheck = new MetroFramework.Controls.MetroCheckBox();
            this.variableType = new MetroFramework.Controls.MetroComboBox();
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CancleButton = new MetroFramework.Controls.MetroButton();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.variableNameTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownRow
            // 
            this.numericUpDownRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownRow.Location = new System.Drawing.Point(155, 199);
            this.numericUpDownRow.Name = "numericUpDownRow";
            this.numericUpDownRow.Size = new System.Drawing.Size(317, 20);
            this.numericUpDownRow.TabIndex = 16;
            this.numericUpDownRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRow.Visible = false;
            // 
            // columnlable
            // 
            this.columnlable.AutoSize = true;
            this.columnlable.Location = new System.Drawing.Point(3, 220);
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
            this.staticCheck.Location = new System.Drawing.Point(3, 113);
            this.staticCheck.Name = "staticCheck";
            this.staticCheck.Size = new System.Drawing.Size(469, 19);
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
            this.variableType.Location = new System.Drawing.Point(155, 49);
            this.variableType.Name = "variableType";
            this.variableType.Size = new System.Drawing.Size(317, 29);
            this.variableType.TabIndex = 5;
            this.variableType.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 18);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "VType";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(155, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 18);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Variable";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 18);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 46);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Type";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 77);
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
            this.variableAccessModifier.Location = new System.Drawing.Point(155, 80);
            this.variableAccessModifier.Name = "variableAccessModifier";
            this.variableAccessModifier.Size = new System.Drawing.Size(317, 29);
            this.variableAccessModifier.TabIndex = 7;
            this.variableAccessModifier.UseSelectable = true;
            // 
            // isArrayCheck
            // 
            this.isArrayCheck.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.isArrayCheck, 2);
            this.isArrayCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isArrayCheck.Location = new System.Drawing.Point(3, 138);
            this.isArrayCheck.Name = "isArrayCheck";
            this.isArrayCheck.Size = new System.Drawing.Size(469, 20);
            this.isArrayCheck.TabIndex = 11;
            this.isArrayCheck.Text = "isArray";
            this.isArrayCheck.UseSelectable = true;
            this.isArrayCheck.CheckedChanged += new System.EventHandler(this.isArrayCheck_CheckedChanged);
            // 
            // arrytypelable
            // 
            this.arrytypelable.AutoSize = true;
            this.arrytypelable.Location = new System.Drawing.Point(3, 161);
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
            this.ArrayType.Location = new System.Drawing.Point(155, 164);
            this.ArrayType.Name = "ArrayType";
            this.ArrayType.Size = new System.Drawing.Size(317, 29);
            this.ArrayType.TabIndex = 13;
            this.ArrayType.UseSelectable = true;
            this.ArrayType.Visible = false;
            this.ArrayType.SelectedIndexChanged += new System.EventHandler(this.ArrayType_SelectedIndexChanged);
            // 
            // rowsLable
            // 
            this.rowsLable.AutoSize = true;
            this.rowsLable.Location = new System.Drawing.Point(3, 196);
            this.rowsLable.Name = "rowsLable";
            this.rowsLable.Size = new System.Drawing.Size(39, 19);
            this.rowsLable.TabIndex = 14;
            this.rowsLable.Text = "Rows";
            this.rowsLable.Visible = false;
            // 
            // numericUpDownColumn
            // 
            this.numericUpDownColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownColumn.Location = new System.Drawing.Point(155, 223);
            this.numericUpDownColumn.Name = "numericUpDownColumn";
            this.numericUpDownColumn.Size = new System.Drawing.Size(317, 20);
            this.numericUpDownColumn.TabIndex = 17;
            this.numericUpDownColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.tableLayoutPanel1.Controls.Add(this.variableType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.staticCheck, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.columnlable, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownRow, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.ValueBox, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.variableNameTextBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.899285F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.201058F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.730159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.613757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.878307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.259259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.349206F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.613757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.18518F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.metroPanel1, 2);
            this.metroPanel1.Controls.Add(this.CancleButton);
            this.metroPanel1.Controls.Add(this.SaveButton);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 381);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(469, 42);
            this.metroPanel1.TabIndex = 19;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // CancleButton
            // 
            this.CancleButton.Location = new System.Drawing.Point(297, 11);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(160, 23);
            this.CancleButton.TabIndex = 3;
            this.CancleButton.Text = "Cancle";
            this.CancleButton.UseSelectable = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(131, 11);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(160, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseSelectable = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ValueBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ValueBox, 2);
            this.ValueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueBox.Location = new System.Drawing.Point(3, 248);
            this.ValueBox.Multiline = true;
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(469, 127);
            this.ValueBox.TabIndex = 20;
            // 
            // variableNameTextBox
            // 
            // 
            // 
            // 
            this.variableNameTextBox.CustomButton.Image = null;
            this.variableNameTextBox.CustomButton.Location = new System.Drawing.Point(297, 2);
            this.variableNameTextBox.CustomButton.Name = "";
            this.variableNameTextBox.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.variableNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.variableNameTextBox.CustomButton.TabIndex = 1;
            this.variableNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.variableNameTextBox.CustomButton.UseSelectable = true;
            this.variableNameTextBox.CustomButton.Visible = false;
            this.variableNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableNameTextBox.Lines = new string[0];
            this.variableNameTextBox.Location = new System.Drawing.Point(155, 21);
            this.variableNameTextBox.MaxLength = 32767;
            this.variableNameTextBox.Name = "variableNameTextBox";
            this.variableNameTextBox.PasswordChar = '\0';
            this.variableNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.variableNameTextBox.SelectedText = "";
            this.variableNameTextBox.SelectionLength = 0;
            this.variableNameTextBox.SelectionStart = 0;
            this.variableNameTextBox.ShortcutsEnabled = true;
            this.variableNameTextBox.Size = new System.Drawing.Size(317, 22);
            this.variableNameTextBox.TabIndex = 21;
            this.variableNameTextBox.UseSelectable = true;
            this.variableNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.variableNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // VariableProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VariableProperties";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private MetroFramework.Controls.MetroComboBox variableType;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton CancleButton;
        private MetroFramework.Controls.MetroButton SaveButton;
        private System.Windows.Forms.TextBox ValueBox;
        private MetroFramework.Controls.MetroTextBox variableNameTextBox;
    }
}