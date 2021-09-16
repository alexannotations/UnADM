using System;

namespace EA_U3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Programación NET1\n AAC\n DPRN1_U3_EA_ALAC");

            PantallaCelular pantalla = new PantallaCelular();

            int switch_on;
            do
            {
                Console.WriteLine("\n\n EA - Programa con condiciones y ciclos.\n Seleccione una opción: \n\t1 - Pantalla de celular.\n\t2 - Función.\n\t9 - Salir.");
                switch_on = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (switch_on)
                {
                    case 1:
                        pantalla.SetAlto();
                        int alto_pantalla = pantalla.GetAlto();
                        pantalla.SetAncho();
                        int ancho_pantalla = pantalla.GetAncho();
                        Console.WriteLine($"Ancho pantalla: {ancho_pantalla} | Alto pantalla: {alto_pantalla}");
                        pantalla.LlenaPantalla(alto_pantalla, ancho_pantalla);

                        break;

                    case 2:
                        int numero_a_convertir;
                        Funcion nombre = new Funcion();
                        Console.Write("Introduzca un numero entero: ");
                        numero_a_convertir = int.Parse(Console.ReadLine());
                        nombre.HacerUno(numero_a_convertir);
                        break;

                    case 9:
                        Console.WriteLine("Saliendo.");
                        break;

                    default:
                        Console.WriteLine($"La opción ({switch_on}) no es valida.", switch_on);
                        break;
                }
            } while (switch_on != 9);
        }
    }
}
