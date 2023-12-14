/**
 * UnADM net2 u2 pp 12-13
 * Clases abstractas
 * 
 * 
 * */

using System;

namespace Herencia
{
    // clase abstracta no se puede instanciar
    // Una clase abstracta puede heredarse por otra abstracta. 
    // Significa que ninguna de ellas puede instanciarse
    abstract class Persona3
    {
        protected string nombre;
        protected char sexo;
        protected int edad;

        public Persona3(string nombre, char sexo, int edad)
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

        // metodo abstracto, solo puede ser public o protected 
        // con la intencion de que se herede y defina su comportamiento
        public abstract void identificacion();
        // si se desea heredar una clase abstracta a otra clase abstracta
        //      - se vuelve a declarar como metodo abstracto (se reescribe como habia sido definida en la clase base)
        //      - sobreescribirla para darle funcionalidad
    }


    class Docente3:Persona3
    {
        private int tarjeta;
        public Docente3(string nombre, char sexo, int edad, int tarjeta) : base(nombre,sexo,edad)
        {
            this.tarjeta=tarjeta;
        }

        public void informacionTotal()
        {
            informacion();
            System.Console.WriteLine("Tarjeta: "+tarjeta);
        }

        // se implementa la funcionalidad del metodo abstracto
        // observe que se incluye la palabra reservada override
        public override void identificacion()
        {
            System.Console.WriteLine("Identificacion con tarjeta numero: "+tarjeta);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Docente3 d = new Docente3("Luisa","F",30,57);

            d.informacion();
            d.identificacion();

        }
    }

}