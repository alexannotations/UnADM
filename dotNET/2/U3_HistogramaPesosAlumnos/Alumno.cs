using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3_a3_alac
{
    internal class Alumno
    {
        private string nombre;
        public string Nombre { get { return nombre; } }

        private int peso;
        public int Peso { get { return peso; } }

        public Alumno(string nombre, int peso)
        {
            this.nombre = nombre;
            this.peso = peso;
        }

    }   // END class 

}
