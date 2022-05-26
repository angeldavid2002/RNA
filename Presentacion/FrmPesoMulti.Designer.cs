namespace Presentacion
{
    partial class FrmPesoMulti
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
            this.TxtPesoMulti = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtPesoMulti
            // 
            this.TxtPesoMulti.Location = new System.Drawing.Point(12, 12);
            this.TxtPesoMulti.Multiline = true;
            this.TxtPesoMulti.Name = "TxtPesoMulti";
            this.TxtPesoMulti.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtPesoMulti.Size = new System.Drawing.Size(776, 426);
            this.TxtPesoMulti.TabIndex = 0;
            // 
            // FrmPesoMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtPesoMulti);
            this.Name = "FrmPesoMulti";
            this.Text = "FrmPesoMulti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPesoMulti;
    }
}