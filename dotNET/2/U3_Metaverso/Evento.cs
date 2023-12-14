using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3_ea_alac
{
    internal class Evento : EntidadMetaverso
    {
        private DateTime fecha;
        private Lugar lugarEvento;
        private String descripcion;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion1 { get => descripcion; set => descripcion = value; }
        internal Lugar LugarEvento { get => lugarEvento; set => lugarEvento = value; }

        public override void Interactuar()
        {
            Console.WriteLine("Interactuar Evento");
        }
    }
}
