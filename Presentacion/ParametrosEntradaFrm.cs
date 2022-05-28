using Datos;
using System;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class ParametrosEntradaForm : Form
    {
        datos datos1 = new datos("");
        string rutaDeArchivo = "";
        Parametros parametros= new Parametros();
        public ParametrosEntradaForm()
        {
            InitializeComponent();
            TxtRuta.Enabled = false;
            BtnContinuar.Enabled = false;
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rutaDeArchivo = openFileDialog1.FileName;
                    datos1 = new datos(rutaDeArchivo);
                    parametros = datos1.ConsultarTodos();
                    TxtEntradas.Text = parametros.entrada.ToString();
                    TxtPatrones.Text = parametros.patrones.ToString();
                    TxtSalidas.Text = parametros.salida.ToString();
                    TxtRuta.Text = rutaDeArchivo;
                    BtnContinuar.Enabled = true;
                    Console.WriteLine(parametros.patrones);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Surgio un error al seleccionar el archivo\nDetalles:\n" + ex);
                }
            }
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            Form formConfig = new ConfiguracionRedFrm(datos1,parametros);
            formConfig.Show();
        }
    }
}
