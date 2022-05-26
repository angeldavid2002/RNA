namespace Presentacion
{
    partial class ConfiguracionRedFrm
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
            this.CmbTipoCapa = new System.Windows.Forms.ComboBox();
            this.LblTipoRed = new System.Windows.Forms.Label();
            this.CmbTipoRed = new System.Windows.Forms.ComboBox();
            this.LblCapas = new System.Windows.Forms.Label();
            this.LblUnicapa = new System.Windows.Forms.Label();
            this.PnUnicapa = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbAlgoritmoEntrenamiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbFuncionActivacion = new System.Windows.Forms.ComboBox();
            this.BtnUmbrales = new System.Windows.Forms.Button();
            this.BtnPesos = new System.Windows.Forms.Button();
            this.PnUnicapa.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbTipoCapa
            // 
            this.CmbTipoCapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoCapa.FormattingEnabled = true;
            this.CmbTipoCapa.Items.AddRange(new object[] {
            "Unicapa",
            "Multicapa"});
            this.CmbTipoCapa.Location = new System.Drawing.Point(462, 57);
            this.CmbTipoCapa.Name = "CmbTipoCapa";
            this.CmbTipoCapa.Size = new System.Drawing.Size(176, 24);
            this.CmbTipoCapa.TabIndex = 0;
            this.CmbTipoCapa.SelectedIndexChanged += new System.EventHandler(this.CmbTipoCapa_SelectedIndexChanged);
            // 
            // LblTipoRed
            // 
            this.LblTipoRed.AutoSize = true;
            this.LblTipoRed.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.LblTipoRed.Location = new System.Drawing.Point(184, 53);
            this.LblTipoRed.Name = "LblTipoRed";
            this.LblTipoRed.Size = new System.Drawing.Size(118, 19);
            this.LblTipoRed.TabIndex = 1;
            this.LblTipoRed.Text = "Tipo De Red:";
            // 
            // CmbTipoRed
            // 
            this.CmbTipoRed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoRed.FormattingEnabled = true;
            this.CmbTipoRed.Items.AddRange(new object[] {
            "Adaline",
            "Percetron",
            "Backpropagation"});
            this.CmbTipoRed.Location = new System.Drawing.Point(480, 53);
            this.CmbTipoRed.Name = "CmbTipoRed";
            this.CmbTipoRed.Size = new System.Drawing.Size(241, 24);
            this.CmbTipoRed.TabIndex = 2;
            this.CmbTipoRed.SelectedIndexChanged += new System.EventHandler(this.CmbTipoRed_SelectedIndexChanged);
            // 
            // LblCapas
            // 
            this.LblCapas.AutoSize = true;
            this.LblCapas.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.LblCapas.Location = new System.Drawing.Point(377, 62);
            this.LblCapas.Name = "LblCapas";
            this.LblCapas.Size = new System.Drawing.Size(68, 19);
            this.LblCapas.TabIndex = 4;
            this.LblCapas.Text = "Capas:";
            // 
            // LblUnicapa
            // 
            this.LblUnicapa.AutoSize = true;
            this.LblUnicapa.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.LblUnicapa.Location = new System.Drawing.Point(408, 21);
            this.LblUnicapa.Name = "LblUnicapa";
            this.LblUnicapa.Size = new System.Drawing.Size(81, 19);
            this.LblUnicapa.TabIndex = 6;
            this.LblUnicapa.Text = "Unicapa";
            // 
            // PnUnicapa
            // 
            this.PnUnicapa.Controls.Add(this.label2);
            this.PnUnicapa.Controls.Add(this.CmbAlgoritmoEntrenamiento);
            this.PnUnicapa.Controls.Add(this.label1);
            this.PnUnicapa.Controls.Add(this.CmbFuncionActivacion);
            this.PnUnicapa.Controls.Add(this.BtnUmbrales);
            this.PnUnicapa.Controls.Add(this.BtnPesos);
            this.PnUnicapa.Controls.Add(this.LblTipoRed);
            this.PnUnicapa.Controls.Add(this.CmbTipoRed);
            this.PnUnicapa.Controls.Add(this.LblUnicapa);
            this.PnUnicapa.Location = new System.Drawing.Point(50, 129);
            this.PnUnicapa.Name = "PnUnicapa";
            this.PnUnicapa.Size = new System.Drawing.Size(883, 520);
            this.PnUnicapa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(184, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Algoritmo De Entrenamiento:";
            // 
            // CmbAlgoritmoEntrenamiento
            // 
            this.CmbAlgoritmoEntrenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAlgoritmoEntrenamiento.FormattingEnabled = true;
            this.CmbAlgoritmoEntrenamiento.Location = new System.Drawing.Point(480, 206);
            this.CmbAlgoritmoEntrenamiento.Name = "CmbAlgoritmoEntrenamiento";
            this.CmbAlgoritmoEntrenamiento.Size = new System.Drawing.Size(241, 24);
            this.CmbAlgoritmoEntrenamiento.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(184, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Funcion De Activacion:";
            // 
            // CmbFuncionActivacion
            // 
            this.CmbFuncionActivacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFuncionActivacion.FormattingEnabled = true;
            this.CmbFuncionActivacion.Items.AddRange(new object[] {
            "Escalon",
            "Sigmoide",
            "Tangente Hiperbolica",
            "Lineal"});
            this.CmbFuncionActivacion.Location = new System.Drawing.Point(480, 149);
            this.CmbFuncionActivacion.Name = "CmbFuncionActivacion";
            this.CmbFuncionActivacion.Size = new System.Drawing.Size(241, 24);
            this.CmbFuncionActivacion.TabIndex = 9;
            this.CmbFuncionActivacion.SelectedIndexChanged += new System.EventHandler(this.CmbFuncionActivacion_SelectedIndexChanged);
            // 
            // BtnUmbrales
            // 
            this.BtnUmbrales.Location = new System.Drawing.Point(480, 100);
            this.BtnUmbrales.Name = "BtnUmbrales";
            this.BtnUmbrales.Size = new System.Drawing.Size(241, 23);
            this.BtnUmbrales.TabIndex = 8;
            this.BtnUmbrales.Text = "Calcular Umbrales";
            this.BtnUmbrales.UseVisualStyleBackColor = true;
            this.BtnUmbrales.Click += new System.EventHandler(this.BtnUmbrales_Click);
            // 
            // BtnPesos
            // 
            this.BtnPesos.Location = new System.Drawing.Point(188, 100);
            this.BtnPesos.Name = "BtnPesos";
            this.BtnPesos.Size = new System.Drawing.Size(246, 23);
            this.BtnPesos.TabIndex = 7;
            this.BtnPesos.Text = "Calcular Pesos";
            this.BtnPesos.UseVisualStyleBackColor = true;
            this.BtnPesos.Click += new System.EventHandler(this.BtnPesos_Click);
            // 
            // ConfiguracionRedFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 686);
            this.Controls.Add(this.PnUnicapa);
            this.Controls.Add(this.LblCapas);
            this.Controls.Add(this.CmbTipoCapa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConfiguracionRedFrm";
            this.Text = "ConfiguracionRedFrm";
            this.PnUnicapa.ResumeLayout(false);
            this.PnUnicapa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbTipoCapa;
        private System.Windows.Forms.Label LblTipoRed;
        private System.Windows.Forms.ComboBox CmbTipoRed;
        private System.Windows.Forms.Label LblCapas;
        private System.Windows.Forms.Label LblUnicapa;
        private System.Windows.Forms.Panel PnUnicapa;
        private System.Windows.Forms.Button BtnUmbrales;
        private System.Windows.Forms.Button BtnPesos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbFuncionActivacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbAlgoritmoEntrenamiento;
    }
}