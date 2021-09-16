/* * * * * * * * * * * * 
 * Programa con estructuras de control selectivas
 * Propiedades del proyecto: plataforma de destino .NET 5.0
 * Autor:   Alex AC
 * Date:    Septiembre 2021
 * 
 * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad3
{
    class fechaVacuna
    {


        public int verificarEdad()
        {
            int edad;

            do
            {
                Console.Write("Introduzca su edad (18+): ");
                edad = int.Parse(Console.ReadLine());

                if (edad < 17)
                {
                    Console.Clear();
                    Console.WriteLine("Por el momento no puede vacunarse.\nUsted es menor de edad con {0} años.", edad);
                }

                if (edad < 0 || edad > 122)
                {
                    Console.Clear();
                    Console.WriteLine("Introduzca una edad valida. \nUsted introdujo: " + edad);
                }

            } while (edad < 17 || edad > 122);

            return edad;
        }

        public DateTime conocerPrimeraDosis(int edad)
        {
            // Considere retornar un DateTime para calcular la fecha de la segunda dosis.
            // En caso necesario solo modificar una variable de primera dosis por grupo de edad.
            DateTime grupo60mas = DateTime.Parse("01/Enero/2021");
            DateTime grupo50_59 = DateTime.Parse("01/Febrero/2021");
            DateTime grupo40_49 = DateTime.Parse("15/Febrero/2021"); ;
            DateTime grupo30_39 = DateTime.Parse("04/Marzo/2021"); ;
            DateTime grupo18_29 = DateTime.Parse("30/Marzo/2021"); ;

            if (edad >= 60)
            {
                //Console.WriteLine("Usted tiene más de 60.\n Su primera dosis es el: {0}", grupo60mas.ToLongDateString());
                return grupo60mas;
            }
            else if (edad >= 50)
            {
                //Console.WriteLine($"Usted tiene entre 50 - 59.\n Su primera dosis es el: {grupo50_59.ToLongDateString()}");
                return grupo50_59;
            }
            else if (edad >= 40)
            {
                //Console.WriteLine("Usted tiene entre 40 - 49.\n Su primera dosis es el: " + grupo40_49.ToLongDateString());
                return grupo40_49;
            }
            else if (edad >= 30)
            {
                //Console.WriteLine("Usted tiene entre 30 - 39.\n Su primera dosis es el: " + grupo30_39.ToLongDateString());
                return grupo30_39;
            }
            else //edad >= 18
            {
                //Console.WriteLine("Usted tiene entre 18 - 29.\n Su primera dosis es el: " + grupo18_29.ToLongDateString());
                return grupo18_29;
            }

        }

        // Al tener una sola linea de codigo, con el operador => se pueden omitir { las llaves } y la palabra return
        public DateTime conocerSegundaDosis(DateTime primer_fecha) => primer_fecha.AddDays(15);

    }
}
