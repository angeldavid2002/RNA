using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace Datos
{
    public class datos
    {
        public static Random random = new Random();
        public static Random random2 = new Random();
        public int patrones = 0, entradas = 0, salidas = 0,validacion=0;
        string rutaArchivo="";
        double[,] pesos;
        Parametros parametros;

        public datos(string ruta)
        {
            rutaArchivo = ruta;
        }

        public double[,] CalcularPesos()
        {
            double temp;
            pesos = new double[parametros.salida, parametros.entrada];
            for (int i = 0; i < parametros.salida; i++)
            {
                for (int j = 0; j < parametros.entrada; j++)
                {
                    temp = random.NextDouble();
                    temp=Math.Round(temp,2);
                    if (random.Next(1,3)==2)
                    {
                        temp = temp*-1;
                    }
                    pesos[i, j] = temp;
                }
            }
            return pesos;
        }
        
        public double[] CalcularUmbrales()
        {
            double[] umbrales = new double[parametros.salida];
            double temp;
            for (int i = 0; i < parametros.salida; i++)
            {
                temp = random2.NextDouble();
                temp = Math.Round(temp, 2);
                if (random2.Next(1, 3) == 2)
                {
                    temp = temp * -1;
                }
                umbrales[i] = temp;
            }
            return umbrales;
        }

        public Parametros ConsultarTodos()
        {
            FileStream file = new FileStream(rutaArchivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            validacion = 0;
            while ((linea = reader.ReadLine()) != null)
            {
                Map(linea);
                patrones=patrones+1;
            }
            reader.Close();
            file.Close();


            parametros = new Parametros(entradas, salidas, patrones);
            return parametros;
        }
        public void Map(string linea)
        {
            char delimiter = ';';
            string[] vector = linea.Split(delimiter);
            if (validacion==0)
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    if (vector[i].Contains("x"))
                    {
                        entradas = entradas + 1;
                    }
                    else if (vector[i].Contains("y"))
                    {
                        salidas = salidas + 1;
                    }
                }
                validacion++;
            }
        }

    }
    public class Parametros
    {
        public int entrada = 0, salida = 0, patrones = 0;

        public Parametros()
        {
        }

        public Parametros(int entrada, int salida, int patrones)
        {
            this.entrada = entrada;
            this.salida = salida;
            this.patrones = patrones-1;
        }
    }
}
