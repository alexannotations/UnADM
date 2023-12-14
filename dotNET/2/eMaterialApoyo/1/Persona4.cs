/**
 * UnADM net2 u2 pp 12-13
 * Clases sealed
 * 
 * una clase sellada indica que ésta no puede usarse como base en una jerarquía de herencia
 * debe ser la última en la jerarquía lineal
 * una clase abstracta no puede ser sellada
 * 
 * una jerarquía de clases no tiene por qué seguir una jerarquía organizacional
 * */

using System;

namespace Herencia
{
    // 
    abstract class Persona4
    {
        protected string nombre;
        protected char sexo;
        protected int edad;

        public Persona4(string nombre, char sexo, int edad)
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


        public abstract void identificacion();

    }


    class Docente4:Persona4
    {
        private int tarjeta;
        public Docente4(string nombre, char sexo, int edad, int tarjeta) : base(nombre,sexo,edad)
        {
            this.tarjeta=tarjeta;
        }

        public void informacionTotal()
        {
            informacion();
            System.Console.WriteLine("Tarjeta: "+tarjeta);
        }


        public override void identificacion()
        {
            System.Console.WriteLine("Identificacion con tarjeta numero: "+tarjeta);
        }
    }


    // sealed indica que no puede ser derivada, esta sellada a la jerarquia de herencia
    sealed class Jefe:Docente4
    {
        private string departamento;
        public Jefe(string nombre, char sexo, int edad, int tarjeta, string departamento):
            base(nombre, sexo, edad, tarjeta)
        {
            this.departamento=departamento;
        }

        // la palabra new indica que el metodo informacion() oculta el metodo informacion() de la clase docente
        // Ocultación; cuando se invoque a este método se ejecutará el de la clase derivada y no el de la clase padre.
        new public void informacion()
        {
            System.Console.WriteLine("Nombre: "+nombre);
            System.Console.WriteLine("Sexo: "+sexo);
            System.Console.WriteLine("Edad: "+edad);
            System.Console.WriteLine("Departamento: "+departamento);
        } 
    }


    class Program
    {
        static void Main(string[] args)
        {
            Docente4 d = new Docente4("Luisa","F",30,57);
            d.informacion();
            d.identificacion();

            Jefe j = new Jefe("Angela","M",38,1020,"Sistemas");
            j.informacion();

        }
    }

}