/* UnADM 2021 septiembre
 * Ejemplo de métodos que no devuelven valores en C#
 * 
 */

using System;

namespace Procedimietos
{
    class operaciones
    {
        static void Main(string[] args)
        {

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
            restar(n1, n2); // manda llamar al método e imprime el resultado
        }

        public static void restar(float n1, float n2)
        {
            float resul; // Declaramos la variable que almacenará el resultado
            resul = n1 - n2;
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("El resultado de la resta es: ");
            Console.SetCursorPosition(55, 5);
            Console.WriteLine(resul); // Imprime lo que almacena la variable resul
            Console.ReadKey();

        }
    }

}
