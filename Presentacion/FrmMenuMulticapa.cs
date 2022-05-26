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
    public partial class FrmMenuMulticapa : Form
    {
        datos datos1;
        Parametros parametros1;
        int salidaArchivo,entrada=0;
        List<PesosMulti> pesosList= new List<PesosMulti>();
        PesosMulti P1,P2,P3,P4;
        List<double[]> umbralList = new List<double[]>();

        public FrmMenuMulticapa(datos datos, Parametros parametros)
        {
            InitializeComponent();
            datos1 = datos;
            parametros1=parametros;
            entrada = parametros.entrada;
            salidaArchivo = parametros.salida;
            CmbFuncionActivacion2.Enabled = false;
            CmbFuncionActivacion3.Enabled = false;
            CmbCapasIntermadias.SelectedIndex= 0;
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (CmbCapasIntermadias.Text=="1")
            {
                P1 = new PesosMulti(datos1.CalcularPesosParametro(Convert.ToInt32(Number1.Value), entrada), entrada, Convert.ToInt32(Number1.Value));
                pesosList.Add(P1);

                P2 = new PesosMulti(datos1.CalcularPesosParametro(salidaArchivo, Convert.ToInt32(Number1.Value)), Convert.ToInt32(Number1.Value), salidaArchivo);
                pesosList.Add(P2);

                umbralList.Add(datos1.CalcularUmbralesParametros(Convert.ToInt32(Number1.Value)));

            }
            else if (CmbCapasIntermadias.Text=="2")
            {
                P1 = new PesosMulti(datos1.CalcularPesosParametro(Convert.ToInt32(Number1.Value), entrada), entrada, Convert.ToInt32(Number1.Value));
                pesosList.Add(P1);

                P2 = new PesosMulti(datos1.CalcularPesosParametro(Convert.ToInt32(Number2.Value), Convert.ToInt32(Number1.Value)), Convert.ToInt32(Number1.Value), salidaArchivo);
                pesosList.Add(P2);

                P3 = new PesosMulti(datos1.CalcularPesosParametro(salidaArchivo, Convert.ToInt32(Number2.Value)), Convert.ToInt32(Number2.Value), salidaArchivo);
                pesosList.Add(P3);


                umbralList.Add(datos1.CalcularUmbralesParametros(Convert.ToInt32(Number1.Value)));
                umbralList.Add(datos1.CalcularUmbralesParametros(Convert.ToInt32(Number2.Value)));
                umbralList.Add(datos1.CalcularUmbralesParametros(salidaArchivo));

            }
            else if (CmbCapasIntermadias.Text == "3")
            {
                P1 = new PesosMulti(datos1.CalcularPesosParametro(Convert.ToInt32(Number1.Value), entrada), entrada, Convert.ToInt32(Number1.Value));
                pesosList.Add(P1);

                P2 = new PesosMulti(datos1.CalcularPesosParametro(Convert.ToInt32(Number2.Value), Convert.ToInt32(Number1.Value)), Convert.ToInt32(Number1.Value), Convert.ToInt32(Number2.Value));
                pesosList.Add(P2);

                P3 = new PesosMulti(datos1.CalcularPesosParametro(Convert.ToInt32(Number3.Value), Convert.ToInt32(Number2.Value)), Convert.ToInt32(Number2.Value), Convert.ToInt32(Number3.Value));
                pesosList.Add(P3);

                P4 = new PesosMulti(datos1.CalcularPesosParametro(salidaArchivo, Convert.ToInt32(Number3.Value)), Convert.ToInt32(Number3.Value), salidaArchivo);
                pesosList.Add(P4);

                umbralList.Add(datos1.CalcularUmbralesParametros(Convert.ToInt32(Number1.Value)));
                umbralList.Add(datos1.CalcularUmbralesParametros(Convert.ToInt32(Number2.Value)));
                umbralList.Add(datos1.CalcularUmbralesParametros(Convert.ToInt32(Number3.Value)));
                umbralList.Add(datos1.CalcularUmbralesParametros(salidaArchivo));
            }
            FrmPesoMulti pesoMulti = new FrmPesoMulti(pesosList,parametros1);
            pesoMulti.Show();
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCapasIntermadias.Text=="1")
            {

            }
            else if (CmbCapasIntermadias.Text=="2")
            {

            }
            else if (CmbCapasIntermadias.Text=="3")
            {
            }
        }
    }
    public class PesosMulti
    {
        public double[,] peso;
        public int entrada;
        public int salida;
        public PesosMulti()
        {

        }
        public PesosMulti(double[,] peso,int entrada,int salida)
        {
            this.entrada = entrada;
            this.salida = salida;
            this.peso = peso;
        }
    }
}
