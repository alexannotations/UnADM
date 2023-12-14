using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3
{
    internal class eTipoConversion
    {

        public static void Ejecutar()
        {
            Console.WriteLine("Hello, World!");
            int a;
            string tmp;

            System.Console.WriteLine("Escribe un numero entero: ");
            tmp = Console.ReadLine();

            // solo puede haber un bloque try
            try
            {
                a = System.Convert.ToInt16(tmp);

                System.Console.WriteLine("el numero escrito fue: " + a);

            }
            // al menos un bloque catch por cada bloque try
            // pero puede haber más de uno para controlar diferentes errores
            catch (FormatException fe)
            {
                System.Console.WriteLine("Escribiste el dato: " + tmp + " el cual no es un numero. " + fe);
            }
            // opcional,  se ejecuta sin importar si existio o no error
            finally
            {
                tmp = Console.ReadLine();
            }
        }

        }
    }
