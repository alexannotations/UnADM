/**
 * UnADM net2 u2 pp 12-14
 * Herencia simple
 * */

using System;

namespace Herencia
{
    class Persona2
    {
        // Se deben proteger los datos.
        // Para heredarlos deben ser protegidos
        protected string nombre;
        protected char sexo;
        protected int edad;

        // “Un constructor a pesar de ser un método público es el único que no se hereda y
        // necesita ser llamado explícitamente desde la clase hija por la palabra base, con los 
        // argumentos entre paréntesis que se le envían” (Troelsen, 2010, p. 229).

        public Persona2(string nombre, char sexo, int edad)
        {
            this.nombre=nombre;
            this.sexo=sexo;
            this.edad=edad;
        }

        public void informacion()
        {
            System.Console.WriteLine("Nombre: "+nombre);
            System.Console.WriteLine("Sexo: "+sexo);
            System.Console.WriteLine("Edad: "+edad);
        }
    }


    class Docente2:Persona2
    {
        private int tarjeta;
        // Se agrega informacion al objeto, modificando el constructor para que llame al de la clase padre
        // y gurade el nuevo dato.
        // Los parametros enviados deben ser del mismo tipo y numero, el nombre no importa
        public Docente2(string name, char sex, int age, int tarjeta) : base(name,sex,age)
        {
            this.tarjeta=tarjeta;
        }

        // Tiene un nevo metodo que usa un metodo de la clase padre
        public void informacionTotal()
        {
            informacion();
            System.Console.WriteLine("Tarjeta: "+tarjeta);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Persona2 p = new Persona2("Raul","M",34);
            Docente2 d = new Docente2("Luisa","F",30);

            p.informacion();
            d.informacionTotal();

        }

    }
}