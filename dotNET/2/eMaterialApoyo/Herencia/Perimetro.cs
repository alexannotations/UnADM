using System.ComponentModel.Design.Serialization;

namespace Herencia
{
    class Perimetro
    {
        // el metodo CalcularPerimetro() es polimorfico paramétrico
        // cambia el numero de parametros, pero conserva la misma firma

        public double CalcularPerimetro(double L1, double L2, double L3)
        {
            return L1 + L2 + L3;
        }

        public double CalcularPerimetro(double L1, double L2, double L3, double L4)
        {
            return L1 + L2 + L3 + L4;
        }

        public double CalcularPerimetro(double L1, double L2, double L3, double L4, double L5)
        {
            return L1 + L2 + L3 + L4 + L5;
        }

        public double CalcularPerimetro(double L1, double L2, double L3, double L4, double L5, double L6)
        {
            return L1 + L2 + L3 + L4 +L5 + L6;
        }

    }   // END class Perimetro
}
