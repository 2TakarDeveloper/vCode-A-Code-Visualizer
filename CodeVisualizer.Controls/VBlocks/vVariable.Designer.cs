﻿namespace CodeVisualizer.Controls.VBlocks
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
            this.Header.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Size = new System.Drawing.Size(222, 26);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(141, 0);
            this.settingsButton.Size = new System.Drawing.Size(50, 26);
            // 
            // DisposeButton
            // 
            this.DisposeButton.Location = new System.Drawing.Point(191, 0);
            this.DisposeButton.Size = new System.Drawing.Size(31, 26);
            // 
            // body
            // 
            this.body.Size = new System.Drawing.Size(222, 26);
            // 
            // Vvariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Vvariable";
            this.Size = new System.Drawing.Size(222, 26);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
