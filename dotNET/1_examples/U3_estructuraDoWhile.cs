using System;

namespace EstructuraDoWhile
{
    class Seleccion
    {

        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Introduce la cantidad de numeros: ");
            n = int.Parse(Console.ReadLine());
            calcular(n);

        }


        public static void calcular(int n)
        {
            int i = 1;
            int mayor = 0;
            int menor = 0;
            int valor;
            double suma = 0;

            do
            {
                Console.WriteLine("Introduce el valor: " + i);
                valor = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    mayor = valor;
                    menor = valor;
                    suma = suma + valor;
                }
                else
                {
                    if (valor > mayor)
                    {
                        mayor = valor;
                    }
                    if (valor < menor)
                    {
                        menor = valor;
                    }
                    suma = suma + valor;
                }
                i++;

            } while (n >= i);

            suma = suma / n;
            Console.WriteLine("El numero mayor es: " + mayor);
            Console.WriteLine("El numero menor es: " + menor);
            Console.WriteLine("El promedio es: " + suma);
            Console.ReadKey();
            
        }

    }

}