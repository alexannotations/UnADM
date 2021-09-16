using System;

namespace ActividadComplementaria
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Programación NET1\n AAC\n DPRN1_U3_AC_ALAC");

            // Instanciacion de clases
            Program registro = new Program();
            Alumno estudiante = new Alumno();
            Impresora impresora = new Impresora();
            Almacenamiento caja = new Almacenamiento();

            int switch_on, switch2_on;
            do
            {
                Console.WriteLine("\n\n AC - Registro de alumnos.\n Seleccione una opción: \n\t 1 - Registro de datos de alumno.\n\t 2 - Calculos internos.\n\t 3 - Imprimir información.\n\t 4 - Guardar datos.\n\t 9 - Salir.");
                switch_on = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (switch_on)
                {
                    case 1:
                        
                        //PedirDatosAlumno
                        Console.Write("Introduzca los datos conforme se solicitan. \n\t Nombre: ");
                        estudiante.Nombre = Console.ReadLine();
                        Console.Write("\t Edad: ");
                        estudiante.Edad = int.Parse(Console.ReadLine());
                        Console.Write("\t Sexo: (f/m)");
                        estudiante.Sexo = char.Parse(Console.ReadLine());
                        Console.Write("\t Fecha de Nacimiento: ");
                        estudiante.SetFechaNacimiento(Console.ReadLine());      // Observe que es diferente la invocacion del metodo Setter
                        Console.Write("\t VacunaCOVID: ");
                        estudiante.SetVacunaCOVID(Console.ReadLine());
                        Console.Write("\t Email: ");
                        estudiante.Email = Console.ReadLine();
                        Console.Write("\t Boleta en Texto Binario: ");
                        estudiante.BoletaTextBinario = Console.ReadLine();
                        Console.Write("\t Numero Positivo de la Suerte: ");
                        estudiante.NumeroSuerte = int.Parse(Console.ReadLine());

                        //Mostrar datos alumno
                        Console.Clear();
                        Console.WriteLine("Los datos capturados son:");
                        Console.WriteLine($"Nombre: {estudiante.Nombre}");
                        Console.WriteLine($"Edad: {estudiante.Edad}");
                        Console.WriteLine($"Sexo: {estudiante.Sexo}");
                        Console.WriteLine($"Fecha de Nacimiento: {estudiante.GetFechaNacimiento().ToLongDateString()}");
                        Console.WriteLine($"Vacuna COVID: {estudiante.VacunaCOVID}");
                        Console.WriteLine($"Correo electronico: {estudiante.Email}");
                        Console.WriteLine($"Boleta: {estudiante.BoletaTextBinario}");
                        Console.WriteLine($"Numero de la suerte: {estudiante.NumeroSuerte}");

                        break;


                    case 2:

                        break;


                    case 3:
                        Console.Clear();
                        Console.WriteLine("Imprimir información\n\n Seleccione una opción: \n\t 1 - Mostrar registro de alumno.\n\t 2 - Mostrar calculos internos.");
                        switch2_on = int.Parse(Console.ReadLine());

                        switch (switch2_on)
                        {
                            case 1:
                                impresora.MostrarRegistro();
                                break;

                            case 2:
                                impresora.MostrarCalculos();
                                break;

                            default:
                                Console.WriteLine($"La opción ({switch2_on}) no es valida.", switch_on);
                                break;
                        }
                        break;


                    case 4:
                        Console.WriteLine("Funcion simulada. Tema por aprender.");
                        caja.GuardarDatos(1);
                        break;

                    case 9:
                        Console.WriteLine("Saliendo.");
                        break;

                    default:
                        Console.WriteLine($"La opción ({switch_on}) no es valida.", switch_on);
                        break;
                }
            } while (switch_on != 9);
        }


        public void PedirDatosAlumno() { }

        public void MostrarRegistro() { }


    }
}
