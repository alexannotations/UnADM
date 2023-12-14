/**
 * Alejandro Ayala Castro
 * octubre 2023
 * 
 * Clase de apoyo para dar de alta rostros
 * y almacenar rostros de ejemplo
 * 
 */

namespace DPRN2_U1_EA_ALAC
{
    internal static class RepositorioFacial
    {
        // Ejemplos de objetos Rostro propuestos en la actividad
        // Son estaticos para que no se instancien, al pertenecer a la misma clase
        internal static Rostro rostroE1 = new Rostro()
        {
            PatronTextura = "ABCDEFG",
            Forma = "Oval",
            ColorPiel = new Color("Caucasico", 90),
            RasgosFaciales = "Pecas, Lunares",
            Edad = 30,
            Otros = "Gafas"
        };

        // el modificador de acceso por defecto es private,
        // por lo que se define internal para poder hacer uso del campo
        internal static Rostro rostroE2 = new Rostro()
        {
            PatronTextura = "HIJKLMN",
            Forma = "Redondo",
            ColorPiel = new Color("Caucasico", 85),
            RasgosFaciales = "Arrugas",
            Edad = 35,
            Otros = "Barba"
        };

        // Dos Rostros capturados por el usuario
        // campo de la clase
        static Rostro[]? rostroCapturado = new Rostro[2];   // al ser una variable estatica esta asociada a la clase, acepta valores null
        // propiedad de la clase o miembro que controla el acceso al campo de clase
        internal static Rostro[]? RostroCapturado { get => rostroCapturado; set => rostroCapturado = value; }


        /**
         * Genera un objeto rostro a partir de los datos capturados por el usuario
         * Que se almacena en los campos estaticos de esta clase
         */
        internal static Rostro capturarRostro()
        {
            Console.WriteLine("Capture los datos conforme se soliciten:\n - Patrón de textura: ");
            string patronTextura = Console.ReadLine();

            Console.WriteLine("\n - Forma: ");
            string forma = Console.ReadLine();

            Console.WriteLine("\n - Tono de color de piel: ");
            string colorPielTono = Console.ReadLine();
            Console.WriteLine("\n - Intensid de color de piel (numero): ");
            double colorPielIntensidad = double.Parse(Console.ReadLine());
            Color colorPiel = new Color(colorPielTono, colorPielIntensidad);

            Console.WriteLine("\n - Rasgos faciales (separe con coma): ");
            string rasgosFaciales = Console.ReadLine();

            Console.WriteLine("\n - Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("\n - Otros rasgos: ");
            string? otros = Console.ReadLine();

            Rostro rostroCapturado = new Rostro(patronTextura, forma, colorPiel, rasgosFaciales, edad, otros);

            Console.WriteLine("El rostro se ha guardado ... ");
            return rostroCapturado;
        }   // END miembro capturarRostro()

    }
}
