﻿namespace CodeVisualizer.Controls.Instructions
{
    partial class InstructionControl
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
            this.InstructionPicker = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.InstructionPanel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // InstructionPicker
            // 
            this.InstructionPicker.FormattingEnabled = true;
            this.InstructionPicker.Items.AddRange(new object[] {
            "Single Address",
            "Three Address"});
            this.InstructionPicker.Location = new System.Drawing.Point(102, 4);
            this.InstructionPicker.Name = "InstructionPicker";
            this.InstructionPicker.Size = new System.Drawing.Size(121, 21);
            this.InstructionPicker.TabIndex = 0;
            this.InstructionPicker.Text = "Single Address";
            this.InstructionPicker.SelectedIndexChanged += new System.EventHandler(this.InstructionPicker_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Instruction";
            // 
            // InstructionPanel
            // 
            this.InstructionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstructionPanel.HorizontalScrollbarBarColor = true;
            this.InstructionPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.InstructionPanel.HorizontalScrollbarSize = 10;
            this.InstructionPanel.Location = new System.Drawing.Point(0, 25);
            this.InstructionPanel.Name = "InstructionPanel";
            this.InstructionPanel.Size = new System.Drawing.Size(608, 204);
            this.InstructionPanel.TabIndex = 2;
            this.InstructionPanel.VerticalScrollbarBarColor = true;
            this.InstructionPanel.VerticalScrollbarHighlightOnWheel = false;
            this.InstructionPanel.VerticalScrollbarSize = 10;
            // 
            // InstructionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InstructionPanel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.InstructionPicker);
            this.Name = "InstructionControl";
            this.Size = new System.Drawing.Size(608, 229);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InstructionPicker;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel InstructionPanel;
    }
}
