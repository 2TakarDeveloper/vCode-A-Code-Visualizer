using CodeVisualizer.Controls.Instructions;

namespace CodeVisualizer.Controls.PropertiesForm
{
    partial class AssignmentForm
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
            this.SubmitButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Columns = new System.Windows.Forms.ComboBox();
            this.Rows = new System.Windows.Forms.ComboBox();
            this.AssignmentVariable = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.InstructionPanel = new MetroFramework.Controls.MetroPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubmitButton.Location = new System.Drawing.Point(20, 240);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(614, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseSelectable = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(285, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(25, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "=";
            // 
            // Columns
            // 
            this.Columns.FormattingEnabled = true;
            this.Columns.Location = new System.Drawing.Point(411, 3);
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(104, 21);
            this.Columns.TabIndex = 2;
            this.Columns.Visible = false;
            // 
            // Rows
            // 
            this.Rows.FormattingEnabled = true;
            this.Rows.Location = new System.Drawing.Point(301, 3);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(104, 21);
            this.Rows.TabIndex = 1;
            this.Rows.Visible = false;
            // 
            // AssignmentVariable
            // 
            this.AssignmentVariable.FormattingEnabled = true;
            this.AssignmentVariable.Location = new System.Drawing.Point(158, 3);
            this.AssignmentVariable.Name = "AssignmentVariable";
            this.AssignmentVariable.Size = new System.Drawing.Size(121, 21);
            this.AssignmentVariable.TabIndex = 0;
            this.AssignmentVariable.SelectedIndexChanged += new System.EventHandler(this.AssignmentVariable_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.AssignmentVariable);
            this.panel1.Controls.Add(this.Rows);
            this.panel1.Controls.Add(this.Columns);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 49);
            this.panel1.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Assignment Variable";
            // 
            // InstructionPanel
            // 
            this.InstructionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstructionPanel.HorizontalScrollbarBarColor = true;
            this.InstructionPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.InstructionPanel.HorizontalScrollbarSize = 10;
            this.InstructionPanel.Location = new System.Drawing.Point(20, 109);
            this.InstructionPanel.Name = "InstructionPanel";
            this.InstructionPanel.Size = new System.Drawing.Size(614, 131);
            this.InstructionPanel.TabIndex = 6;
            this.InstructionPanel.VerticalScrollbarBarColor = true;
            this.InstructionPanel.VerticalScrollbarHighlightOnWheel = false;
            this.InstructionPanel.VerticalScrollbarSize = 10;
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 283);
            this.Controls.Add(this.InstructionPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SubmitButton);
            this.Name = "AssignmentForm";
            this.Text = "Assignment";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.MidnightBlue;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton SubmitButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox Columns;
        private System.Windows.Forms.ComboBox Rows;
        private System.Windows.Forms.ComboBox AssignmentVariable;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroPanel InstructionPanel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}