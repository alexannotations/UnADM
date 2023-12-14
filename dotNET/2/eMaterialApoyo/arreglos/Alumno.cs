using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos
{
    internal class Alumno
    {
        private string nombre;
        public string Nombre { get {  return nombre; }  }

        private int edad;
        public int Edad { get { return edad; } }    

        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }


    class EjecutarAlumno
    {
        public static void iniciar(string[] args)
        {
            Alumno[] alumno = new Alumno[3];
            string tmp;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Dame el nombre del alumno: " + i + " ");
                string nombre = Console.ReadLine();
                Console.Write("dame la edad del alumno: " + i + " ");
                tmp = Console.ReadLine();
                int edad = Convert.ToInt16(tmp);
                // Se instancia cada elemento por separado
                alumno[i] = new Alumno(nombre, edad);
            }

            int opcion = 0;
            while (opcion != 2)
            {
                Console.WriteLine();
                Console.WriteLine("1.- Mostrar datos de un alumno");
                Console.WriteLine("2.- Terminar");
                Console.Write("Tu opcion: ");
                tmp = Console.ReadLine();
                opcion = Convert.ToInt16(tmp);

                if (opcion == 1)
                {
                    Console.WriteLine("Escribe el indice del alumno: ");
                    tmp = Console.ReadLine();
                    int indice = Convert.ToInt16(tmp);
                    Console.WriteLine("El alumno numero: " + indice);
                    Console.WriteLine("El nombre es: " + alumno[indice].Nombre);
                    Console.WriteLine("LA edad es: " + alumno[indice].Edad);
                }
            }

        }

    }   // 

}
