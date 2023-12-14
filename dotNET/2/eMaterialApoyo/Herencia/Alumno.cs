using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    /***/
    class Alumno : Persona_es_Abstracta, IConvenio
    {
        private string numero;
        private string carrera;

        // llama al constructor de la clase padre con 'base', observe que se incluyen los parametros para ambas clases
        public Alumno(string nombre, char sexo, int edad, string numero, string carrera) : base(nombre, sexo, edad)
        {
            this.numero = numero;
            this.carrera = carrera;
        }

        // se da funcionalidad al metodo abstracto de la clase padre
        public override void identificacion()
        {
            System.Console.WriteLine("Identificacion: " + numero);
        }

        // metodo de funcionalidad de la intefaz IConvenio
        public void cambiaCarrera(string nuevaCarrera)
        {
            carrera = nuevaCarrera;
        }

        // se oculta el metodo de la clase padre por un nuevo metodo
        new public void showInformacion()
        {
            System.Console.WriteLine("\n" + "Nombre: " + nombre);
            System.Console.WriteLine("Sexo: " + sexo);
            System.Console.WriteLine("Edad: " + edad);
            System.Console.WriteLine("N. control: " + numero);
            System.Console.WriteLine("Carrera: " + carrera);

        }
    }


    /***/
    class Movilidad : Persona_es_Abstracta, IConvenio
    {
        private string numero;
        private string carrera;
        private string institucion;
        private string oficio;  // para la interface

        public Movilidad(string nombre, char sexo, int edad, string numero, string carrera, string institucion) :
            base(nombre, sexo, edad)
        {
            this.numero = numero;
            this.carrera = carrera;
            this.institucion = institucion;
        }

        // metodo de funcionalidad de la intefaz IConvenio
        public void cambiaCarrera(string nuevaCarrera)
        {
            carrera = nuevaCarrera;
            DateTime x = DateTime.Now;
            oficio = "ORI-" + x.Year + x.Month + x.Day;
            oficio = oficio + "-" + numero;
        }

        public override void identificacion()
        {
            System.Console.WriteLine("Identificacion: " + numero);
        }

        new public void showInformacion()
        {
            System.Console.WriteLine("\n" + "Nombre: " + nombre);
            System.Console.WriteLine("Sexo: " + sexo);
            System.Console.WriteLine("Edad: " + edad);
            System.Console.WriteLine("N. control: " + numero);
            System.Console.WriteLine("Carrera: " + carrera);
            System.Console.WriteLine("Procedencia de: " + institucion);
            System.Console.WriteLine("Cambio de carrera con el oficio: " + oficio);
        }
    }
}
