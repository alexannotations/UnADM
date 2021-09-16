using System;
using System.Globalization;

namespace NET1_U2_EA_ALAC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" AAC\n ES18\n U2_EA_ALAC\n");

            string full_name;

            //Pedimos valores al usuario
            Console.Write("Introduca su nombre completo comenzando por nombre: ");
            full_name = Console.ReadLine();

            // Separamos la cadena full_name en subcadenas con un arreglo
            string[] name = full_name.Split();

            // Llamamos a los metodos que regresan parametros
            string email = generaEmail(name[0], name[1], name[2]);
            string password = generaPassword(name[0], name[1], name[2]);

            // Llamamos al metodo que no regresa parametros para mostrar la información.
            mostrarInformacion(name[0], name[1], name[2], email, password);
        }
        
        static string generaEmail(string nombre_pila, string apellido_paterno, string apellido_materno) {
            //Se convierte a minuscula considerando que los correos se acostumbran escribir asi.
            TextInfo name_lower = CultureInfo.CurrentCulture.TextInfo;
            return ($"{name_lower.ToLower(nombre_pila)}.{name_lower.ToLower(apellido_paterno.Substring(0, 1))}{name_lower.ToLower(apellido_materno.Substring(0, 1))}@correo.com");
        }

        static string generaPassword(string nombre_pila, string apellido_paterno, string apellido_materno) {
            TextInfo password = CultureInfo.CurrentCulture.TextInfo;
            return ($"{password.ToUpper(nombre_pila.Substring(0,2))}{Convert.ToInt32(char.Parse(password.ToLower(apellido_materno.Substring(apellido_materno.Length-1,1))))}{password.ToLower(apellido_paterno.Substring(0,1))}{password.ToUpper(apellido_paterno.Substring(apellido_paterno.Length-1,1))}");
        }

        static void mostrarInformacion(string nombre_pila, string apellido_paterno, string apellido_materno, string email, string password)
        {
            TextInfo nombre_completo = CultureInfo.CurrentCulture.TextInfo;
            Console.WriteLine(nombre_completo.ToTitleCase(nombre_pila) +" " + nombre_completo.ToTitleCase(apellido_paterno) +" " + nombre_completo.ToTitleCase(apellido_materno));
            Console.WriteLine(email);
            Console.WriteLine(password);
        }
    }
}
