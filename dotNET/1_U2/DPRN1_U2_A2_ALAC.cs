/* AAC 2021 septiembre
 * Métodos que no devuelven valores en C#
 * 
 */

using System;

namespace Procedimietos
{
    class operaciones
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" AAC\n ES18\n U2_A2_ALAC\n");

            float n1, n2, n3;

            //Pedimos valores al usuario
            Console.WriteLine("Introduce el primer número: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercer número: ");
            n3 = float.Parse(Console.ReadLine());

            mostrarPermutaciones(n1, n2, n3);
            sumaAcumulativa(n1, n2, n3);
        }

        public static void mostrarPermutaciones(float n1, float n2, float n3)
        {
            Console.WriteLine("\n Permutaciones posibles:");
            
            Console.WriteLine($"\t{n1} , {n2} , {n3} ");
            Console.WriteLine($"\t{n2} , {n3} , {n1} ");
            Console.WriteLine($"\t{n3} , {n1} , {n2} ");
            Console.WriteLine($"\t{n1} , {n3} , {n2} ");
            Console.WriteLine($"\t{n2} , {n1} , {n3} ");
            Console.WriteLine($"\t{n3} , {n2} , {n1} ");
        }

        public static void sumaAcumulativa(float n1, float n2, float n3)
        {
            Console.WriteLine("\n Suma acumulativa:");

            Console.WriteLine($"\t{n1} , {n1+n2} , {n1+n2+n3} ");
        }
    }
}
