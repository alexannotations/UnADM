/* * * * * * * * * * * * 
 * Programa con estructuras de control selectivas
 * Propiedades del proyecto: plataforma de destino .NET 5.0
 * Autor:   AlexAC
 * Date:    Septiembre 2021
 * 
 * * * * * * * * * * * */

using System;


namespace unidad3
{
    class VacunacionFecha
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" AAC \n ES18 \n DPRN1_U3_A2_ALAC \n ");

            int switch_on;
            int id_fabricante;
            do
            {
                
                Console.WriteLine("\n\n\nVacuna contra COVID.\nSeleccione una opción: \n 1 - Fecha de vacunación.\n 2 - Información de vacunas.\n 9 - Salir.");
                switch_on = int.Parse(Console.ReadLine());

                fechaVacuna vacuna = new fechaVacuna();
                Console.Clear();
                switch (switch_on)
                {
                    case 1:
                        int edad = vacuna.verificarEdad();
                        DateTime primer_fecha = vacuna.conocerPrimeraDosis(edad);
                        DateTime segunda_fecha = vacuna.conocerSegundaDosis(primer_fecha);

                        Console.Clear();
                        Console.WriteLine($" Fechas de vacunacion.\n Basado en su edad: {edad} años." +
                            $"\n La primera dosis es: {primer_fecha.ToLongDateString()}" +
                            $"\n La segunda dosis es: {segunda_fecha.ToLongDateString()}");
                        break;

                    case 2:
                        Console.WriteLine("Seleccione vacuna: \n 1 - Sputnik V \n 2 - Pfizer \n 3 - Astra Zeneca ");
                        id_fabricante = int.Parse(Console.ReadLine());
                        EfectosSecundarios fabricante = new EfectosSecundarios(id_fabricante);
                        fabricante.mostrarDatos();
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