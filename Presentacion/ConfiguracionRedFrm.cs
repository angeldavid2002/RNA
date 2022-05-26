using System;
using System.Windows.Forms;
using Datos;
namespace Presentacion
{
    public partial class ConfiguracionRedFrm : Form
    {
        datos datos;
        Parametros parametros = new Parametros();
        int validacionPesos = 0;
        int validacionUmbrales = 0;
        double[,] pesos;
        double[] umbrales;
        public ConfiguracionRedFrm(datos datos,Parametros parametros)
        {
            InitializeComponent();
            PnUnicapa.Enabled = false;
            this.datos = datos;
            this.parametros = parametros;
            CmbTipoRed.SelectedIndex = 0;
            CmbTipoCapa.SelectedIndex= 0;
            CmbFuncionActivacion.SelectedIndex= 0;
        }

        private void CmbTipoCapa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTipoCapa.Text.ToString() == "Unicapa")
            {
                PnUnicapa.Enabled = true;
            }
            else if (CmbTipoCapa.Text.ToString() == "Multicapa")
            {
                PnUnicapa.Enabled = false;
            }
        }

        private void BtnPesos_Click(object sender, EventArgs e)
        {
            cargarMatrizPesos();
            Form formPesos = new PesosUnicapa(datos,parametros,pesos);
            formPesos.Show();
        }

        void cargarMatrizPesos()
        {
            if (validacionPesos==0)
            {
                pesos = datos.CalcularPesos();
                validacionPesos = 1;
            }
        }

        private void BtnUmbrales_Click(object sender, EventArgs e)
        {
            cargarVectorUmbrales();
            Form formUmbrales = new UmbralesUnicapa(datos,parametros,umbrales);
            formUmbrales.Show();
        }

        void cargarVectorUmbrales()
        {
            if (validacionUmbrales == 0)
            {
                umbrales = datos.CalcularUmbrales();
                validacionUmbrales = 1;
            }
        }

        private void CmbTipoRed_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (CmbTipoRed.SelectedIndex==0)
            {
                //adaline
                CmbFuncionActivacion.Items.Clear();
                CmbFuncionActivacion.Items.Add("Lineal");
                CmbAlgoritmoEntrenamiento.Items.Clear();
                CmbAlgoritmoEntrenamiento.Items.Add("Regla delta");
                CmbAlgoritmoEntrenamiento.SelectedIndex = 0;
                CmbFuncionActivacion.SelectedIndex = 0;
                CmbAlgoritmoEntrenamiento.Enabled = true;
            }
            else if (CmbTipoRed.SelectedIndex==1)
            {
                //percetron
                CmbFuncionActivacion.Items.Clear();
                CmbFuncionActivacion.Items.Add("Escalon");
                CmbFuncionActivacion.SelectedIndex = 0;
                CmbAlgoritmoEntrenamiento.Enabled = false;
            }
            else if(CmbTipoRed.SelectedIndex==2)
            {
                //backpropagation
                CmbFuncionActivacion.Items.Clear();
                CmbFuncionActivacion.Items.Add("Sigmoide");
                CmbFuncionActivacion.Items.Add("Tangente Hiperbolica");
                CmbAlgoritmoEntrenamiento.Items.Clear();
                CmbAlgoritmoEntrenamiento.Items.Add("Propagacion inversa");
                CmbAlgoritmoEntrenamiento.SelectedIndex = 0;
                CmbFuncionActivacion.SelectedIndex = 0;
                CmbAlgoritmoEntrenamiento.Enabled = true;
            }
        }

        private void CmbFuncionActivacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
