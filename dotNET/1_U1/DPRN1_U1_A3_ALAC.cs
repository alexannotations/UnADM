/* 
 * Calculos estadisticos; media, varianza y desviación estandar
 * para aplicar imprimir por consola, capturar datos y convertir 
 * tipos.
 * ago/2021 AAC
 * */

using System;

namespace ConsoleApp1
{
    class Unidad1_NET1_A3_ALAC
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" AAC \n ES18 \n DPRN1_U1_A3_ALAC \n Calculos estadisticos\n " + DateTime.Now);

            double x1, x2, x3;

            Console.Write("\nIntroduce el primer valor: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo valor: ");
            x2 = double.Parse(Console.ReadLine());

            Console.Write("Introduce el tercer valor: ");
            // Se utilizo Parse para convertir a tipo double la cadena obtenida por Console.ReadLine()
            x3 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nLos valores introducidos son: " + x1 + ", " + x2 + ", " + x3);

            double media = (x1+x2+x3) / 3;
            Console.WriteLine("La media de los valores introducidos es: " + media);

            // Se utiliza la clase Math para los calculos matematicos
            double varianza = ((Math.Pow((x1-media),2)) + (Math.Pow((x2 - media), 2)) + (Math.Pow((x3 - media), 2)))/3;
            Console.WriteLine("La varianza de los valores introducidos es: "+ varianza);

            double desvEstandar = Math.Sqrt(varianza);
            Console.WriteLine("La desviacion estandar de los valores introducidos es: " + desvEstandar);

        }
    }
}
