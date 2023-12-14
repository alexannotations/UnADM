/**
 * UnADM net2 u2 pp 12-13
 * Herencia simple
 * */

using System;

namespace Herencia
{
    class Persona
    {
        // Se deben proteger los datos. Para heredarlos deben ser protegidos
        protected string nombre;
        protected char sexo;
        protected int edad;

        // “Un constructor a pesar de ser un método público es el único que no se hereda y
        // necesita ser llamado explícitamente desde la clase hija por la palabra base, con los 
        // argumentos entre paréntesis que se le envían” (Troelsen, 2010, p. 229).

        public Persona(string nombre, char sexo, int edad)
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


    class Docente:Persona
    {
        // El constructor de la clase Docente llama al constructor padre con el comando base y 
        // envía los parámetros que recibe, los cuales deben ser los mismos en posición y tipo.
        public Docente(string nombre, char sexo, int edad) : base(nombre,sexo,edad)
        {
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Raul","M",34);
            Docente d = new Docente("Luisa","F",30);

            p.informacion();
            d.informacion();

        }

    }
}