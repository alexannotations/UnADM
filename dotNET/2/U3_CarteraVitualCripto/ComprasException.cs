/** 
 * Impedir compras por mas de 1000USD en un dia
 * 
 * */

namespace u3_a4_alac
{
    internal class ComprasException : ApplicationException
    {
        public ComprasException()
        {
        }

        public ComprasException(string message) 
            : base(message)
        {
        }

        public ComprasException(string message, ApplicationException innerException) 
            : base(message, innerException)
        {
        }
    }

}
