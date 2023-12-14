// Representa una colección de objetos de tipo FIFO
// primero en entrar, primero en salir

using System.Collections.Generic;

namespace Colecciones
{
    internal class QueueCola
    {
        public static void Ejemplo()
        {
            // Definimos un contenedor del tipo cola
            Queue<string> cola = new Queue<string>();

            // Guardamos cuatro datos dentro de la cola
            cola.Enqueue("Archivo.txt");
            cola.Enqueue("Archivo.pdf");
            cola.Enqueue("Archivo.doc");
            cola.Enqueue("Archivo.ptt");

            // Mostramos los datos.
            // Estos apareceran en el orden en que ingresarón los datos
            Console.WriteLine("Lista de datos guardados");
            for (int i = 0; i < cola.Count(); i++)
            {
                Console.WriteLine(i + " " + cola.Dequeue());
            }

        }
    }
}
