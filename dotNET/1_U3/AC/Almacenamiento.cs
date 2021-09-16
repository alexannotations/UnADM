using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadComplementaria
{
    class Almacenamiento
    {
        public int GuardarDatos(int save)
        {
            Console.WriteLine("Se estan guardando los datos ...");
            if (save >= 1)
            {
                Console.WriteLine("Guardado terminado.");
                return 0;
            }
            else
            {
                Console.WriteLine("Error al guardar.");
                return -1;
            }
        }

    }
}
