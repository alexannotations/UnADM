using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ac_alac
{
    internal class Repositorio
    {
        internal static string[] opciones = {
                    "\n 1 Crear" ,
                    "\n 2 Agregar" ,
                    "\n 3 Consultar " ,
                    "\n 4 Ver" ,
                    "\n 5 Eliminar"
        };

        static string? mensaje = null;

 


        /** * *******  *******  *******  ___  *******  *******  ******* */
        public static void ro1()
        {
            Console.WriteLine(opciones[0] + ": ");

        }


        /** * *******  *******  *******  ___  *******  *******  ******* */
        public static void ro2()
        {
            Console.WriteLine(opciones[1] + ": ");

        }


        /** * *******  *******  *******  ___  *******  *******  ******* */
        public static void ro3()
        {
            Console.WriteLine(opciones[2] + ": ");

        }


        /** * *******  *******  *******  ___  *******  *******  ******* */
        public static void ro4()
        {
            Console.WriteLine(opciones[3] + ": ");

        }


        /** * *******  *******  *******  ___  *******  *******  ******* */
        public static void ro5()
        {
            Console.WriteLine(opciones[4] + ": ");

        }


    }
}
