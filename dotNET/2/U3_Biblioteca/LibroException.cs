using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ac_alac
{
    internal class LibroException: ApplicationException
    {
        public LibroException()
        {
        }

        public LibroException(string message)
            : base(message)
        {
        }

        public LibroException(string message, ApplicationException innerException)
            : base(message, innerException)
        {
        }
    }
}
