﻿namespace Presentacion
{
    partial class PesosUnicapa
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
            this.TxtPesos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtPesos
            // 
            this.TxtPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPesos.Location = new System.Drawing.Point(12, 12);
            this.TxtPesos.Multiline = true;
            this.TxtPesos.Name = "TxtPesos";
            this.TxtPesos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtPesos.Size = new System.Drawing.Size(776, 426);
            this.TxtPesos.TabIndex = 0;
            // 
            // PesosUnicapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.TxtPesos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PesosUnicapa";
            this.Text = "PesosUnicapa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPesos;
    }
}