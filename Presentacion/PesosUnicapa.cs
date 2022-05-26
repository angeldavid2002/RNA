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
    public partial class PesosUnicapa : Form
    {
        datos datos;
        double[,] pesos;
        Parametros parametros;
        public PesosUnicapa(datos datos,Parametros parametros, double[,]pesos)
        {
            InitializeComponent();
            this.datos = datos;
            this.parametros = parametros;
            this.pesos = pesos;
            
            CargarMatriz();
        }

        void CargarMatriz()
        {
            int entradas = parametros.entrada;
            int salidas = parametros.salida;
            TxtPesos.Text = Environment.NewLine;
            for (int i = 0; i < salidas; i++)
            {
                for (int j = 0; j < entradas; j++)
                {
                    TxtPesos.Text += "|\t"+ pesos[i,j].ToString()+"\t|";
                }
                TxtPesos.Text = TxtPesos.Text + Environment.NewLine;
            }
            TxtPesos.TextAlign = HorizontalAlignment.Center;
        }


    }
}
