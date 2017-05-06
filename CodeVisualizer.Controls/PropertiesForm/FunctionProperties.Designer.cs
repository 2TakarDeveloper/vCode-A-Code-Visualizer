namespace CodeVisualizer.Controls.PropertiesForm
{
    partial class FunctionProperties
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FunctionAccessModifier = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ReturnType = new MetroFramework.Controls.MetroComboBox();
            this.staticCheck = new MetroFramework.Controls.MetroCheckBox();
            this.FunctionNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.HasParameter = new MetroFramework.Controls.MetroCheckBox();
            this.ParameterFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.AddNewParameter = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CancleButton = new MetroFramework.Controls.MetroButton();
            this.SubmitButton = new MetroFramework.Controls.MetroButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tableLayoutPanel1.Controls.Add(this.FunctionAccessModifier, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReturnType, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.staticCheck, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.FunctionNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.HasParameter, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ParameterFlow, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.AddNewParameter, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 1, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 351);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FunctionAccessModifier
            // 
            this.FunctionAccessModifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctionAccessModifier.FormattingEnabled = true;
            this.FunctionAccessModifier.ItemHeight = 23;
            this.FunctionAccessModifier.Items.AddRange(new object[] {
            "public",
            "private",
            "protected"});
            this.FunctionAccessModifier.Location = new System.Drawing.Point(161, 89);
            this.FunctionAccessModifier.Name = "FunctionAccessModifier";
            this.FunctionAccessModifier.Size = new System.Drawing.Size(312, 29);
            this.FunctionAccessModifier.TabIndex = 7;
            this.FunctionAccessModifier.UseSelectable = true;
            this.FunctionAccessModifier.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 86);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(101, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Access Modifier";
            this.metroLabel5.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 51);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Return Type";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(161, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Function";
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
            // ReturnType
            // 
            this.ReturnType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReturnType.FormattingEnabled = true;
            this.ReturnType.ItemHeight = 23;
            this.ReturnType.Items.AddRange(new object[] {
            "int",
            "float",
            "double",
            "string",
            "bool",
            "void"});
            this.ReturnType.Location = new System.Drawing.Point(161, 54);
            this.ReturnType.Name = "ReturnType";
            this.ReturnType.Size = new System.Drawing.Size(312, 29);
            this.ReturnType.TabIndex = 5;
            this.ReturnType.UseSelectable = true;
            // 
            // staticCheck
            // 
            this.staticCheck.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.staticCheck, 2);
            this.staticCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staticCheck.Location = new System.Drawing.Point(3, 124);
            this.staticCheck.Name = "staticCheck";
            this.staticCheck.Size = new System.Drawing.Size(470, 15);
            this.staticCheck.TabIndex = 10;
            this.staticCheck.Text = "isStatic";
            this.staticCheck.UseSelectable = true;
            this.staticCheck.Visible = false;
            // 
            // FunctionNameTextBox
            // 
            // 
            // 
            // 
            this.FunctionNameTextBox.CustomButton.Image = null;
            this.FunctionNameTextBox.CustomButton.Location = new System.Drawing.Point(288, 2);
            this.FunctionNameTextBox.CustomButton.Name = "";
            this.FunctionNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FunctionNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FunctionNameTextBox.CustomButton.TabIndex = 1;
            this.FunctionNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FunctionNameTextBox.CustomButton.UseSelectable = true;
            this.FunctionNameTextBox.CustomButton.Visible = false;
            this.FunctionNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctionNameTextBox.Lines = new string[0];
            this.FunctionNameTextBox.Location = new System.Drawing.Point(161, 22);
            this.FunctionNameTextBox.MaxLength = 32767;
            this.FunctionNameTextBox.Name = "FunctionNameTextBox";
            this.FunctionNameTextBox.PasswordChar = '\0';
            this.FunctionNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FunctionNameTextBox.SelectedText = "";
            this.FunctionNameTextBox.SelectionLength = 0;
            this.FunctionNameTextBox.SelectionStart = 0;
            this.FunctionNameTextBox.ShortcutsEnabled = true;
            this.FunctionNameTextBox.Size = new System.Drawing.Size(312, 26);
            this.FunctionNameTextBox.TabIndex = 21;
            this.metroToolTip1.SetToolTip(this.FunctionNameTextBox, "Function name must start with letters(A-Z/a-z) or _  also can\'t contain\r\nany othe" +
        "r special character, But it can contain numbers(0-9).");
            this.FunctionNameTextBox.UseSelectable = true;
            this.FunctionNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FunctionNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.FunctionNameTextBox.TextChanged += new System.EventHandler(this.FunctionNameTextBox_TextChanged);
            // 
            // HasParameter
            // 
            this.HasParameter.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.HasParameter, 2);
            this.HasParameter.Location = new System.Drawing.Point(3, 145);
            this.HasParameter.Name = "HasParameter";
            this.HasParameter.Size = new System.Drawing.Size(97, 15);
            this.HasParameter.TabIndex = 22;
            this.HasParameter.Text = "HasParameter";
            this.HasParameter.UseSelectable = true;
            this.HasParameter.CheckedChanged += new System.EventHandler(this.HasParameter_CheckedChanged);
            // 
            // ParameterFlow
            // 
            this.ParameterFlow.AutoScroll = true;
            this.ParameterFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParameterFlow.Location = new System.Drawing.Point(161, 166);
            this.ParameterFlow.Name = "ParameterFlow";
            this.ParameterFlow.Size = new System.Drawing.Size(312, 125);
            this.ParameterFlow.TabIndex = 24;
            // 
            // AddNewParameter
            // 
            this.AddNewParameter.Location = new System.Drawing.Point(3, 166);
            this.AddNewParameter.Name = "AddNewParameter";
            this.AddNewParameter.Size = new System.Drawing.Size(152, 30);
            this.AddNewParameter.TabIndex = 25;
            this.AddNewParameter.Text = "AddNewParameter";
            this.AddNewParameter.UseSelectable = true;
            this.AddNewParameter.Visible = false;
            this.AddNewParameter.Click += new System.EventHandler(this.AddNewParameter_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.CancleButton);
            this.metroPanel1.Controls.Add(this.SubmitButton);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(161, 297);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(312, 51);
            this.metroPanel1.TabIndex = 26;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // CancleButton
            // 
            this.CancleButton.Location = new System.Drawing.Point(184, 5);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(125, 43);
            this.CancleButton.TabIndex = 3;
            this.CancleButton.Text = "Cancle";
            this.CancleButton.UseSelectable = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(53, 5);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(125, 43);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseSelectable = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // FunctionProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 431);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FunctionProperties";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroComboBox FunctionAccessModifier;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox ReturnType;
        private MetroFramework.Controls.MetroCheckBox staticCheck;
        private MetroFramework.Controls.MetroTextBox FunctionNameTextBox;
        private MetroFramework.Controls.MetroCheckBox HasParameter;
        private System.Windows.Forms.FlowLayoutPanel ParameterFlow;
        private MetroFramework.Controls.MetroButton AddNewParameter;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton CancleButton;
        private MetroFramework.Controls.MetroButton SubmitButton;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}