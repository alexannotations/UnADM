using System;

namespace DPRN2_U1_EA_ALAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iris[] iris = new Iris[2];
            Program program=new Program();
            program.menu(iris);
        }

        public void menu(Iris[] iris) 
        {
            Console.WriteLine("BioTech \n Sistema de Reconocimiento de Iris");
            int option;
            do
            {
                Console.WriteLine("\n\n Seleccione una opción: " +
                    "\n\t 1 - Dar de alta." +
                    "\n\t 2 - Comparar." +
                    "\n\t 3 - Mostrar Iris guardadas." +
                    "\n\t 8 - Test." +
                    "\n\t 9 - Ejemplos." +
                    "\n\t 0 - Salir.");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Bye");
                        break;

                    case 1:
                        Console.WriteLine("Ingrese datos del Iris");
                        for (int i = 0; i < 2; i++) 
                        {
                            iris[i] = new Iris();
                            iris[i] = ingresarIris(i);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Comparar");
                        compararIris(iris);
                        break;

                    case 3:
                        Console.WriteLine("Mostrar datos guardados");
                        for (int i = 0; i < 2; i++)
                            Console.WriteLine(iris[i]);
                        break;

                    case 8:
                        Console.WriteLine("Test");
                        Test.testColor();
                        break;
                    case 9:
                        ejemplo();
                        break;
                    default:
                        Console.WriteLine("Indique una opción.");
                        break;
                }
            } while (option != 0);
        }// end menu()

        public static Iris ingresarIris(int i)
        {

            Console.WriteLine("Ingrese datos "+i+".");
            Console.WriteLine("Patrón textura: ");
            string patronTextura = Console.ReadLine();
            Console.WriteLine("Forma: ");
            string forma = Console.ReadLine();
            Console.WriteLine("Color: ");
            string color = Console.ReadLine();
            Console.WriteLine("Intensidad: ");
            int intensidad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Patrón rayas: (separe con ,)");
            string rayas = Console.ReadLine();
            string[] patronRayas = rayas.Split(',');

            Console.WriteLine("Curvatura: (double, separe con un espacio)");
            string curva = Console.ReadLine();
            string[] curvas = curva.Split(',');
            Console.WriteLine(curvas);

            double[] curvatura = new double[] { 1.1, 1.2, 1.3 };
            //for (int i = 0; i < curvas.Length; i++)
            //{
            //    curvatura[i]= double.Parse(curvas[i]);
            //}
            Iris iris = new Iris(new Color(color, intensidad), patronTextura, forma, patronRayas, curvatura);

            Console.WriteLine("Otros: ");
            string otros = Console.ReadLine();
            iris.Otros = otros;
            return iris;
        }

        public static void compararIris(Iris[] iris)
        {
            ReconocimientoIris reconocimiento = new ReconocimientoIris(iris);
            reconocimiento.algoritmoUno();
            reconocimiento.algoritmoDos();
            reconocimiento.resultadoDeIdentificacion();
        }

        // Ejemplos de uso de las clases
        public static void ejemplo()
        {
            Console.WriteLine("Ejemplos del iris");
            Iris irisCafe = new Iris();
            irisCafe.PatronTextura = "AEECAwQF";
            irisCafe.Forma = "Oval";
            irisCafe.colorIris = new Color("Marrón", 100);
            irisCafe.PatronRayas = new string[] { "A12EC98", "E3960A" };
            irisCafe.Curvatura = new double[] { 1.1, 1.2, 1.3 };
            irisCafe.Otros = "mancha";
            System.Console.WriteLine(irisCafe);

            Iris irisOver = new Iris(new Color("Oliva", 80), "98FE15", "Circular", new string[] { "AAB456", "987ACE" }, new double[] { 1.3, 1.7, 1.5 });
            Console.WriteLine(irisOver);

            irisCafe.simularEnvejecimiento(7);
            irisOver.simularEnvejecimiento(7);
            irisCafe.simularEnvejecimiento("cicatriz");
            irisOver.simularEnvejecimiento("cicatriz");
            double[] numbers = { 1.7, 1.1, 2.0 };
            irisCafe.simularEnvejecimiento(numbers);
            irisOver.simularEnvejecimiento(numbers);
            Console.WriteLine(irisCafe);
            Console.WriteLine(irisOver);

            Console.WriteLine("Ejemplos de Reconocimiento");
            ReconocimientoIris reconocimiento = new ReconocimientoIris(new Iris[] {irisOver,irisCafe});
            reconocimiento.algoritmoUno();
            reconocimiento.algoritmoDos();
            reconocimiento.resultadoDeIdentificacion();

            ReconocimientoIris mismoIris = new ReconocimientoIris(new Iris[] { irisCafe, irisCafe });
            mismoIris.algoritmoUno();
            mismoIris.algoritmoDos();
            mismoIris.resultadoDeIdentificacion();
        }

    }
}