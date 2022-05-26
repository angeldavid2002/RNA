using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Presentacion
{
    public partial class FrmUmbralMulti : Form
    {
        List<UmbralMulti> umbrales;
        Parametros parametros1;
        datos datos1;
        public FrmUmbralMulti(List<UmbralMulti> umbralList,Parametros parametros,datos datos )
        {
            InitializeComponent();
            this.parametros1 = parametros;
            this.umbrales=umbralList;
            datos1 = datos;
            cargarMatrices();
        }

        void cargarMatrices()
        {
            TxtUmbrales.Clear();
            TxtUmbrales.Text = null;
            for (int i = 0; i < umbrales.Count(); i++)
            {
                TxtUmbrales.Text = TxtUmbrales.Text + Environment.NewLine;
                TxtUmbrales.Text = TxtUmbrales.Text + (i + 1);
                TxtUmbrales.Text = TxtUmbrales.Text + Environment.NewLine;
                CargarMatriz(umbrales[i],i);
            }

        }

        void CargarMatriz(UmbralMulti umbralMulti,int j)
        {
            int salidas = umbralMulti.salida;
            double[] umbral = umbralMulti.umbral;
            TxtUmbrales.Text = TxtUmbrales.Text + Environment.NewLine;
            for (int i = 0; i < salidas; i++)
            {
                TxtUmbrales.Text += "|\t" + umbral[i].ToString() + "\t|";
                TxtUmbrales.Text = TxtUmbrales.Text + Environment.NewLine;
            }
            datos1.GuardarUmbral(umbral, salidas, j+1);
            TxtUmbrales.TextAlign = HorizontalAlignment.Center;
        }

    }
}
