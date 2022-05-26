namespace Presentacion
{
    partial class FrmMenuMulticapa
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
            this.CmbFuncionActivacion1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTipoRed = new System.Windows.Forms.ComboBox();
            this.CmbCapasIntermadias = new System.Windows.Forms.ComboBox();
            this.CmbAlgoritmo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbFuncionActivacion2 = new System.Windows.Forms.ComboBox();
            this.CmbFuncionActivacion3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.NumericUpDown();
            this.Number2 = new System.Windows.Forms.NumericUpDown();
            this.Number3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NumIteraciones = new System.Windows.Forms.NumericUpDown();
            this.NumRata = new System.Windows.Forms.NumericUpDown();
            this.NumErrorMax = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Number1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumErrorMax)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbFuncionActivacion1
            // 
            this.CmbFuncionActivacion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFuncionActivacion1.FormattingEnabled = true;
            this.CmbFuncionActivacion1.Items.AddRange(new object[] {
            "Tangente Hiperbolica",
            "Sigmoide",
            "Seno",
            "Coseno",
            "Gausiana"});
            this.CmbFuncionActivacion1.Location = new System.Drawing.Point(77, 276);
            this.CmbFuncionActivacion1.Name = "CmbFuncionActivacion1";
            this.CmbFuncionActivacion1.Size = new System.Drawing.Size(297, 24);
            this.CmbFuncionActivacion1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(323, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcion De Activacion";
            // 
            // CmbTipoRed
            // 
            this.CmbTipoRed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoRed.FormattingEnabled = true;
            this.CmbTipoRed.Items.AddRange(new object[] {
            "Adaline",
            "Percetron",
            "Backpropagation"});
            this.CmbTipoRed.Location = new System.Drawing.Point(406, 106);
            this.CmbTipoRed.Name = "CmbTipoRed";
            this.CmbTipoRed.Size = new System.Drawing.Size(269, 24);
            this.CmbTipoRed.TabIndex = 2;
            this.CmbTipoRed.SelectedIndexChanged += new System.EventHandler(this.CmbTipoRed_SelectedIndexChanged);
            // 
            // CmbCapasIntermadias
            // 
            this.CmbCapasIntermadias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCapasIntermadias.FormattingEnabled = true;
            this.CmbCapasIntermadias.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CmbCapasIntermadias.Location = new System.Drawing.Point(406, 151);
            this.CmbCapasIntermadias.Name = "CmbCapasIntermadias";
            this.CmbCapasIntermadias.Size = new System.Drawing.Size(269, 24);
            this.CmbCapasIntermadias.TabIndex = 3;
            this.CmbCapasIntermadias.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // CmbAlgoritmo
            // 
            this.CmbAlgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAlgoritmo.Enabled = false;
            this.CmbAlgoritmo.FormattingEnabled = true;
            this.CmbAlgoritmo.Location = new System.Drawing.Point(406, 194);
            this.CmbAlgoritmo.Name = "CmbAlgoritmo";
            this.CmbAlgoritmo.Size = new System.Drawing.Size(269, 24);
            this.CmbAlgoritmo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(115, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo De Red:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(115, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Algoritmo De Entrenamiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(115, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero Capas Intermedias:";
            // 
            // CmbFuncionActivacion2
            // 
            this.CmbFuncionActivacion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFuncionActivacion2.FormattingEnabled = true;
            this.CmbFuncionActivacion2.Items.AddRange(new object[] {
            "Tangente Hiperbolica",
            "Sigmoide",
            "Seno",
            "Coseno",
            "Gausiana"});
            this.CmbFuncionActivacion2.Location = new System.Drawing.Point(77, 313);
            this.CmbFuncionActivacion2.Name = "CmbFuncionActivacion2";
            this.CmbFuncionActivacion2.Size = new System.Drawing.Size(297, 24);
            this.CmbFuncionActivacion2.TabIndex = 8;
            // 
            // CmbFuncionActivacion3
            // 
            this.CmbFuncionActivacion3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFuncionActivacion3.FormattingEnabled = true;
            this.CmbFuncionActivacion3.Items.AddRange(new object[] {
            "Tangente Hiperbolica",
            "Sigmoide",
            "Seno",
            "Coseno",
            "Gausiana"});
            this.CmbFuncionActivacion3.Location = new System.Drawing.Point(77, 352);
            this.CmbFuncionActivacion3.Name = "CmbFuncionActivacion3";
            this.CmbFuncionActivacion3.Size = new System.Drawing.Size(297, 24);
            this.CmbFuncionActivacion3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "C1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(21, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "C3:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(21, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "C2:";
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Location = new System.Drawing.Point(247, 500);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(302, 23);
            this.BtnGenerar.TabIndex = 16;
            this.BtnGenerar.Text = "Generar Y Guardar Pesos Y Umbrales";
            this.BtnGenerar.UseVisualStyleBackColor = true;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(665, 278);
            this.Number1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(120, 22);
            this.Number1.TabIndex = 17;
            this.Number1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(665, 313);
            this.Number2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(120, 22);
            this.Number2.TabIndex = 18;
            this.Number2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Number3
            // 
            this.Number3.Location = new System.Drawing.Point(665, 348);
            this.Number3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(120, 22);
            this.Number3.TabIndex = 19;
            this.Number3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(429, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Numero De Neuronas 1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(429, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Numero De Neuronas 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(429, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Numero De Neuronas 3:";
            // 
            // NumIteraciones
            // 
            this.NumIteraciones.Location = new System.Drawing.Point(254, 388);
            this.NumIteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumIteraciones.Name = "NumIteraciones";
            this.NumIteraciones.Size = new System.Drawing.Size(120, 22);
            this.NumIteraciones.TabIndex = 23;
            this.NumIteraciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumRata
            // 
            this.NumRata.DecimalPlaces = 2;
            this.NumRata.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NumRata.Location = new System.Drawing.Point(254, 416);
            this.NumRata.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumRata.Name = "NumRata";
            this.NumRata.Size = new System.Drawing.Size(120, 22);
            this.NumRata.TabIndex = 24;
            // 
            // NumErrorMax
            // 
            this.NumErrorMax.DecimalPlaces = 2;
            this.NumErrorMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NumErrorMax.Location = new System.Drawing.Point(254, 444);
            this.NumErrorMax.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumErrorMax.Name = "NumErrorMax";
            this.NumErrorMax.Size = new System.Drawing.Size(120, 22);
            this.NumErrorMax.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(21, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "No iteraciones:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(21, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Rata de aprendizaje:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(21, 447);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "Error maximo:";
            // 
            // FrmMenuMulticapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 563);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NumErrorMax);
            this.Controls.Add(this.NumRata);
            this.Controls.Add(this.NumIteraciones);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.CmbFuncionActivacion2);
            this.Controls.Add(this.CmbFuncionActivacion1);
            this.Controls.Add(this.CmbFuncionActivacion3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbAlgoritmo);
            this.Controls.Add(this.CmbCapasIntermadias);
            this.Controls.Add(this.CmbTipoRed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMenuMulticapa";
            this.Text = "FrmMenuMulticapa";
            ((System.ComponentModel.ISupportInitialize)(this.Number1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumErrorMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbFuncionActivacion1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTipoRed;
        private System.Windows.Forms.ComboBox CmbCapasIntermadias;
        private System.Windows.Forms.ComboBox CmbAlgoritmo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbFuncionActivacion2;
        private System.Windows.Forms.ComboBox CmbFuncionActivacion3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.NumericUpDown Number1;
        private System.Windows.Forms.NumericUpDown Number2;
        private System.Windows.Forms.NumericUpDown Number3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NumIteraciones;
        private System.Windows.Forms.NumericUpDown NumRata;
        private System.Windows.Forms.NumericUpDown NumErrorMax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}