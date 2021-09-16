using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_U3
{
    class PantallaCelular
    {
        int ancho, alto;
        public void SetAlto()
        {
            Console.WriteLine("Indica el alto (n) de la pantalla: ");
            this.alto = int.Parse(Console.ReadLine());
            while (1 > alto)
            {
                Console.WriteLine("El alto debe ser 1 <= n: ");
                alto = int.Parse(Console.ReadLine());
            }
            Console.Clear();
        }

        public int GetAlto() => alto;

        public void SetAncho()
        {
            Console.WriteLine("Indica el ancho (m) de la pantalla: ");
            this.ancho = int.Parse(Console.ReadLine());
            while (ancho > 100)
            {
                Console.WriteLine("El ancho debe ser m <= 100: ");
                ancho = int.Parse(Console.ReadLine());
            }
            Console.Clear();
        }

        public int GetAncho() => ancho;

        public void DeterminarSaturacion(double saturacion)
        {
            if (saturacion >= .8)
                Console.WriteLine("Pantalla muy cargada."); // 80% o mas
            else if (saturacion < .8)
                Console.WriteLine("Pantalla poco cargada.");    // menos de 80%
            else if (saturacion == 0)
                Console.WriteLine("Pantalla sin funciones.");   // 0%
            else
                Console.WriteLine(" (´･_･`) Hay un error :-S");
        }

        public void LlenaPantalla(int alto, int ancho)
        {
            // Defino la matriz para el llenado de la pantalla
            int[,] matriz = new int[alto, ancho];
            Console.WriteLine("\n Indique como se llenara la pantalla;\n\t 0 para indicar vacio.\n\t 1 para indicar ocupado.");
            for (int i = 0; i < alto; i++)
            {
                //Console.WriteLine($"Linea {i+1}");
                for (int j = 0; j < ancho; j++)
                {
                    int valor = int.Parse(Console.ReadLine());
                    matriz.SetValue(valor, i,j);
                }

            }
        }

    }
}
