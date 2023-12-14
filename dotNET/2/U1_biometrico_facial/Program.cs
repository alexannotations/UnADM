/**
 * Alejandro Ayala Castro
 * octubre 2023
 * 
 */

namespace DPRN2_U1_EA_ALAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test.testColor();
            showMenu();
        }

        static void showMenu()
        {
            int option;
            do
            {
                Console.WriteLine("\n\n\n\n**********************************************\n" +
                    "BioTech - Reconocimiento facial\n");
                Console.WriteLine("Selecione una opción." +
                    "\n1 Identificar el mismo rostro Ejemplo1 (ambos algoritmos)" +
                    "\n2 Identificar el mismo rostro Ejemplo2 (ambos algoritmos)" +
                    "\n3 Comparar dos rostros diferentes Ejemplos 1 y 2 (ambos algoritmos)" +
                    "\n4 Dar de alta un rostro" +
                    "\n5 Seleccionar los rostros a comparar" +
                    "\n6 Simular envejecimiento" +
                    "\n9 Mostrar datos de los rostros almacenados." +
                    "\n0 Salir\n");

                string input = Console.ReadLine();
                option = int.Parse(input);

                switch (option)
                {
                    case 1:
                        opcion1();
                        break;

                    case 2:
                        opcion2();
                        break;

                    case 3:
                        opcion3();
                        break;

                    case 4:
                        opcion4();
                        break;

                    case 5:
                        opcion5();
                        break;

                    case 6:
                        opcion6();
                        break;

                    case 9:
                        opcion9();
                        break;

                    case 0:
                        Console.WriteLine("END");
                        break;
                    default:
                        Console.WriteLine("Opción no valida.");
                        break;
                }
            } while (option != 0);
        }   // end showMenu

        static void opcion1() 
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n1 Identificar el mismo rostro Ejemplo1 (ambos algoritmos)");
            // se usa el metodo constructor que acepta 2 parametros Rostro
            ReconocimientoFacial comparacionE1 = new ReconocimientoFacial(RepositorioFacial.rostroE1, RepositorioFacial.rostroE1);
            // Se ejecutan ambos algoritmos y se muestran los resultados
            comparacionE1.algoritmoUno();
            comparacionE1.resultadoDeIdentificacion();
            comparacionE1.algoritmoDos();
            comparacionE1.resultadoDeIdentificacion();
        }

        static void opcion2() 
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n2 Identificar el mismo rostro Ejemplo2 (ambos algoritmos)");
            // se usa el metodo constructor que acepta un array de parametros Rostro
            ReconocimientoFacial comparacionE2 = new ReconocimientoFacial(new Rostro[] { RepositorioFacial.rostroE2, RepositorioFacial.rostroE2 });
            comparacionE2.algoritmoUno();
            comparacionE2.resultadoDeIdentificacion();
            comparacionE2.algoritmoDos();
            comparacionE2.resultadoDeIdentificacion();
        }

        static void opcion3() 
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n3 Identificar rostros con Ejemplo1 y Ejemplo2 (ambos algoritmos)");
            // se crea un arreglo de 2 objetos Rostro
            Rostro[] arregloRostros = new Rostro[] { RepositorioFacial.rostroE1, RepositorioFacial.rostroE2 };
            // se usa el metodo constructor que acepta un array de parametros Rostro
            ReconocimientoFacial comparacionAmbosEjemplos = new ReconocimientoFacial(arregloRostros);
            comparacionAmbosEjemplos.algoritmoUno();
            comparacionAmbosEjemplos.resultadoDeIdentificacion();
            comparacionAmbosEjemplos.algoritmoDos();
            comparacionAmbosEjemplos.resultadoDeIdentificacion();
        }

        static void opcion4()
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n4 Capturar rostros y mostrar informacion capturada\n");
            Console.WriteLine("¿Que rostro desea capturar? 1 ó 2 ");
            int capturaRostro = int.Parse(Console.ReadLine());

            if ( capturaRostro == 1 || capturaRostro == 2 ) {
                RepositorioFacial.RostroCapturado[capturaRostro-1] = RepositorioFacial.capturarRostro();
                RepositorioFacial.RostroCapturado[capturaRostro-1].mostrarDatosRostro();
            }
            else { 
                Console.WriteLine("Opción no valida");
            }
        }

        static void opcion5() 
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n5 Seleccionar rostros a comparar y ejecutar algoritmos");
            Console.WriteLine("\nQue rostros desea comparar." +
                                "\nSelecione dos opciones de rostro" +
                                "\n\t1 Rostro capturado por el usuario" +
                                "\n\t2 Rostro capturado por el usuario" +
                                "\n\t3 Primer ejemplo del repositorio" +
                                "\n\t4 Segundo ejemplo del repositorio" +
                                "\n Considere que primero debe capturar los rostros del usuario para compararlos"
                                );
            Console.WriteLine("Ingrese DOS numeros separadas por una coma (1,2,3,4): ");

            // Tambien funciona sin new Rostro[]    ||  Rostro[] rostros = new Rostro[]
            Rostro[] rostros = 
            {
                RepositorioFacial.RostroCapturado[0],
                RepositorioFacial.RostroCapturado[1],
                RepositorioFacial.rostroE1,
                RepositorioFacial.rostroE2
            };
            ReconocimientoFacial? comparacionOpciones=null;

            string[] opciones = Console.ReadLine().Split(',');  // captura la stdInput, separa los valores por la coma y asigna al array sin la coma
            Array.Sort(opciones); // Se ordenan
            int[] opcionesInt = new int[opciones.Length];
            for (int i = 0; i < opciones.Length; i++)
                opcionesInt[i] = int.Parse(opciones[i]);


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (opcionesInt[0]==i+1 && opcionesInt[1] == j+1)
                    {
                        comparacionOpciones = new ReconocimientoFacial(rostros[i], rostros[j]);
                        comparacionOpciones.algoritmoUno();
                        comparacionOpciones.resultadoDeIdentificacion();
                        comparacionOpciones.algoritmoDos();
                        comparacionOpciones.resultadoDeIdentificacion();
                        break;
                    }
                }
            }
        }   // end opcion 5

        static void opcion6()
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n6 Simular envejecimiento");
            Console.WriteLine("Seleccione el rostro a trabajar [1-4]: ");
            int opcionRostro = int.Parse(Console.ReadLine());
            Rostro rostro6= getRostro(opcionRostro);

            // Se simula el envejecimiento con parametros ya definidos

            Console.WriteLine("\n\t1 Color de piel");
            rostro6.SimularEnvejecimiento(10.5);

            Console.WriteLine("\n\t2 Edad");
            rostro6.SimularEnvejecimiento(60);

            Console.WriteLine("\n\t3 Rasgos faciales");
            rostro6.SimularEnvejecimiento("manchas");
        }

        static void opcion9() 
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n9 Mostrar todos los rostros guardados");
            // Rostros de ejemplo proporcionados en la actividad
            Console.WriteLine("\nDatos de rostro de Ejemplo1");
            RepositorioFacial.rostroE1.mostrarDatosRostro();
            Console.WriteLine("\nDatos de rostro de Ejemplo2");
            RepositorioFacial.rostroE2.mostrarDatosRostro();
            // Rostros capturados por el usuario
            for (int i = 0; i < RepositorioFacial.RostroCapturado.Length; i++)
            {
                Console.WriteLine($"\nDatos de rostro Capturado {i+1}");
                if (RepositorioFacial.RostroCapturado[i] != null)       // Verificamos si el Rostro tiene datos
                    RepositorioFacial.RostroCapturado[i].mostrarDatosRostro();  // Objeto Rostro tomado del repositorio
                else
                    Console.WriteLine("NO se ha capturado el Rostro");
            }

        }

        static Rostro getRostro(int option)
        {
            if (option == 1)
                return RepositorioFacial.RostroCapturado[0];
            if (option == 2)
                return RepositorioFacial.RostroCapturado[1];
            if (option == 3)
                return RepositorioFacial.rostroE1;
            if (option == 4)
                return RepositorioFacial.rostroE2;
            else
                return RepositorioFacial.RostroCapturado[0];
        }



    }
}