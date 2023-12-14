using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3_a3_alac
{
    class RangoFueraException : ApplicationException
    {
        // sin parametros
        public RangoFueraException()
        {
        }

        // con un mensaje como parametro
        public RangoFueraException(string message)
            : base(message)
        {
        }

        // con posibilidad de pasar una excepcion interna anidada
        public RangoFueraException(string message, ApplicationException inner)
            : base(message, inner)
        {
        }
    }
}
