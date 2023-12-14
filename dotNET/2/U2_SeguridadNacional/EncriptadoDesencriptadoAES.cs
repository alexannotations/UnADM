/**
 * AES algoritmo de cifrado simetrico, y utiliza la misma clave para cifrar y descifrar.
 * El cifrado se realiza en bloques de 128bits, pero puede utilizar diferentes longitudes de clave: 128, 192 o 256.
 * 
 * La clase Aes permite:
 *  crear una instancia del algoritmo AES
 *  genera una clave y Un vector de inicialización aleatorio (IV) (Ambos necesariamente los mismos para cifrar y descifrar los datos)
 *  crea un objeto 'CryptoStream' que cifra o descifra los datos que se escriben o leen en el
 *  
 *  Para descifrar se puede usar el metodo 'CreateDecryptor()' para crear un transformador que realiza el descifrado, y
 *  pasarlo al constructor del 'CryptoStream'.
 *  
 *  Para leer los datos descifrados desde el 'CryptoStream' usando un 'StreamReader'
 *  
 *  Codigo retomado de:
 *  https://learn.microsoft.com/es-es/dotnet/api/system.security.cryptography.aes?view=net-6.0
 * 
 * https://www.infoworld.com/article/3683911/how-to-use-symmetric-and-asymmetric-encryption-in-c-sharp.html#:~:text=You%20must%20have%20both%20a,RSACryptoServiceProvider()%3B%20string%20publicKeyXML%20%3D%20rsa
 * 
 * 
 * */

using System.Security.Cryptography; // AES
using System.Text;
using System;
using System.IO;



namespace SeguridadNacional
{
    internal class EncriptadoDesencriptadoAES
    {
        public static void InitExampleAES(string textToEncrypt)
        {
            string original = textToEncrypt;  // El texto a cifrar

            // Crea la instancia de la clase Aes
            // Genera una nueva llave y vector de inicializacion (IV).
            using (Aes myAes = Aes.Create())
            {
                // Mostramos la clave y el vector de inicialización, por si lo necesitamos para el descifrado
                Console.WriteLine("\nClave: " + BitConverter.ToString(myAes.Key) + "\nIV: " + BitConverter.ToString(myAes.IV) +"\n");

                // Cifra la cadena en una matriz de bytes
                byte[] encrypted = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV);

                // Descifra los bytes en una cadena
                string roundtrip = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

                //Display the original data and the decrypted data.
                Console.WriteLine("Original:   {0}", original);
                Console.WriteLine("Encriptado:   {0}", BitConverter.ToString(encrypted));
                Console.WriteLine("Desencriptado: {0}", roundtrip);
            }   //  using implementa la interfaz IDisposable o IAsyncDisposable y
                //  asegura que se llama al método Dispose o DisposeAsync
                //  al final para liberar recursos 

        }


        public static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // comprobar argumentos lanzando excepciones
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;   // Para los datos cifrados desde la secuencia de memoria

            // Crear un objeto Aes
            // con la clave especificada y IV (recibidas previamente)
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Crea un encryptor para realizar la transformación de flujo (stream transform).
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Crear los streams utilizados para el cifrado.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // Crea un objeto CryptoStream que cifra los datos
                    using (CryptoStream csEncrypt = new CryptoStream(
                        msEncrypt, // La secuencia donde escribimos los datos cifrados
                        encryptor, // El transformador que realiza el cifrado
                        CryptoStreamMode.Write))    // El modo de acceso al CryptoStream
                    {
                        // Escribimos la cadena en el CryptoStream usando un StreamWriter
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            // Escribe todos los datos en la secuencia (stream).
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Devuelve los bytes cifrados del flujo de memoria.
            return encrypted;
        }

        // recibe el texto cifrado (byte stream y la clave y IV)
        public static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // comprobar argumentos lanzando excepciones
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declara la cadena utilizada para contener el texto descifrado.
            string plaintext = null;

            // Crear un objeto Aes
            // con la clave especificada y IV (parametros recibidos)
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Crea un deencryptor para realizar la transformación de flujo (stream transform).
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Crear los streams utilizados para el descifrado.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(
                        msDecrypt,
                        decryptor,
                        CryptoStreamMode.Read))
                    {
                        // Leemos la cadena en el CryptoStream usando un StreamReader
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;
        }
    }



}
