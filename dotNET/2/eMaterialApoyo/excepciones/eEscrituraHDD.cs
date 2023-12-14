using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***
 * El orden es muy importante.
 * Cuando una instrucción try tiene varios catch, 
 * deben ser ordenados desde los errores muy específicos 
 * hasta los más generales.
 * 
 * 
 * */


namespace u3
{
    internal class eEscrituraHDD
    {
        public static void Ejecutar()
        {

            try
            {
                string archivo = "c:\\puntonet\\temp.txt";
                FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Hola");
                sw.Close();
            }
            catch (System.UnauthorizedAccessException uae) 
            {
                // control de seguridad del SO
                // quitar permiso de escritura al archivo
                // C:/windows/system32/attrib c:/puntonet/temp.txt +r
                System.Console.WriteLine("\nError, NO tienes permiso sobre este archivo.\n" + uae.ToString());
            }
            catch (DirectoryNotFoundException dnfe)
            {
                // DirectoryNotFoundException es más especifica
                System.Console.WriteLine("\nError, primero debes crear el directorio.\n" + dnfe.ToString());
            }
            catch (IOException ioe)
            {
                // IOException excepción en general de entrada y salida
                System.Console.WriteLine("\nError General.\n" + ioe.ToString());
            }
            finally
            {
                System.Console.Read();
            }

        }
    }
}
