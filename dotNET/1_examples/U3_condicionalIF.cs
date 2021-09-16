using System;

namespace EstructuraIf
{
    class Estructura
    {
        //Tenemos declarado el método Main
        static void Main(string[] args)
        {
            //Declaramos las variables que almacenaran los valores ingresados por
            //los usuarios y una más denominada operación que almacenará
            //la opción de la operación que el usuario seleccione.
            int num1;
            int num2;
            string operacion;
            //En ésta ocasión vamos a decorar un poco la consola :)
            //Agregamos un título al programa
            Console.Title = "Mi primer estructura en C#";
            // Damos formato a la consola
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            ///Limpiamos por si hubiera basura
            Console.Clear();

            //Pedimos al usuario introduzca el primer valor
            Console.WriteLine("Introduzca el primer número");
            num1 = Int32.Parse(Console.ReadLine());
            //Pedimos al usuario introduzca el primer valor
            Console.WriteLine("Introduzca el segundo número");
            num2 = Int32.Parse(Console.ReadLine());
            //Pedimos al usuario introduzca el valor de la operación a realizar.
            Console.WriteLine("Escoja una opción: + para Sumar ó * para Multiplicar");
            operacion = (Console.ReadLine());
            //En ésta sección declaramos la sentencia if, la cual lo que realiza es
            //una inspección preguntando por la opción de la operación que el usuario
            //seleccionó, esto porque de lo seleccionado depende la operación que el 
            //sistema realizará.
            //si la operación seleccionada es + de Sumar, entrará a ésta condición
            if (operacion == "+")
            {
                Console.WriteLine("La suma es =: " + (num1 + num2));
                Console.WriteLine("Gracias por utilizar mi programa :)");
            }
            //Si no es sumar lo que el usuario ingresa, entonces preguntaría si
            //la operación es multiplicar o * y entrara a ésta segunda condición
            else if (operacion == "*")
            {
                Console.WriteLine("La multiplicación es =: " + (num1 * num2));
                Console.WriteLine("Gracias por utilizar mi programa :)");
            }
            else
            {
                Console.WriteLine("La opción de la operación seleccionada es incorrecta, lo siento, vuelve a intentar: (");
            }
            Console.ReadLine();
        }
    }
}