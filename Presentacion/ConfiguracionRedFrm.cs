using System;
using System.Windows.Forms;
using Datos;
namespace Presentacion
{
    public partial class ConfiguracionRedFrm : Form
    {
        datos datos;
        Parametros parametros = new Parametros();
        public ConfiguracionRedFrm(datos datos,Parametros parametros)
        {
            InitializeComponent();
            PnMulticapa.Visible = false;
            PnUnicapa.Visible = false;
            this.datos = datos;
            this.parametros = parametros;
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
            Form formPesos = new PesosUnicapa(datos,parametros);
            formPesos.Show();
        }

        private void BtnUmbrales_Click(object sender, EventArgs e)
        {
            Form formUmbrales = new UmbralesUnicapa(datos,parametros);
            formUmbrales.Show();
        }
    }
}
