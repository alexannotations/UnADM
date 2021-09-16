using System;

namespace EstructuraWhile
{
    class Seleccion
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Introduce el valor de N");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma es: " + calcular(n));
            Console.ReadKey();
        }

        // Calcular 
        public static double calcular(int n)
        {
            int i = 1;
            double suma = 0;
            while (n >= i)
            {
                suma = suma + (1.0 / i);
                i++;
            }
            return suma;
        }

    }

}