using System;

namespace EstructuraIf
{
    class Seleccion
    {
        public static void Main(string[] args)
        {
            //Se declaran las variables
            float primero;
            float segundo;
            string operacion;
            Console.Title = "Especia de calculadora";
            Console.Clear();

            // Posicionamos el cursor y pedimos el primer número
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Introduce el primer número");
            Console.SetCursorPosition(55, 2);
            primero = float.Parse(Console.ReadLine());
            Console.SetCursorPosition(3, 3); // Posicionamos el cursor y pedimos la operación
            Console.WriteLine("Que operación que deseas realizar (+,-,*,/)");
            Console.SetCursorPosition(60, 3);
            operacion = Console.ReadLine();
            Console.SetCursorPosition(3, 4); // Posicionamos el cursor y pedimos el segundo número
            Console.WriteLine("Introduce el segundo número");
            Console.SetCursorPosition(55, 4);
            segundo = float.Parse(Console.ReadLine());

            // Mostramos el resultado
            Console.SetCursorPosition(55, 5);
            Console.WriteLine("__________");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("El resultado es");
            Console.SetCursorPosition(60, 6);
            Console.WriteLine(calcular(primero, segundo, operacion));

            // manda llamar al método e imprime el resultado
            Console.ReadKey();
        }
        private static string calcular(float primero, float segundo, string operacion)
        {
            float temp;
            // Se declara la sentencia switch, en la cual se realizará e caso u operación elegida.
            switch (operacion)
            {
                case "+":
                    temp = primero + segundo;
                    return temp.ToString();
                case "-":
                    temp = primero - segundo;
                    return temp.ToString();
                case "*":
                    temp = primero * segundo;
                    return temp.ToString();
                case "/":
                    temp = primero / segundo;
                    return temp.ToString();
            }
            // En caso de error regresa un negativo
            return "-1";
        }
    }

}