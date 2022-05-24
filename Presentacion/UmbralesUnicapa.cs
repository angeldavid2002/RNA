﻿using System;
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
    public partial class UmbralesUnicapa : Form
    {
        datos datos;
        Parametros parametros;
        double[] umbrales;

        public UmbralesUnicapa(datos datos,Parametros parametros)
        {
            InitializeComponent();
            this.datos = datos;
            this.parametros = parametros;
            CargarMatriz();
        }

        void CargarMatriz()
        {
            int salidas = parametros.salida;
            umbrales = new double[salidas];
            umbrales = datos.CalcularUmbrales();
            TxtUmbrales.Text = Environment.NewLine;
            for (int i = 0; i < salidas; i++)
            {
                TxtUmbrales.Text += "|\t" + umbrales[i].ToString() + "\t|";
            }
            TxtUmbrales.TextAlign = HorizontalAlignment.Center;
        }

    }
}
