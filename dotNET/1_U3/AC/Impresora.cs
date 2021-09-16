using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadComplementaria
{
    class Impresora
    {
        

        public void MostrarRegistro()
        {
            Alumno estudiante = new Alumno();
            // Utiliza los Getters de la clase Alumno
            Console.WriteLine($"Nombre: {estudiante.Nombre}");
            Console.WriteLine($"Edad: {estudiante.Edad}");
            Console.WriteLine($"Sexo: {estudiante.Sexo}");
            Console.WriteLine($"Fecha de Nacimiento: {estudiante.GetFechaNacimiento()}");
            Console.WriteLine($"Vacuna COVID: {estudiante.VacunaCOVID}");
            Console.WriteLine($"Correo electronico: {estudiante.Email}");
            Console.WriteLine($"Boleta: {estudiante.BoletaTextBinario}");
            Console.WriteLine($"Numero de la suerte: {estudiante.NumeroSuerte}");
            
        }

        public void MostrarCalculos()
        {

        }


    }
}
