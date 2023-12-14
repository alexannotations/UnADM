using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3_ea_alac
{
    internal class UsuarioMetaversoExeption : ApplicationException
    {
        public UsuarioMetaversoExeption()
        {
        }

        public UsuarioMetaversoExeption(string message)
            : base(message)
        {
        }

        public UsuarioMetaversoExeption(string message, ApplicationException innerException)
            : base(message, innerException)
        {
        }
    }
}
