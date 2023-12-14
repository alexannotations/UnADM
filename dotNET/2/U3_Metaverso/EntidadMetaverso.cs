using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3_ea_alac
{
    internal abstract class EntidadMetaverso
    {
        private String nombre;
        private String descripcion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public abstract void Interactuar();

    }
}
