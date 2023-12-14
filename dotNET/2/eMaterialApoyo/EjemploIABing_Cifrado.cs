// Para ilustrar el funcionamiento del cifrado simétrico con AES, vamos a ver un ejemplo sencillo en C#. 
// Para ello, vamos a usar la clase Aes de la biblioteca System.Security.Cryptography, 
// que nos proporciona los métodos y propiedades necesarios para cifrar y descifrar datos con AES. 
// Ejemplo generado por la IA de Bing

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class EjemploIABing_Cifrado
{
    static void exampleIABing()
    {
        // Creamos una instancia de la clase Aes
        Aes aes = Aes.Create();

        // Generamos una clave aleatoria de 256 bits
        aes.KeySize = 256;
        aes.GenerateKey();

        // Mostramos la clave en hexadecimal
        Console.WriteLine("Clave: " + BitConverter.ToString(aes.Key));

        // Generamos un vector de inicialización aleatorio de 128 bits
        aes.GenerateIV();

        // Mostramos el vector de inicialización en hexadecimal
        Console.WriteLine("Vector de inicialización: " + BitConverter.ToString(aes.IV));

        // Creamos un mensaje de prueba
        string mensaje = "Hola, este es un mensaje secreto";

        // Convertimos el mensaje a un array de bytes
        byte[] mensajeBytes = Encoding.UTF8.GetBytes(mensaje);

        // Mostramos el mensaje original
        Console.WriteLine("Mensaje original: " + mensaje);

        // Creamos un objeto para cifrar los datos con la clave y el vector de inicialización
        ICryptoTransform cifrador = aes.CreateEncryptor(aes.Key, aes.IV);

        // Creamos un stream de memoria para almacenar los datos cifrados
        MemoryStream msCifrado = new MemoryStream();

        // Creamos un stream de cifrado que escribe en el stream de memoria usando el cifrador
        CryptoStream csCifrado = new CryptoStream(msCifrado, cifrador, CryptoStreamMode.Write);

        // Escribimos los datos en el stream de cifrado
        csCifrado.Write(mensajeBytes, 0, mensajeBytes.Length);

        // Cerramos el stream de cifrado
        csCifrado.Close();

        // Obtenemos los datos cifrados desde el stream de memoria
        byte[] mensajeCifrado = msCifrado.ToArray();

        // Mostramos el mensaje cifrado en hexadecimal
        Console.WriteLine("Mensaje cifrado: " + BitConverter.ToString(mensajeCifrado));

        // Creamos un objeto para descifrar los datos con la misma clave y el mismo vector de inicialización
        ICryptoTransform descifrador = aes.CreateDecryptor(aes.Key, aes.IV);

        // Creamos un stream de memoria para almacenar los datos descifrados
        MemoryStream msDescifrado = new MemoryStream();

        // Creamos un stream de descifrado que escribe en el stream de memoria usando el descifrador
        CryptoStream csDescifrado = new CryptoStream(msDescifrado, descifrador, CryptoStreamMode.Write);

        // Escribimos los datos en el stream de descifrado
        csDescifrado.Write(mensajeCifrado, 0, mensajeCifrado.Length);

        // Cerramos el stream de descifrado
        csDescifrado.Close();

        // Obtenemos los datos descifrados desde el stream de memoria
        byte[] mensajeDescifrado = msDescifrado.ToArray();

        // Convertimos el array de bytes a una cadena
        string mensajeOriginal = Encoding.UTF8.GetString(mensajeDescifrado);

        // Mostramos el mensaje descifrado
        Console.WriteLine("Mensaje descifrado: " + mensajeOriginal);
    }
}

// La salida sería algo así:

// Clave: 2F-8E-9F