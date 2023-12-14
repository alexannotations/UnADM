namespace _23net2_u1_a1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.WriteLine("Pokémon TCG - abstracción de carta\n");
                Console.WriteLine("Selecione una carta.\n1 Hatterene\n2 Hawlucha\n3 Drampa\n4 Raichu\n5 Eevee\n6 Gardevoir\n0 Salir\n");

                string input = Console.ReadLine();
                option = int.Parse(input);

                switch (option)
                {
                    case 1:
                        Hatterene();
                        break;
                    case 2:
                        Hawlucha();
                        break;
                    case 3:
                        Drampa();
                        break;
                    case 4:
                        Raichu();
                        break;
                    case 5:
                        Eevee();
                        break;
                    case 6:
                        Gardevoir();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opción no valida.");
                        break;
                }
            } while (option!=0);

        }

        public static void Hatterene() 
        {
            Carta hatterene = new Carta("Hatterene","2","Hattrem","hatterene.png","altura: 2.1m. peso 5.1kg",
                "Rondó de Hechicera", "2","Oscura","chibi","oscuridad incandescente","1","73","rare holo","Recibe el apodo de hechicera del bosque",
                "1","-30","Este ataque hace 50 puntos de daño mas por cada energia unida al pokemon activo de tu rival","30", "psiquico", "psiquico", "130");
            hatterene.showAllInfo();
            hatterene.Colocar();
            hatterene.Ataca();
        }

        public static void Hawlucha() {
            Carta hatterene = new Carta("Hawlucha", "Basico", null, "hawlucha.png", "altura: 0.8m. peso 21.5kg",
        "Entrada voladora", "2", "Psiquico", "Gossan", "", "", "118", "rare holo", "Remata a sus rivales con elegancia",
        "0", "", "", "70", "Ataque ala", "lucha", "70");
            hatterene.showAllInfo();
            hatterene.Colocar();
            hatterene.Ataca();
        }

        public static void Drampa() {
            Carta hatterene = new Carta("Drampa", "Basico", null, "drampa.png", "",
        "Robo pico", "2", "Lucha", null, "pulso dragon", "1", "128", "", "",
        "0", "", "Descarta las 2 primeras cartas de tu baraja", "20", "lucha", "lucha", "210");
            hatterene.showAllInfo();
            hatterene.Colocar();
            hatterene.Ataca();
        }

        public static void Raichu() {
            Carta hatterene = new Carta("Raichu", "1", "Pikachu", "raichu.png", "",
        "Trueno", "2", "Rayo", "CG works", "colavoltio", "1", "29", "", "",
        "1", "-20", "El pokemon activo de tu rival pasa a estar paralizado", "120", "rayo", "rayo", "29");
            hatterene.showAllInfo();
            hatterene.Colocar();
            hatterene.Ataca();
        }

        public static void Eevee() {
            Carta hatterene = new Carta("EeveeV", "2", null, "eevee.png", "",
        "Coleccionar", "2", "Normal", "Kogemany", "065", "1", "73", "", "",
        "1", "-80", "Roba 3 cartas", "", "lucha", "normal", "190");
            hatterene.showAllInfo();
            hatterene.Colocar();
            hatterene.Ataca();
        }

        public static void Gardevoir() {
            Carta hatterene = new Carta("Gardevoir ex", "2", "Kirlia", "gardevoir.png", "",
        "Abrazo psiquico", "2", "Psiquico", "n de sign inc.", "Fuerza milagrosa", "2", "86", "rare", "Todas las veces que quieras durante tu turno, puedes unir 1 carta de energia",
        "2", "-30", "Este pokemon se recupera de todas las condiciones esoroo", "30", "psiquico", "psiquico", "310");
            hatterene.showAllInfo();
            hatterene.Colocar();
            hatterene.Ataca();
        }

    }
}