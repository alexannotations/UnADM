/* UnADM 2021 septiembre
 * 
 * 
 */

using System;

namespace Procedimietos
{
    class operaciones
    {
        static void Main(string[] args)
        {

            //Se declaran variables
            float n1;
            float n2;

            //Pedimos valores al usuario
            Console.SetCursorPosition(3, 2); // Posicionamos el cursor y pedimos el primer número
            Console.WriteLine("Introduce el primer número: ");
            Console.SetCursorPosition(55, 2);
            n1 = float.Parse(Console.ReadLine());

            //Pedimos valores al usuario
            Console.SetCursorPosition(3, 3); // Posicionamos el cursor y pedimos el primer número
            Console.WriteLine("Introduce el segundo número: ");
            Console.SetCursorPosition(55, 3);
            n2 = float.Parse(Console.ReadLine());
            Console.ReadKey();

            Console.SetCursorPosition(3, 4);
            Console.WriteLine("El resultado de la suma es: ");
            Console.SetCursorPosition(55, 4);
            float n3 = sumar(n1, n2);
            Console.WriteLine(n3); // manda llamar al método sumar e imprime el resultado
            //Console.WriteLine(sumar(n1, n2));
            Console.ReadKey();

        }

        public static float sumar(float n1, float n2)
        {
            float resultado; // Declaramos una variable llamada resultado del mismo tupo que la función
            resultado = n1 + n2; //Se realiza la suma
            return resultado; // retornamos el resultado para que se imprima en panttalla
        }

    }
}
