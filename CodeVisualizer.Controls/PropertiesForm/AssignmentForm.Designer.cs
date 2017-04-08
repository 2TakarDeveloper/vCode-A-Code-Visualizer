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
            this.AssignmentVariable = new System.Windows.Forms.ComboBox();
            this.Rows = new System.Windows.Forms.ComboBox();
            this.Columns = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SubmitButton = new MetroFramework.Controls.MetroButton();
            this.instructionControl1 = new InstructionControl();
            this.SuspendLayout();
            // 
            // AssignmentVariable
            // 
            this.AssignmentVariable.FormattingEnabled = true;
            this.AssignmentVariable.Location = new System.Drawing.Point(176, 63);
            this.AssignmentVariable.Name = "AssignmentVariable";
            this.AssignmentVariable.Size = new System.Drawing.Size(121, 21);
            this.AssignmentVariable.TabIndex = 0;
            // 
            // Rows
            // 
            this.Rows.FormattingEnabled = true;
            this.Rows.Location = new System.Drawing.Point(318, 63);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(37, 21);
            this.Rows.TabIndex = 1;
            // 
            // Columns
            // 
            this.Columns.FormattingEnabled = true;
            this.Columns.Location = new System.Drawing.Point(361, 63);
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(37, 21);
            this.Columns.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(296, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(25, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "=";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubmitButton.Location = new System.Drawing.Point(20, 340);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(614, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseSelectable = true;
            // 
            // instructionControl1
            // 
            this.instructionControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.instructionControl1.Instruction = null;
            this.instructionControl1.Location = new System.Drawing.Point(20, 118);
            this.instructionControl1.Name = "instructionControl1";
            this.instructionControl1.Size = new System.Drawing.Size(614, 222);
            this.instructionControl1.TabIndex = 6;
            this.instructionControl1.UseSelectable = true;
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 383);
            this.Controls.Add(this.instructionControl1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.AssignmentVariable);
            this.Name = "AssignmentForm";
            this.Text = "Assignment";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.MidnightBlue;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AssignmentVariable;
        private System.Windows.Forms.ComboBox Rows;
        private System.Windows.Forms.ComboBox Columns;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton SubmitButton;
        private InstructionControl instructionControl1;
    }
}