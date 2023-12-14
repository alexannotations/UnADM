/* DPRN2_U1_A1_ALAC */

namespace ConsoleApp1
{
    internal class Carta
    {

        /* atributos o campos encapsulados
         * observe que esta comentados algunos
         * porque no se utilizan dado que las propiedades
         * los integran indirectamente 
         */ 
        //private string name;
        private string _type;
        private string description;
        //private int level;
        //private int atack;
        private int defense;
        //private int element; 
        //private string? efect=null;  // atributo que puede ser nulo al indicarse con ?



        // Métodos miembro

        /** Propiedades (getters y setters)
         * Descriptores de acceso
         * observe que presentan el mismo nombre del atributo pero comienza con mayuscula
         * y se usa la forma de ocultacion entre entidades
         */
        public string Name { get; set; }    // observe que esta variable no se declaro explícitamente en los atributos

        // Se definen unos descriptores de acceso get y set para una propiedad denominada Type.
        // Usa un campo privado denominado _type para respaldar el valor de la propiedad.
        public string Type { get { return _type; } set { _type=value; } }
        
        // se implementan los descriptores de acceso get y set como miembros con forma de expresión.
        public string Description { get => description; set => description = value; }
        
        // se implementa Level como una propiedad implementada automáticamente.
        // aprovechando la compatibilidad del compilador de C#
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Defense { get => defense; set => defense = value; }
        public string Efect { get; set; }
        public int Element { get; set; }
        private string selectElement(int n)
        {
            int atributo = n;
            string[] element = { "oscuridad", "luz", "tierra", "agua", "fuego", "viento" };
            return element[n];
        }



        // metodos Constructores
        /**
         * Constructor que recibe como parametros todos los atributos de la clase
         * Observe que para asignar los parametros recibidos en el constructor 
         * se invoca a los metodos set de cada atributo identificados por comenzar con la letra mayuscula
         */
        public Carta(string name, string type, string description, int level, int attack, int defense, int element, string efect)
        {
            this.Name = name;
            this.Type = type;
            this.Description = description;
            this.Level = level;
            this.Attack = attack;
            this.Defense = defense;
            this.Element = element;
            this.Efect = efect; // efect no debe recibirse como null
        }


        /**
         * Construtor sobrecargado que recibe como parametros los atributos excepto el efecto que puede ser null para algunas cartas
         * se puede reducir codigo al simplificar la llamada a la propiedad quitan la clasificacion this 
         */
        public Carta(string name, string type, string description, int level, int attack, int defense, int element)
        {
            Name = name;
            Type = type;
            Description = description;
            Level = level;
            Attack = attack;
            Defense = defense;
            this.Element = element;
        }

        


        // procedimientos o metodos de uso general
        // No devuelven valores, solo muestran informacion
        public void Ataca() 
        {
            Console.WriteLine("El monstruo " +this.Name +" atacará con "+ this.Attack + " puntos");
        }

        public void Defiende()
        {
            Console.WriteLine("El monstruo {0} defenderá con {1} puntos",Name,this.Defense);
        }

        public void setStatus(string status) 
        {
            string st = status;
            if (st== "ataque")
            {
                Console.WriteLine("La carta "+Name+" fue colocada en Ataque");
            }
            else
            {
                Console.WriteLine("La carta "+Name+" fue colocada en Defensa");
            }
        }

        public void showAllInfo() 
        {
            Console.WriteLine("/*****\nLa carta " + Name + " es;\nTipo: "+Type
                                + "\nNivel: "+Level + "\nAtributo: " + this.selectElement(Element) 
                                + "\nAttack: "+Attack + "\nDefense: " +Defense + "\n" 
                                + Description + "\nEfecto: " + Efect + "\n+++++/");
        }

    }
}
