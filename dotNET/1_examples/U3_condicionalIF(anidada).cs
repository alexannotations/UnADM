using System;

namespace EstructuraIf
{

    class Anidados
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            //En ésta ocasión vamos a decorar un poco la consola :)
            //Agregamos un título al programa
            Console.Title = "Mi primer estructura anidada en C#";
            // Damos formato a la consola
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            ///Limpiamos por si hubiera basura
            Console.Clear();
            //uso del IF anidados

            //Pedimos al usuario introduzca el primer valor
            Console.WriteLine("Ingrese el primer número entero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero entero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero entero");
            num3 = int.Parse(Console.ReadLine());


            //ESTRUCTURA IF ANIDADA
            //El siguiente es el primer if
            if (num1 > num2 && num1 > num3)
            {
                //Mandamos imprimir, los números entre paréntesis indican el orden de los valores
                //impresión, los cuales son indicados por las variables después de las comillas.
                Console.WriteLine("En número {0} es mayor que , {1} y que, {2} ", num1, num2, num3);
            }
            else
            {
                //El siguiente es el segundo if dentro del primero
                if (num2 > num3)
                {
                    Console.WriteLine("En número {1} es mayor que {0} y {2}", num1, num2, num3);
                }
                //El siguiente es la última condición dentro del if
                else
                {
                    Console.WriteLine("En número {2} es mayor que {0} y {1}", num1, num2, num3);
                }
            }
            Console.ReadLine();
        }
    }



}