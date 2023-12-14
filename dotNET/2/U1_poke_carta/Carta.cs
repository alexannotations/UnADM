namespace _23net2_u1_a1
{
    internal class Carta
    {
        // atributos o campos encapsulados
        private string nombre;
        private string fase;
        private string? preEvolucion;     // atributo que puede ser nulo al indicarse con ?
        private string ilustracion;
        private string pokedex;
        private string habilidad;
        private int costeEnergia;  // coste de retirada
        private string debilidad;
        private string? ilustrador;
        private string expansion;
        private string regulacion;
        private int numeroColeccion;
        private string? rareza;
        private string descripcion;
        private string retirada;
        private string resistencia;
        private string descripcionAtaque;
        private string attackDamage;
        private string attack;
        private string tipo;
        private int puntosSalud;
        /** 
         * las propiedades (getters y setters) los integran indirectamente 
         * Descriptores de acceso
         * representan el atributo que usa la forma de ocultacion entre entidades
         */

        public string Nombre { get => nombre; set => nombre = value; }
        public string Fase { get => fase; set => fase = value; }
        public string? PreEvolucion { get => preEvolucion; set => preEvolucion = value; }     // atributo que puede ser nulo al indicarse con ?
        public string Ilustracion { get => ilustracion; set => ilustracion = value; }
        public string Pokedex { get => pokedex; set => pokedex = value; }
        public string Habilidad { get => habilidad; set => habilidad = value; }
        public int CosteEnergia { get => costeEnergia; set => costeEnergia = value; }
        public string Debilidad { get => debilidad; set => debilidad = value; }
        public string? Ilustrador { get => ilustrador; set => ilustrador = value; }
        public string Expansion { get => expansion; set => expansion = value; }
        public string Regulacion { get => regulacion; set=> regulacion = value; }
        public int NumeroColeccion { get => numeroColeccion; set => numeroColeccion = value; }
        public string? Rareza { get => rareza; set => rareza = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Retirada { get => retirada; set => retirada = value; }
        public string Resistencia { get => resistencia; set => resistencia = value; }
        public string DescripcionAtaque { get => descripcionAtaque; set => descripcionAtaque = value; }
        public string AttackDamage { get => attackDamage; set => attackDamage = value; }
        public string Attack { get { return attack; } set { attack = value; } }     // otra forma de obtener/asignar las propiedades
        public string Tipo { get => tipo; set => tipo = value; }
        public int PuntosSalud { get => puntosSalud; set => puntosSalud = value; }


        // metodos Constructores
        /**
         * Constructor que recibe como parametros todos los atributos de la clase
         * Para asignar los parametros recibidos en el constructor 
         * se invoca a los metodos set de cada atributo 
         * identificados por comenzar con la letra mayuscula
         */
        public Carta(string nombre, string fase, string preevolucion, string ilustracion, string pokedex,
                        string habilidad, string costeenergia, string debilidad, string ilustrador,
                        string expansion, string regulacion, string numerocoleccion, string rareza,
                        string descripcion, string retirada, string resistencia, string descripcionataque,
                        string attackdamage, string attack, string tipo, string puntossalud)
        {
            // instrucciones del método constructor
            this.nombre = nombre;
            Fase = fase;
            PreEvolucion = preevolucion;
            Ilustracion = ilustracion;
            Pokedex = pokedex;
            Habilidad = habilidad;
            CosteEnergia = Convert.ToInt32(costeenergia);
            Debilidad = debilidad;
            Ilustrador = ilustrador;
            Expansion = expansion;
            Regulacion = regulacion;
            NumeroColeccion = Convert.ToInt32(numerocoleccion);
            Rareza = rareza;
            Descripcion = descripcion;
            Retirada = retirada;
            Resistencia = resistencia;
            DescripcionAtaque = descripcionataque;
            AttackDamage = attackdamage;
            Attack = attack;
            Tipo = tipo;
            PuntosSalud = Convert.ToInt32(puntossalud);
        }


        /**
         * Construtor sobrecargado que recibe como parametros los atributos excepto PreEvolucion y Fase que puede ser null para algunas cartas
         * se puede simplificar la llamada a la propiedad clasificacion this 
         * 
         */
        public Carta(string nombre, string habilidad, int costeenergia, string debilidad,
                        string regulacion, int numerocoleccion, string descripcion,
                        string retirada, string resistencia, string attackdamage,
                        string attack, string tipo, int puntossalud)
        {
            // instrucciones del método constructor
            Nombre = nombre;
            Fase = "basico";
            Ilustracion = "N/D";
            Pokedex = "Pokémon";
            Habilidad = habilidad;
            CosteEnergia = costeenergia;
            Debilidad = debilidad;
            Ilustrador = "N/D";
            Expansion = "Básico";
            Regulacion = regulacion;
            NumeroColeccion = numerocoleccion;
            Rareza = null;
            Descripcion = descripcion;
            Retirada = retirada;
            Resistencia = resistencia;
            DescripcionAtaque = "Un ataque físico";
            AttackDamage = attackdamage;
            Attack = attack;
            Tipo = tipo;
            PuntosSalud = puntossalud;
        }

        // procedimientos o metodos de uso general
        // No devuelven valores, solo muestran informacion
        public void Ataca()
        {
            Console.WriteLine("El Pokémon " + this.Nombre + " atacará con " + this.Attack + " ataque y " + this.AttackDamage + " puntos.");
        }

        public void Colocar()
        {
            Console.WriteLine("La carta "+ nombre+ " fue colocada");
        }

        public void showAllInfo()
        {
            Console.WriteLine("/*****\n" + Nombre + ";\nFase: " + Fase
                                + "\nPokémon evolucionado de: " + PreEvolucion + "\nIlustración: " + Ilustracion
                                + "\nIlustrador: " + Ilustrador + "\nPokedex: " + Pokedex + "\nHabilidad: " + Habilidad
                                + "\nCoste de energia" + CosteEnergia + "\nDebilidad: " + Debilidad
                                + "\nExpansión: " + Expansion + "\nRegulacion: " + Regulacion + "\nNumeroColeccion: " + NumeroColeccion
                                + "\nRareza: " + Rareza + "\nDescripcion: " + Descripcion + "\nRetirada: " + Retirada
                                + "\nResistencia: " + Resistencia + "\nDescripcion Ataque: " + DescripcionAtaque + "\nDaño de ataque: " + AttackDamage
                                + "\nAtaque: " + Attack + "\nTipo: " + Tipo + "\nPuntos de salud: " + PuntosSalud
                                + "\n+++++/");
        }

    }
}
