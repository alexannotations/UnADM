using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{

    /** 
     * “el propósito de una clase abstracta es proporcionar una definición común 
     * de una clase base que múltiples clases derivadas pueden compartir
     * 
     * La palabra clave abstract permite crear clases únicamente con propósitos de herencia, 
     * pero estas no se pueden instanciar
     */
    internal abstract class C_Abstracta
    {
        // NO se puede crear una instancia de la clase abstracta, marca error
        // Persona_es_Abstracta persona = new Persona_es_Abstracta("Isabel", 'M', 33);

    }

    /**
     * La clase Felino es una clase abstracta porque en el mundo real no existe un ente específico llamado felino
     * Por lo tanto no se debe instanciar y como consecuencia no se utilice.
     * 
     */
    abstract class Felino
    {
        /**
         * Sin ser necesario, una clase abstracta puede tener metodos miembros abstractos
         * Un miembro abstracto puede ser heredado (public & protected) e indica que debe ser implementado, sin indicarlo
         */

    }

    /**  
     * Un gato "es un" felino
     * Por lo tanto se puede instanciar
     */
    class Gato : Felino
    {

    }

    /** 
     *  
     */
    abstract class Persona_es_Abstracta
    {
        /* los datos son protected para que sean privados y sea posible heredarlos */
        protected string nombre;
        protected char sexo;
        protected int edad;

        public Persona_es_Abstracta(string nombre, char sexo, int edad)
        {
            this.nombre = nombre;
            this.sexo = sexo;
            this.edad = edad;
        }

        // Miembro abstracto, definición sin implementar.
        // indica que toda clase que herede debe implementarlo
        public abstract void identificacion(); 

        public void showInformacion()
        {
            System.Console.WriteLine("\n" + "Nombre: " + nombre);
            System.Console.WriteLine("Sexo: " + sexo);
            System.Console.WriteLine("Edad: " + edad);
        }

    }

    class Administrativo : Persona_es_Abstracta
    {
        private int tarjeta;

        public Administrativo(string nombre, char sexo, int edad, int tarjeta) : base(nombre, sexo, edad)
        {
            this.tarjeta = tarjeta;
        }

        // metodo abstracto implementado
        // debe incluir la palabra reservada override
        // Se indica que el metodo tendra codigo para realizar lo solicitado en esta clase
        public override void identificacion()
        {
            Console.WriteLine("Tarjeta: " + tarjeta);
        }

        public void showAllInfo()
        {
            showInformacion();
            identificacion();
        }
    }
}
