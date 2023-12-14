namespace Herencia
{
    internal class Herencia
    {
        static void Main(string[] args)
        {
            // Se utilizan ambos objetos
            Persona persona = new Persona("Isabel",'F',33);
            Docente docente = new Docente("Mayra", 'F', 28, 123456789);     // docente hereda de persona

            persona.showInformacion();
            docente.showInformacion();   // ambos tienen el metodo, pese a que no se implemento en Docente class
            docente.showInformacionTotal();

            // herencia de clase abstracta
            Administrativo administrativo = new Administrativo("Ana", 'F', 22, 987654321);
            administrativo.showInformacion();
            administrativo.identificacion();

            // Sealed class
            Docente docentesealed = new Docente("Luisa",'F',30,57);
            docentesealed.showInformacionTotal();
            //docentesealed.Identificacion();

            Jefe j = new Jefe("Angela",'F',38,1020,"Sistemas");
            j.showInformacion();

            // Previo a interfaces
            Alumno a = new Alumno("Pedro", 'M', 20, "00040101", "Sistemas");
            a.showInformacion();
            Movilidad m = new Movilidad("Donatelo", 'M', 20, "05559091", "Electronica", "Veracruz");
            m.showInformacion();

            // interfaces Alumno y Movilidad
            Alumno ia = new Alumno("Rafael", 'M', 20, "00040101", "Sistemas");
            ia.cambiaCarrera("Mecatronica");
            ia.showInformacion();
            Movilidad im = new Movilidad("Miguel", 'M', 20, "05559091", "Electronica", "Veracruz");
            im.cambiaCarrera("Informatica");
            im.showInformacion();


            // Persona presenta polimorfismo a nivel de objeto como la clase Docente
            // Si se solicitan los metodos que se pueden utiliar en la instancia p, seran los metodos de Docente

            Persona p = new Docente();

            // Lo contrario NO es valido
            //      Docente d = new Persona();


        }
    }


}