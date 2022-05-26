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
        List<UmbralMulti> umbralList = new List<UmbralMulti>();
        PesosMulti P1,P2,P3,P4;

        private void CmbTipoRed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTipoRed.Text=="Adaline" || CmbTipoRed.Text=="Percetron" )
            {
                CmbAlgoritmo.Items.Clear();
                CmbAlgoritmo.Items.Add("Regla Delta");
                CmbAlgoritmo.SelectedIndex = 0;
            }
            else if (CmbTipoRed.Text=="Backpropagation")
            {
                CmbAlgoritmo.Items.Clear();
                CmbAlgoritmo.Items.Add("Propagacion inversa");
                CmbAlgoritmo.SelectedIndex = 0;
            }
        }

        UmbralMulti U1, U2, U3, U4;
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
            CmbTipoRed.SelectedIndex=0;
            CmbAlgoritmo.Enabled = false;
            CmbFuncionActivacion1.SelectedIndex = 0;
            CmbFuncionActivacion2.SelectedIndex = 0;
            CmbFuncionActivacion3.SelectedIndex = 0;
            Number2.Enabled = false;
            Number3.Enabled = false;
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (CmbCapasIntermadias.Text=="1")
            {
                P1 = new PesosMulti(datos1.CalcularPesosParametro(Convert.ToInt32(Number1.Value), entrada), entrada, Convert.ToInt32(Number1.Value));
                pesosList.Add(P1);

                P2 = new PesosMulti(datos1.CalcularPesosParametro(salidaArchivo, Convert.ToInt32(Number1.Value)), Convert.ToInt32(Number1.Value), salidaArchivo);
                pesosList.Add(P2);

                U1 = new UmbralMulti(datos1.CalcularUmbralesParametros(Convert.ToInt32(Number1.Value)), Convert.ToInt32(Number1.Value));
                umbralList.Add(U1);

                U2 = new UmbralMulti(datos1.CalcularUmbralesParametros(salidaArchivo), salidaArchivo);
                umbralList.Add(U2);

            }
            else if (CmbCapasIntermadias.Text=="2")
            {
                P1 = new PesosMulti(datos1.CalcularPesosParametro(Convert.ToInt32(Number1.Value), entrada), entrada, Convert.ToInt32(Number1.Value));
                pesosList.Add(P1);

                P2 = new PesosMulti(datos1.CalcularPesosParametro(Convert.ToInt32(Number2.Value), Convert.ToInt32(Number1.Value)), Convert.ToInt32(Number1.Value), salidaArchivo);
                pesosList.Add(P2);

                P3 = new PesosMulti(datos1.CalcularPesosParametro(salidaArchivo, Convert.ToInt32(Number2.Value)), Convert.ToInt32(Number2.Value), salidaArchivo);
                pesosList.Add(P3);

                U1 = new UmbralMulti(datos1.CalcularUmbralesParametros(Convert.ToInt32(Number1.Value)), Convert.ToInt32(Number1.Value));
                umbralList.Add(U1);

                U2 = new UmbralMulti(datos1.CalcularUmbralesParametros(Convert.ToInt32(Number2.Value)), Convert.ToInt32(Number2.Value));
                umbralList.Add(U2);

                U3 = new UmbralMulti(datos1.CalcularUmbralesParametros(salidaArchivo), salidaArchivo);
                umbralList.Add(U3);

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

                U1 = new UmbralMulti(datos1.CalcularUmbralesParametros(Convert.ToInt32(Number1.Value)), Convert.ToInt32(Number1.Value));
                umbralList.Add(U1);

                U2 = new UmbralMulti(datos1.CalcularUmbralesParametros(Convert.ToInt32(Number2.Value)), Convert.ToInt32(Number2.Value));
                umbralList.Add(U2);

                U3 = new UmbralMulti(datos1.CalcularUmbralesParametros(Convert.ToInt32(Number3.Value)), Convert.ToInt32(Number3.Value));
                umbralList.Add(U3);

                U4 = new UmbralMulti(datos1.CalcularUmbralesParametros(salidaArchivo), salidaArchivo);
                umbralList.Add(U4);

            }
            FrmPesoMulti pesoMulti = new FrmPesoMulti(pesosList,parametros1,datos1);
            pesoMulti.Show();
            FrmUmbralMulti frmUmbralMulti = new FrmUmbralMulti(umbralList,parametros1,datos1);
            frmUmbralMulti.Show();
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCapasIntermadias.Text=="1")
            {
                CmbFuncionActivacion2.Enabled = false;
                CmbFuncionActivacion3.Enabled = false;
                Number2.Enabled = false;
                Number3.Enabled = false;
            }
            else if (CmbCapasIntermadias.Text=="2")
            {
                Number2.Enabled = true;
                Number3.Enabled = false;
                CmbFuncionActivacion2.Enabled = true;
                CmbFuncionActivacion3.Enabled = false;
            }
            else if (CmbCapasIntermadias.Text=="3")
            {
                Number2.Enabled = true;
                Number3.Enabled = true;
                CmbFuncionActivacion2.Enabled = true;
                CmbFuncionActivacion3.Enabled = true;

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
    public class UmbralMulti
    {
        public double[] umbral;
        public int salida;
        public UmbralMulti()
        {

        }
        public UmbralMulti(double[] umbral, int salida)
        {
            this.salida = salida;
            this.umbral = umbral;
        }
    }
}
