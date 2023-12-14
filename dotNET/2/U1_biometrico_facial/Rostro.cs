/**
 * Alejandro Ayala Castro
 * octubre 2023
 * 
 */

namespace DPRN2_U1_EA_ALAC
{
    internal class Rostro
    {
        private string patronTextura;
        private string forma;
        private Color colorPiel;
        private string rasgosFaciales;
        private int edad;
        private string? otros;

        // Constructor
        internal Rostro(string patronTextura, string forma, 
                        Color colorPiel, string rasgosFaciales, 
                        int edad, string otros)
        {
            PatronTextura = patronTextura;
            Forma = forma;
            ColorPiel = colorPiel;
            RasgosFaciales = rasgosFaciales;
            Edad = edad;
            Otros = otros;
        }

        // Constructor sobrecargado
        internal Rostro() { }

        // finalizador o destructor
        ~Rostro(){Console.WriteLine("El objeto Rostro ha sido finalizado");}

        // Campos encapsulados
        internal string PatronTextura { get => patronTextura; set => patronTextura = value; }
        internal string Forma { get => forma; set => forma = value; }
        internal Color ColorPiel { get => colorPiel; set => colorPiel = value; }    // El acceso está limitado al ensamblado actual.
        internal string RasgosFaciales { get => rasgosFaciales; set => rasgosFaciales = value; }
        internal int Edad { get => edad; set => edad = value; }
        internal string Otros { get => otros; set => otros = value; }


        // Miembros de clase

        // Cambiar intensidad de color de piel
        internal void SimularEnvejecimiento(double intensidad) 
        {
            ColorPiel.Intensidad = intensidad;
            Console.WriteLine("La intensidad del color disminuye con el tiempo "+ ColorPiel.Intensidad);
        }


        // Cambiar edad
        internal void SimularEnvejecimiento(int edad) 
        {
            if (edad>Edad)
            {
                Edad = edad;
                Console.WriteLine("La edad contribuye al envejecimiento: "+Edad+" años");
            }
            else {
                Console.WriteLine("No es posible rejuvenecer");
            }
        }


        // Agregar rasgos faciales
        internal void SimularEnvejecimiento(string rasgos) 
        {
            // agrego los rasgos, con una coma intermedia
            // para separarlos de los ya guardados
            RasgosFaciales = RasgosFaciales +" , "+ rasgos;
            Console.WriteLine("Aparición de nuevos rasgos faciales con el tiempo");
        }


        internal void mostrarDatosRostro()
        {
            Console.WriteLine(
                "\tTextura: " + PatronTextura +
                "\n\tForma: " + Forma +
                "\n\tColor de piel: " + ColorPiel.Tono + ", " + ColorPiel.Intensidad +
                "\n\tRasgos faciales: " + RasgosFaciales +
                "\n\tEdad: " + Edad +
                "\n\tOtras caracteristicas: " + Otros
                );
        }   // end mostrarDatosRostro()

    }
}
