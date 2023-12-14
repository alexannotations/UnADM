/**
 * Alejandro Ayala Castro
 * octubre 2023
 * 
 */

namespace DPRN2_U1_EA_ALAC
{
    internal class Color
    {
        private string tono;
        private double intensidad;

        public string Tono { get => tono; set => tono = value; }
        public double Intensidad
        {
            get { return intensidad; }
            // Si `value` está entre 0 y 100 (ambos inclusive), se asigna ese valor a `intensidad`.
            // De lo contrario, se establece `intensidad` en 0.
            // Asegura que `intensidad` esté dentro del rango válido de 0 a 100.
            set { intensidad = value >= 0 && value <= 100 ? value : 0; }
        }

        public Color(string tono, double porcentaje)
        {
            Tono = tono;
            Intensidad = porcentaje;
        }

        ~Color() { Console.WriteLine("El objeto Color ha sido finalizado"); }

    }
}
