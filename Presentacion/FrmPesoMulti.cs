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
    public partial class FrmPesoMulti : Form
    {
        List<PesosMulti> pesos;
        Parametros parametros1;
        datos datos1;
        public FrmPesoMulti(List<PesosMulti> pesos,Parametros parametros,datos datos)
        {
            InitializeComponent();
            this.pesos = pesos;
            this.parametros1 = parametros;
            datos1 = datos;
            cargarMatrices();
        }

        void cargarMatrices()
        {
            TxtPesoMulti.Clear();
            TxtPesoMulti.Text = null;
            for (int i = 0; i < pesos.Count(); i++)
            {
                TxtPesoMulti.Text = TxtPesoMulti.Text + Environment.NewLine;
                TxtPesoMulti.Text = TxtPesoMulti.Text + (i+1);
                TxtPesoMulti.Text = TxtPesoMulti.Text + Environment.NewLine;
                CargarMatriz(pesos[i],i);
            }
                
        }

        void CargarMatriz(PesosMulti pesosMulti,int k)
        {
            int entradas = pesosMulti.entrada;
            int salidas = pesosMulti.salida;
            double[,] peso = pesosMulti.peso;
            TxtPesoMulti.Text = TxtPesoMulti.Text+Environment.NewLine;
            for (int i = 0; i < salidas; i++)
            {
                for (int j = 0; j < entradas; j++)
                {
                    TxtPesoMulti.Text += "|\t" + peso[i, j].ToString() + "\t|";
                }
                TxtPesoMulti.Text = TxtPesoMulti.Text + Environment.NewLine;
            }
            TxtPesoMulti.TextAlign = HorizontalAlignment.Center;
            datos1.GuardarPeso(peso,salidas,entradas,k+1);
        }


    }
}
