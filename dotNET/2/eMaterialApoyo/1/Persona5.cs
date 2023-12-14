/**
 * UnADM net2 u2
 * Interfaces
 * 
 * */

using System;

namespace Herencia
{
    abstract class Persona5
    {
        protected string nombre;
        protected char sexo;
        protected int edad;

        // metodo abstracto
        public abstract void identificacion();

        public Persona5(string nombre, char sexo, int edad)
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


    class Alumno:Persona5
    {
        private string numero;
        private string carrera;

        // El constructor de la clase derivada Alumno llama a su padre con la instrucción base.
        public Alumno(string nombre, char sexo, int edad, string numero, string carrera) : base(nombre,sexo,edad)
        {
            this.numero=numero;
            this.carrera=carrera;
        }

        // Se está ocultando el método Informacion() de la clase padre por un nuevo método, utiliza la palabra reservada new
        new public void informacion()
        {
            System.Console.WriteLine("Nombre: "+nombre);
            System.Console.WriteLine("Sexo: "+sexo);
            System.Console.WriteLine("Edad: "+edad);
            System.Console.WriteLine("N. Contro: "+numero);
            System.Console.WriteLine("Carrera: "+carrera);
        } 

        // se da funcionalidad en la clase hija, al metodo abstracto definido en la clase padre
        public override void identificacion()
        {
            System.Console.WriteLine("Identificacion por numero de control: "+numero);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno("Luisa","F",13,2023,"Ingenieria");
            a.informacion();

        }

    }
}