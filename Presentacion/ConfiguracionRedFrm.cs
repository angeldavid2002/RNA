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
            PnMulticapa.Visible = false;
            PnUnicapa.Visible = false;
            this.datos = datos;
            this.parametros = parametros;
            CmbTipoRed.SelectedIndex = 0;
            CmbTipoCapa.SelectedIndex= 0;
        }

        private void CmbTipoCapa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTipoCapa.Text.ToString() == "Unicapa")
            {
                PnUnicapa.Visible = true;
                PnMulticapa.Visible = false;
            }
            else if (CmbTipoCapa.Text.ToString() == "Multicapa")
            {
                PnMulticapa.Visible = true;
                PnUnicapa.Visible = false;
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

        }
    }
}
