namespace CodeVisualizer.Controls.Helpers
{
    partial class ConditionControl
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
            this.LeftBox = new System.Windows.Forms.ComboBox();
            this.OperatorBox = new System.Windows.Forms.ComboBox();
            this.RightBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LeftBox
            // 
            this.LeftBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LeftBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LeftBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBox.FormattingEnabled = true;
            this.LeftBox.Location = new System.Drawing.Point(0, 0);
            this.LeftBox.Name = "LeftBox";
            this.LeftBox.Size = new System.Drawing.Size(78, 21);
            this.LeftBox.TabIndex = 0;
            this.LeftBox.SelectedIndexChanged += new System.EventHandler(this.leftBox_SelectedIndexChanged);
            // 
            // OperatorBox
            // 
            this.OperatorBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.OperatorBox.FormattingEnabled = true;
            this.OperatorBox.Items.AddRange(new object[] {
            "<",
            ">",
            "==",
            "!=",
            ">=",
            "<="});
            this.OperatorBox.Location = new System.Drawing.Point(78, 0);
            this.OperatorBox.Name = "OperatorBox";
            this.OperatorBox.Size = new System.Drawing.Size(39, 21);
            this.OperatorBox.TabIndex = 1;
            this.OperatorBox.SelectedIndexChanged += new System.EventHandler(this.OperatorBox_SelectedIndexChanged);
            // 
            // RightBox
            // 
            this.RightBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.RightBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.RightBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RightBox.FormattingEnabled = true;
            this.RightBox.Location = new System.Drawing.Point(117, 0);
            this.RightBox.Name = "RightBox";
            this.RightBox.Size = new System.Drawing.Size(83, 21);
            this.RightBox.TabIndex = 2;
            this.RightBox.SelectedIndexChanged += new System.EventHandler(this.RightBox_SelectedIndexChanged);
            this.RightBox.TextChanged += new System.EventHandler(this.RightBox_SelectedIndexChanged);
            // 
            // ConditionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RightBox);
            this.Controls.Add(this.OperatorBox);
            this.Controls.Add(this.LeftBox);
            this.Name = "ConditionControl";
            this.Size = new System.Drawing.Size(202, 23);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox LeftBox;
        public System.Windows.Forms.ComboBox RightBox;
        protected System.Windows.Forms.ComboBox OperatorBox;
    }
}
