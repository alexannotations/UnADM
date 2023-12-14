using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos
{
    internal class PresionBarometrica
    {
        public static void iniciar(string[] args)
        {
            // Como estas ciudades siempre son las mismas 5 las definimos en la inicialización
            string[] ciudades = { 
                "México, CDMX",
                "Puebla, Pue.",
                "Xalapa, Ver.",
                "Tepic, Nay.", 
                "Mérida, Yuc."
            };

            // Como estos datos cambian solo definimos los arreglos
            double[,] datos = new double[5, 3];

            string tmp;

            // Creamos un ciclo que inicie en la fila 0 y llegue a la fila 4
            // Finalmente tendremos 5 filas
            for (int i = 0; i < ciudades.GetLength(0); i++)
            {
                System.Console.WriteLine("Para la ciudad: " + ciudades[i]);
                System.Console.WriteLine("Cuál es su presión barómetrica: ");
                tmp = System.Console.ReadLine();
                datos[i, 0] = System.Convert.ToDouble(tmp);

                System.Console.WriteLine("Cuál es su temperatura máxima: ");
                tmp = System.Console.ReadLine();
                datos[i, 1] = System.Convert.ToDouble(tmp);

                System.Console.Write("Cuál es su temperatura máxima: ");
                tmp = System.Console.ReadLine();
                datos[i, 1] = System.Convert.ToDouble(tmp);

                System.Console.WriteLine();
            }

            // Despues de leidos los datos estos son mostrados en forma de tabla
            System.Console.WriteLine("Tabla capturada");
            System.Console.WriteLine();

            System.Console.WriteLine("Csvo\tCiudad\t\tPresión\t"+"Temp. Max.\tTemp. Min.");

            for(int i=0; i < ciudades.GetLength(0); i++)
            {
                System.Console.WriteLine(i + 1 + "\t" + ciudades[i]
                    + "\t\t" + datos[i,0] + "\t" + datos[i,1] 
                    + "\t" + datos[i,2]);
                System.Console.WriteLine();
            }
            System.Console.ReadLine();
            

        } // Main method

    }
}
