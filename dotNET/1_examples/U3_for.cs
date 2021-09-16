using System;

namespace EstructuraFor
{
    class Seleccion
    {

        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Introduce la cantidad de numeros a leer: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("El numero mayor es: " + calcular(n));
            Console.ReadKey();
        }


        public static int calcular(int n)
        {
            int i;
            int valor = 0;
            int mayor = 0;


            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Introduce el numero " + i);
                valor = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    mayor = valor;
                }
                else
                {
                    if (valor > mayor)
                        mayor = valor;
                }
            }
            return mayor;
        }

    }

}