/* DPRN2_U1_A1_ALAC */

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("YuGi-Oh - abstracción de carta\n");
            Console.WriteLine("Selecione una opción.\n0 Mago\n1 Oraculo\n2 Flores\n3 Dragon\n4 Insecto\n");

            string input= Console.ReadLine();
            option = int.Parse(input);

            switch (option)
            {
                case 0:
                    Mago();
                    break;
                case 1:
                    Oraculo();
                    break;
                case 2:
                    Flores();
                    break;
                case 3:
                    Dragon();
                    break;
                case 4:
                    Insecto();
                    break;
                default: Console.WriteLine("Opción no valida.");
                    break;
            }

        }

        public static void Mago()
        {
            Carta mago = new Carta("Mago Oscuro", "lanzador de conjuros", "El más grande de los magos en cuanto al ataque y la defensa.", 7, 2500, 2100, 0);
            mago.showAllInfo();
            mago.Ataca();
            mago.Defiende();
            mago.setStatus("ataque");
            Console.WriteLine("\n");
        }

        public static void Oraculo()
        {
            Carta oraculo = new Carta("Mahad el oraculo paladio", "Lanzador de conjuros", "Efecto", 1, 2500, 2100, 1, "Puedes invocar el efecto especial");
            oraculo.showAllInfo();
            oraculo.Ataca();
            oraculo.Defiende();
            oraculo.setStatus("ataque");
            Console.WriteLine("\n");
        }

        public static void Flores()
        {
            Carta flores = new Carta("Flores rojas del bajorraiz", "demonio", "Efecto", 1, 0, 0, 0, "Puede seleccionar Magica/Trampa en cada cementerio");
            flores.showAllInfo();
            flores.Ataca();
            flores.Defiende();
            flores.setStatus("");
            Console.WriteLine("\n");
        }

        public static void Dragon()
        {
            Carta mago = new Carta("Dragón blanco de ojos azules", "dragón", "Legendario dragón.", 8, 3000, 2500, 1);
            mago.showAllInfo();
            mago.Ataca();
            mago.Defiende();
            mago.setStatus("ataque");
            Console.WriteLine("\n");
        }

        public static void Insecto()
        {
            Carta flores = new Carta("\"C\" Maxx", "Insecto", "Efecto", 2, 500, 200, 2, "Roba inmediatamente una carta");
            flores.showAllInfo();
            flores.Ataca();
            flores.Defiende();
            flores.setStatus("");
            Console.WriteLine("\n");
        }
    }
}