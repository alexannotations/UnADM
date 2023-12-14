// Colección de pares clave/valor que se ordenan conforme a la clave
// es un árbol de búsqueda binaria, el cual se mantiene automaticamente balanceado

using System.Collections.Generic;

// SortedList requiere la implementación de un comparador para ordenar y realizar comparaciones
// Un comparador es una clase que le indicará a la colección cómo se deben ordenar los objetos

namespace Colecciones
{
    /** El programa principal mostrará el lote ordenado por 
     * placa, modelo, precio ascendente y descendente. 
     * Se utiliza un List para generar los resultados.
     *
     * * */
    class SortedList_ListaOrdenada
    {
        public static void Ejemplo()
        {
            // Se crea un contenedor del tipo SortedList
            List<Auto> loteAutos = new List<Auto>();

            // Se almacenan 5 autos
            loteAutos.Add(new Auto("YCS3932", "Nissan", "Sentra", "Perla", 2000, 95000));
            loteAutos.Add(new Auto("YTR1010", "Ford", "Focus", "Rojo", 2001, 80000));
            loteAutos.Add(new Auto("YFG2100", "Volkswagen", "Golf", "Azul", 2000, 65000));
            loteAutos.Add(new Auto("YUH2010", "Toyota", "Corolla", "Blanco", 2005, 90000));
            loteAutos.Add(new Auto("YAT1101", "Honda", "Civic", "Gris plata", 2010, 98000));

            // Se lista el contenido del contenedor como se encuentra
            foreach (Auto auto in loteAutos)
            {
                Console.WriteLine(auto);
            }
            Console.WriteLine("");

            // Ordenar por placa
            loteAutos.Sort(new OrdenarPorPlaca());
            // Se lista el contenido del contenedor como se encuentra
            foreach (Auto auto in loteAutos)
            {
                Console.WriteLine(auto);
            }
            Console.WriteLine("");

            // Ordenar por modelo
            loteAutos.Sort(new OrdenarPorModelo());
            // Se lista el contenido del contenedor como se encuentra
            foreach (Auto auto in loteAutos)
            {
                Console.WriteLine(auto);
            }
            Console.WriteLine("");

            // Ordenar por precio descendente
            loteAutos.Sort(new OrdenarPorPrecioDescendente());
            // Se lista el contenido del contenedor como se encuentra
            foreach (Auto auto in loteAutos)
            {
                Console.WriteLine(auto);
            }
            Console.WriteLine("");

            // Ordenar por precio ascendente
            loteAutos.Sort(new OrdenarPorPrecioAscendente());
            // Se lista el contenido del contenedor como se encuentra
            foreach (Auto auto in loteAutos)
            {
                Console.WriteLine(auto);
            }
            Console.WriteLine("");

        }

    }   // END class



    class Auto
    {
        private string placa;
        public string Placa
        {
            get { return placa; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
        }

        private string color;
        public string Color
        {
            get { return color; }
        }

        private int año;
        public int Año
        {
            get { return año; }
        }

        private double precio;
        public double Precio
        {
            get { return precio; }
        }


        public Auto(
            string placa, 
            string marca, 
            string modelo, 
            string color, 
            int año, 
            double precio
            )
        {
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.año = año;
            this.precio = precio;
        }


        public override string ToString()
        {
            return placa + " " +
                marca + "\n" + 
                modelo + " " + 
                color + " " +
                año + " " + 
                precio;
        }


    }   // END class


    /** 
     * Su lógica de funcionamiento requiere indicaciones de cómo se ordenan dos de los valores
     * que ingresarán al SortedList, y el método Sort lo aplicará a todo el conjunto de elementos
     * dentro de la colección.
     * 
     * * */
    // se definen 4 comparadores
    // de menor a mayor y de mayor a menor

    // Comparador por placa
    class OrdenarPorPlaca : IComparer<Auto>
    {
        public int Compare( Auto auto1, Auto auto2 )
        {
            // Comparación alfanumérica donde A es menor que B
            // Si son iguales, se regresa un cero
            // Si auto1 es mayor que auto2, regresa positivo que indica que no deben cambiar de posición.
            // Si auto1 es menor que auto2, regresa un numero negativo que indica que deben intercambiar.
            return auto1.Placa.CompareTo( auto2.Placa );
        }
    }   // END class


    // Comparador por modelo
    class OrdenarPorModelo : IComparer<Auto>
    {
        public int Compare(Auto auto1, Auto auto2)
        {
            // En las cadenas se utiliza el método compareTo, de las que devuelve un -1, +1 o cero
            return auto1.Modelo.CompareTo(auto2.Modelo);
        }
    }   // END class


    // Comparador por precio descendente
    class OrdenarPorPrecioDescendente : IComparer<Auto>
    {
        public int Compare(Auto auto1, Auto auto2)
        {
            int precio1 = System.Convert.ToInt32( auto1.Precio );
            int precio2 = System.Convert.ToInt32( auto2.Precio );
            return precio1 - precio2;
        }
    }   // END class


    // Comparador por precio ascendente
    class OrdenarPorPrecioAscendente : IComparer<Auto>
    {
        public int Compare(Auto auto1, Auto auto2)
        {
            int precio1 = System.Convert.ToInt32(auto1.Precio);
            int precio2 = System.Convert.ToInt32(auto2.Precio);
            return precio2 - precio1;
        }
    }   // END class


    // Comparador por año
    //  Es importante notar que se debe devolver un valor positivo o negativo,
    //  no importa el número en sí
    class OrdenarPorAño : IComparer<Auto>
    {
        public int Compare(Auto auto1, Auto auto2)
        {
            return auto1.Año - auto2.Año;
        }
    }   // END class


}
