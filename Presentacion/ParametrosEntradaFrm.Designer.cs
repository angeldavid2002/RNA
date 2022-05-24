namespace Presentacion
{
    partial class ParametrosEntradaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.TxtRuta = new System.Windows.Forms.TextBox();
            this.TxtEntradas = new System.Windows.Forms.TextBox();
            this.TxtSalidas = new System.Windows.Forms.TextBox();
            this.TxtPatrones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parametros De Entrada";
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(663, 106);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(92, 30);
            this.BtnCargar.TabIndex = 1;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // TxtRuta
            // 
            this.TxtRuta.Enabled = false;
            this.TxtRuta.Location = new System.Drawing.Point(293, 110);
            this.TxtRuta.Name = "TxtRuta";
            this.TxtRuta.Size = new System.Drawing.Size(364, 22);
            this.TxtRuta.TabIndex = 2;
            // 
            // TxtEntradas
            // 
            this.TxtEntradas.Enabled = false;
            this.TxtEntradas.Location = new System.Drawing.Point(293, 165);
            this.TxtEntradas.Name = "TxtEntradas";
            this.TxtEntradas.Size = new System.Drawing.Size(100, 22);
            this.TxtEntradas.TabIndex = 3;
            // 
            // TxtSalidas
            // 
            this.TxtSalidas.Enabled = false;
            this.TxtSalidas.Location = new System.Drawing.Point(481, 165);
            this.TxtSalidas.Name = "TxtSalidas";
            this.TxtSalidas.Size = new System.Drawing.Size(100, 22);
            this.TxtSalidas.TabIndex = 4;
            // 
            // TxtPatrones
            // 
            this.TxtPatrones.Enabled = false;
            this.TxtPatrones.Location = new System.Drawing.Point(689, 165);
            this.TxtPatrones.Name = "TxtPatrones";
            this.TxtPatrones.Size = new System.Drawing.Size(100, 22);
            this.TxtPatrones.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(225, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ruta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(190, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Entradas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(399, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salidas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(587, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Patrones:";
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.Location = new System.Drawing.Point(454, 233);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(94, 34);
            this.BtnContinuar.TabIndex = 10;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.UseVisualStyleBackColor = true;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ParametrosEntradaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 303);
            this.Controls.Add(this.BtnContinuar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPatrones);
            this.Controls.Add(this.TxtSalidas);
            this.Controls.Add(this.TxtEntradas);
            this.Controls.Add(this.TxtRuta);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ParametrosEntradaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros De Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.TextBox TxtRuta;
        private System.Windows.Forms.TextBox TxtEntradas;
        private System.Windows.Forms.TextBox TxtSalidas;
        private System.Windows.Forms.TextBox TxtPatrones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnContinuar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

