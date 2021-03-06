﻿namespace CodeVisualizer.Controls.VBlocks.Variable
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
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Header.Size = new System.Drawing.Size(268, 28);
            this.Header.TabIndex = 0;
            // 
            // NameLable
            // 
            this.NameLable.Size = new System.Drawing.Size(104, 19);
            this.NameLable.Text = "VariableName";
            this.NameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameLable.UseCustomBackColor = true;
            // 
            // body
            // 
            this.body.Controls.Add(this.metroPanel1);
            this.body.Location = new System.Drawing.Point(10, 10);
            this.body.Size = new System.Drawing.Size(270, 27);
            this.body.Controls.SetChildIndex(this.Header, 0);
            this.body.Controls.SetChildIndex(this.metroPanel1, 0);
            // 
            // ExpandCollapseButton
            // 
            this.ExpandCollapseButton.Location = new System.Drawing.Point(143, 1);
            this.ExpandCollapseButton.Size = new System.Drawing.Size(10, 24);
            this.ExpandCollapseButton.Visible = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(153, 1);
            this.metroButton1.Size = new System.Drawing.Size(48, 24);
            this.metroButton1.Visible = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(201, 1);
            this.settingsButton.Size = new System.Drawing.Size(33, 24);
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // DisposeButton
            // 
            this.DisposeButton.Location = new System.Drawing.Point(234, 1);
            this.DisposeButton.Size = new System.Drawing.Size(31, 24);
            this.DisposeButton.Click += new System.EventHandler(this.DisposeButton_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(268, 0);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Vvariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Vvariable";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(290, 47);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}
