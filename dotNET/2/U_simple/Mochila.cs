/** 
 * Alejandro Ayala Castro
 * Grupo: DS-DPRN2-2302-B2-002
 * 
 */
using System;

namespace _23net2_u1_a
{
    internal class Mochila
    {
        // atributos o campos encapsulados
        private string color;
        private int capacidad;
        private string material;
        private string[]? items;

        /** 
         * las propiedades (getters y setters) los integran indirectamente 
         * Descriptores de acceso
         * representan el atributo que usa la forma de ocultacion entre entidades
         */
        public string Color { get => color; set => color = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Material { get => material; set => material = value; }


        // metodos Constructores
        public Mochila()
        {
            Color = "cafe";
            Material = "tela";
            Capacidad = 10;
            this.items = new string[Capacidad];
        }


        // Construtor sobrecargado que recibe parametros 
        public Mochila(int capacidad, string material)
        {
            Capacidad = capacidad;
            Material = material;
            Color = "plata";
            this.items = new string[capacidad];
        }

        // finalizador o destructor
        ~Mochila()  
        { 
            /* declaraciones de limpieza ... */ 
            Console.WriteLine("El objeto Mochila ha sido finalizado");
        }


        // Otros metodos 
        // metodo para guardar un item en determinada posicion
        public void guardar(string item, int posicion)
        {
            items[posicion] = item;
        }

        /** Metodo sobrecargado que recibe varios items */
        public void guardar(string[] items)
        {
            this.items = items;
        }

        // retirar un item de la mochila
        public string? sacarItem(int posicion)
        {
            return items[posicion];
        }

        // mostrar todos los items
        public void showItems()
        {
            int i = 0;
            Console.WriteLine("En tu mochila hay:\n");
            foreach (var item in items)
            {
                Console.WriteLine(++i +".- " +item + ".");
            }
        }

    }
}
