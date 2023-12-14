// necesario para trabajar con listas
// Es equivalente al concepto de una lista doblemente ligada
// Es una estructura de nodos enlazados secuencialmente
// Dos enlaces (anterior y siguiente) y el que almacena la información
using System.Collections.Generic;

namespace Colecciones
{
    class Lista
    {
        public static void Ejemplo()
        {
            // Definimos una lista que solo guardara datos de tipo string
            List<string> lista = new List<string>();

            // Guardamos 4 nombres de personas
            lista.Add("Maria");
            lista.Add("Ana");
            lista.Add("Luisa");
            lista.Add("Ariadna");

            // Mostramos el contenido de la lista
            // La manera mas comoda de hacer esto es con un ciclo foreach (materia net 1)
            Console.WriteLine("Lista de elementos");
            foreach (string nombre in lista)
            {
                Console.WriteLine(nombre);
            }

            // Solo queremos leer el elemento numero 2 de la lista
            Console.WriteLine("Elemento en la posicion 2");
            Console.WriteLine(lista[2]);

            // Nos muestra que posicion tiene Ana
            Console.WriteLine("Indice del elemento Ana");
            Console.WriteLine(lista.FindIndex(x => x == "Ana"));

            // Ordena la lista
            lista.Sort();

            // Mostramos el contenido de la lista
            Console.WriteLine("Lista de elementos ordenada");
            foreach (string nombre in lista)
            {
                Console.WriteLine(nombre);
            }

            // Borramos a Maria
            lista.Remove("Maria");

            // Mostramos el contenido de la lista
            Console.WriteLine("Contenido de la lista");
            foreach (string nombre in lista)
            {
                Console.WriteLine(nombre);
            }

        }
    }
}
