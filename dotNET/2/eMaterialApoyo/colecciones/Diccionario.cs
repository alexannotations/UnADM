// necesario para trabajar con listas
// Es una colección de elementos conformados por un par,
// con la siguiente estructura: Llave → Valor.
using System;
using System.Collections.Generic;


namespace Colecciones
{
    internal class Diccionario
    {
        public static void Ejemplo()
        {
            // Definimos un diccionario donde su llave es un entero y su dato un string
            Dictionary<int,string> lista = new Dictionary<int,string>();

            // Guardamos 4 nombres de personas con su llave
            lista.Add(345,"Juana");
            lista.Add(245, "Marta");
            lista.Add(123, "Angeles");
            lista.Add(667, "Paty");

            // Mostramos el contenido del diccionario
            // La manera mas comoda de hacer esto es con un ciclo foreach
            Console.WriteLine("Contenido del diccionario");
            foreach (int llave in lista.Keys)
            {
                Console.WriteLine(lista[llave]);
            }

            // Solo queremos leer el elemento numero 123 de la lista
            Console.WriteLine("Elemento en la llave 123");
            Console.WriteLine(lista[123]);

            // Buscamos una llave
            if (lista.ContainsKey(667))
            {
                Console.WriteLine("Existe la llave 667");
                Console.WriteLine("Su contenido es: " + lista[667]);
            }
            else
            {
                Console.WriteLine("Erorr la llave ni existe");
            }

            // Ordenar un diccionario es una lista un poco mas compleja. Debemos decidir si el ordenamiento es por su llave, o su valor
            // Desarrollaremos un sencilloejemplo de ordenar por llave. Recuperamos todas las llaves.
            var llaves = lista.Keys.ToList();

            // Ordenamos las llaves
            llaves.Sort();

            // Mostramos el contenido del diccionario
            Console.WriteLine("Diccionario ordenado por llave");
            foreach (int llave in llaves)
            {
                Console.WriteLine(llave + " " + lista[llave]);
            }

            // Borramos el dato 667
            lista.Remove(667);

            // Mostramos el contenido del diccionario
            Console.WriteLine("Nuevo contenido del diccionario");
            foreach (var llave in lista.Keys)
            {
                Console.WriteLine(lista[llave]);
            }

        }   // method

    }
}
