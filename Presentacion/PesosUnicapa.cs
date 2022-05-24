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
        int verificacion = 0;
        string matriz="";
        Parametros parametros;
        public PesosUnicapa(datos datos,Parametros parametros)
        {
            InitializeComponent();
            this.datos = datos;
            this.parametros = parametros;
            
            CargarMatriz();
        }

        void CargarMatriz()
        {
            int entradas = parametros.entrada;
            int salidas = parametros.salida;
            if(verificacion == 0)
            {
                pesos = new double[entradas,salidas];
                verificacion = 1;
            }
            pesos = datos.CalcularPesos();
            TxtPesos.Text = Environment.NewLine;
            for (int i = 0; i < entradas; i++)
            {
                for (int j = 0; j < salidas; j++)
                {
                    TxtPesos.Text += "|\t"+ pesos[i,j].ToString()+"\t|";
                }
                TxtPesos.Text = TxtPesos.Text + Environment.NewLine;
            }
            TxtPesos.TextAlign = HorizontalAlignment.Center;
        }


    }
}
