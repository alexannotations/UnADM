using System.Security.Cryptography;

namespace SeguridadNacional
{

    abstract class Cifrado
    {
        // campos
        private string nombreAlgoritmo;
        private string claveCifrado;
        private string mensajeCifrado="";
        private string mensaje;

        // Propiedades
        internal string NombreAlgoritmo { get => nombreAlgoritmo; set => nombreAlgoritmo = value; }
        internal string MensajeACifrar { get => mensaje; set => mensaje = value; }
        internal string ClaveCifrado { get => claveCifrado; set => claveCifrado = value; }
        internal string MensajeCifrado { get => mensajeCifrado; set => mensajeCifrado = value; }


        protected Cifrado(string mensaje)
        {
            MensajeACifrar = mensaje;
        }


        /**
         * Cifrar el mensaje usando Advanced Encryption Standard
         * * */
        internal virtual void Cifrar() 
        {
            Console.WriteLine(" ... llamando al miembro de la clase abstracta Cifrado");
            using (Aes myAes = Aes.Create())
            {

                // Cifra la cadena en una matriz de bytes
                byte[] encrypted = EncriptadoDesencriptadoAES.EncryptStringToBytes_Aes(MensajeACifrar, myAes.Key, myAes.IV);

                //Display the original data and the decrypted data.
                Console.WriteLine("El mensaje Encriptado es: {0}", BitConverter.ToString(encrypted));
                Console.WriteLine("Desencriptado: {0}", EncriptadoDesencriptadoAES.DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV));

            }
        }

        internal virtual void DestruirMensaje()
        {
            Console.Write("Borrando mensaje original ... ");
            MensajeACifrar = null;
        }
    }

}