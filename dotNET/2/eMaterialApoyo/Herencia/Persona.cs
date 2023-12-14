using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{

    /**
     * Los miebros (datos y metodos) conservan si visibilidad
     * protected
     * public
     * private; no se heredan a la child class (derivated class)
     * alcance al proyecto actual; no se utiliza para el copntrol de la herencia
     * 
     */
    class Persona
    {
        /* los datos son protected para que sean privados y sea posible heredarlos */
        protected string nombre;
        protected char sexo;
        protected int edad;

        public Persona(string nombre, char sexo, int edad)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad = edad;
        }

        public void showInformacion()
        {
            System.Console.WriteLine("\n" + "Nombre: " + nombre);
            System.Console.WriteLine("Sexo: " + sexo);
            System.Console.WriteLine("Edad: " + edad);
        }

    }


    /**
     * Los dos puntos especifican el concepto de herencia
     * En este caso Docente hereda de Persona
     * En C# un constructor no se hereda, pese a ser publico y 
     * necesita ser llamado explicitamente desde la child class con 'base'
     * con los argumentos entre parentesis que se le envian en tipo y posicion
     */
    class Docente : Persona
    {
        private int tarjeta;

        /* herencia; child constructor llama al parent constructor con el comando base
         * y envia los parametros que recibe
         * Se agrega el atributo tarjeta al constructor
         */
        public Docente(string nombre, char sexo, int edad, int tarjeta) : base(nombre, sexo, edad)
        {
            this.tarjeta = tarjeta;
        }


        /** 
         * Si se sobreescribe un metodo, cuando se invoca se llama a este ultimo
         */
        //public void showInformacion()
        //{
        //    System.Console.WriteLine("\nMetodo sobreescrito: ");
        //}

        public void showInformacionTotal()
        {
            showInformacion();
            System.Console.WriteLine("Tarjeta: " + tarjeta);
        }
    }


    /**
     * Una clase sellada se utiliza para impedir la derivacion de la misma, no puede ser abstracta
     * para indicarlo se usa la palabra reservada sealed, la cual sella la jeraquia de herencia
     */
    sealed class Jefe : Docente
    {
        private string departamento;
        public Jefe(string nombre, char sexo, int edad, int tarjeta, string departamento) : 
            base(nombre, sexo, edad, tarjeta)
        {
            this.departamento = departamento;
        }

        /* La palabra new indica que el método showInformacion() oculta el método showInformacion()
         * de la clase base Persona. Se puede heredar una clase sin que implique que las clases child
         * herede sus miembros tal cual, sino con ligeras modificaciones. Por lo que se ejecutara 
         * el metodo de la clase derivada */
        new public void showInformacion() {
            System.Console.WriteLine("\n" + "Nombre: " + nombre);
            System.Console.WriteLine("Sexo: " + sexo);
            System.Console.WriteLine("Edad: " + edad);
            System.Console.WriteLine("Departamento: " + departamento);
        }
    }

}
