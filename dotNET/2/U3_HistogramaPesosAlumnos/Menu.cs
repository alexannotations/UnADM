namespace u3_a3_alac
{
    internal class Menu
    {
        public static void showMenu(string title)
        {
            int option;
            string input;


                do
                {
                    Console.WriteLine("\n\n\n\n**********************************************\n" + title + "\n");
                    Console.WriteLine("Selecione una opción." +
                        String.Join("", Repositorio.opciones) +
                        "\n 0 Salir\n");

                    input = Console.ReadLine();
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


                        case 0:
                            Console.WriteLine("END");
                            break;
                        default:
                            Console.WriteLine("Opción no valida.");
                            break;
                    }
                } while (option != 0) ;

        }   // end showMenu

        static void opcion1()
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n\t\t\t\t 1 ");
            Repositorio.ro1();

        } // end opcion 1

        static void opcion2()
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n\t\t\t\t 2 ");
            Repositorio.ro2();

        } // end opcion 2

        static void opcion3()
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n\t\t\t\t 3 ");
            Repositorio.ro3();

        } // end opcion 3

        static void opcion4()
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n\t\t\t\t 4 ");
            Repositorio.ro4();

        } // end opcion 4

    }
}
