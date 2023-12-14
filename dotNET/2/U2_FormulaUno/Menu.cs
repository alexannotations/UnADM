namespace FormulaUno
{
    internal class Menu
    {
        public static void showMenu()
        {
            int option;
            do
            {
                Console.WriteLine("\n\n\n\n**********************************************\n" +
                    "Formula Uno - Organigrama\n");
                Console.WriteLine("Selecione una opción." +
                    "\n1 Director de equipo" +
                    "\n2 Piloto" +
                    "\n3 Jefe técnico" +
                    "\n4 Jefe de Diseño" +
                    "\n5 Jefe de Aerodinámica" +
                    "\n6 Ingeniero en Software" +
                    "\n7 Mecánico" +
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

                    case 7:
                        opcion7();
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
            Console.WriteLine("\n---------------------------------\n---------------------------------\n1 ");
            Console.WriteLine("Director de equipo: ");
            // se crea el objeto e invoca al metodo de mostrar información
                DirectorEquipo directorRed = new DirectorEquipo(110, "RedBull", 
                        "Alejandro Ayala Castro", "Ingeniero Mecánico",
                        "director_red@formulauno.com", "1980-06-22", 
                        "Mexicana", 250000, "Competición", 5);
                directorRed.mostrarInformacion();
        }

        static void opcion2()
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n2 ");
            Console.WriteLine("•\tPiloto: ");
            // se crea el objeto e invoca al metodo de mostrar información
            Piloto checo = new Piloto(101, "Red Bull Racing",
                    "Sergio Pérez", "Ingeniero",
                    "checo@formulauno.com", "1990-01-26",
                    "Mexicana", 200000, "F1-MX-L", 10);
            checo.mostrarInformacion();
        }

        static void opcion3()
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n3 ");
            Console.WriteLine("•\tJefe técnico: ");
            // se crea el objeto e invoca al metodo de mostrar información
            JefeTecnico chris = new JefeTecnico(111, "Red Bull Racing",
                    "Christian Horner", "Ingeniero Industrial",
                    "chorner@formulauno.com", "1973-11-16",
                    "Inglesa", 205000, "Group Manager");
            chris.mostrarInformacion();
        }

        static void opcion4()
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n4 ");
            Console.WriteLine("•\tJefe de Diseño: ");
            // se crea el objeto e invoca al metodo de mostrar información
            JefeDisegno tom = new JefeDisegno(121, "Red Bull Racing",
        "Tom Matano", "Ingeniero Mecatrónico",
        "tomma@formulauno.com", "1983-08-30",
        "Francesa", 204000, "Diseño aeroespacial");
            tom.mostrarInformacion();
        }

        static void opcion5()
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n5 ");
            Console.WriteLine("•\tJefe de Aerodinámica: ");
            // se crea el objeto e invoca al metodo de mostrar información
            JefeAerodinamica viri = new JefeAerodinamica(131, "Red Bull Racing",
        "Viri Sikorski", "Ingeniero Electrónico",
        "virs@formulauno.com", "1973-05-06",
        "Rusa", 204000, 5);
            viri.mostrarInformacion();
        }   // end opcion 5

        static void opcion6()
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n6 ");
            Console.WriteLine("•\tIngeniero en Software: ");
            // se crea el objeto e invoca al metodo de mostrar información
            IngenieroSoftware salva = new IngenieroSoftware(311, "Red Bull Racing",
        "Salvador Herrero", "Ingeniero en Sistema",
        "salva@formulauno.com", "1989-12-12",
        "Mexicana", 204000, "C#, assembler");
            salva.mostrarInformacion();
        }

        static void opcion7()
        {
            Console.WriteLine("\n---------------------------------\n---------------------------------\n7 ");
            Console.WriteLine("•\tMecánico: ");
            // se crea el objeto e invoca al metodo de mostrar información
            Mecanico josue = new Mecanico(411, "Red Bull Racing",
        "Josúe Llamas", "Ingeniero Mecánico",
        "josue@formulauno.com", "1995-02-27",
        "Mexicana", 204000, "Motores combustión interna");
            josue.mostrarInformacion();
        }

    }
}
