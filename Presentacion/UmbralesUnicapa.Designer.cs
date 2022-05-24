namespace Presentacion
{
    partial class UmbralesUnicapa
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
            this.TxtUmbrales = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtUmbrales
            // 
            this.TxtUmbrales.Location = new System.Drawing.Point(12, 12);
            this.TxtUmbrales.Multiline = true;
            this.TxtUmbrales.Name = "TxtUmbrales";
            this.TxtUmbrales.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtUmbrales.Size = new System.Drawing.Size(776, 426);
            this.TxtUmbrales.TabIndex = 0;
            // 
            // UmbralesUnicapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtUmbrales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UmbralesUnicapa";
            this.Text = "UmbralesUnicapa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUmbrales;
    }
}