// Representa una colección de objetos de tipo LIFO
// último en entrar, primero en salir
using System.Collections.Generic;

namespace Colecciones
{
    internal class StackPila
    {
        public static void Ejemplo()
        {
            // Definimos un contenedor del tipo cola
            Stack<string> pila = new Stack<string>();

            // Guardamos cuatro datos dentro de la cola
            pila.Push("Archivo.txt");
            pila.Push("Archivo.pdf");
            pila.Push("Archivo.doc");
            pila.Push("Archivo.ptt");

            // Mostramos los datos
            // Primero aparecerán los últimos datos guardados
            Console.WriteLine("Lista de datos guardados");
            for (int i = 0; i < pila.Count(); i++)
            {
                Console.WriteLine(i + " " + pila.Pop());
            }

        }

    }   // END class

}
