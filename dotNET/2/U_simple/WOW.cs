namespace wow
{
    internal class WOW
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WoW");

            Guerrero arthas = new Guerrero("arthas",1000,190,95, "Espada Frostmourne", 99);
            Mago uther = new Mago("uther",800,200,250,"Baston de Ildrassil",40);
            Druida malfurion = new Druida("marfurion", 2000, 220, 950, "Bastón de agua resonadora", 35);

            Console.WriteLine("\n     ****    ***   **  * ");
            arthas.nombre();
            arthas.estadisticas();
            arthas.Ataque();
            arthas.Saludar();
            arthas.Sanacion(13);    // Uso de metodo polimorfico

            int danioDeArthas = 900;
            arthas.danioDeArma = danioDeArthas;

            arthas.Ataque();

            Console.WriteLine("\n     ****    ***   **  * ");
            uther.nombre();
            uther.estadisticas();
            uther.Ataque();
            uther.Saludar();
            uther.Sanacion(13); // Uso de metodo polimorfico


            Console.WriteLine("\n     ****    ***   **  * ");
            malfurion.nombre();
            malfurion.estadisticas();
            malfurion.Ataque();
            malfurion.Saludar();

            // Uso de metodos polimorficos
            malfurion.Sanacion(13);
            malfurion.Sanacion(arthas);
            malfurion.Sanacion(uther);
        }
    }


    abstract class Personaje
    {
        public string name { get; set; }
        public int vida { get; set; }
        protected int attack { get; set; }
        protected int defense { get; set; }

        public Personaje(string name, int vida, int attack, int defense)
        {
            this.name = name;
            this.vida = vida;
            this.attack = attack;
            this.defense = defense;
        }

        virtual public void estadisticas()
        {
            Console.WriteLine("Vida: " +vida);
            Console.WriteLine("Poder de ataque: " + attack);
            Console.WriteLine("Poder de defensa: " + defense);
        }

        virtual public void nombre()
        {
            Console.WriteLine("Nombre del personaje: " + name);
        }

        public virtual void Sanacion(int pocion)
        {
            vida = vida + pocion;
            Console.WriteLine(name + " has recuperado " + pocion + " de sangre");
        }

        ~Personaje() { }
    }


    public interface IAcciones
    {
        public void Ataque();
        public void Saludar();
    }


    class Mago : Personaje, IAcciones
    {
        public string Hechizo { get; set; }
        public int danioDeHechizo { get; set; }

        public Mago(string name, int vida, int attack, int defense, string hechizo, int danioDeHechizo) : base(name, vida, attack, defense)
        {
            Hechizo = hechizo;
            this.danioDeHechizo = danioDeHechizo;
        }

        public void Ataque()
        {
            int daniototal = attack + danioDeHechizo;
            Console.WriteLine("El ataque de " + name + " es de " + daniototal);
        }

        public void Saludar()
        {
            Console.WriteLine(name + " dice hola");
        }

        public override void estadisticas()
        {
            base.estadisticas();
            Console.WriteLine("Metodo utilizado " + Hechizo);
            Console.WriteLine("Daño de hechizo " + danioDeHechizo);
        }

        public override void Sanacion(int pocion)
        {
            Console.Write(name + " tienes " + vida +" de vida, ");
            vida = vida + pocion;
            Console.WriteLine("has recuperado " + pocion + " de vida");
        }

        ~Mago() { }
    }


    class Guerrero : Personaje, IAcciones
    {
        public string Arma { get; set; }
        public int danioDeArma { get; set; }

        public Guerrero(string name, int vida, int attack, int defense, string arma, int danioDeArma) : base(name, vida, attack, defense)
        {
            Arma = arma;
            this.danioDeArma = danioDeArma;
        }

        public void Ataque()
        {
            int daniototal = attack + danioDeArma;
            Console.WriteLine("El ataque de " + name + " es de " + daniototal);
        }

        public void Saludar()
        {
            Console.WriteLine(name + " dice hola");
        }

        public override void estadisticas()
        {
            base.estadisticas();
            Console.WriteLine("Metodo utilizado " + Arma);
            Console.WriteLine("Daño de hechizo " + danioDeArma);
        }

        ~Guerrero() { }
    }


    class Druida : Personaje, IAcciones
    {
        public string Arma { get; set; }
        public int danioDeArma { get; set; }

        public Druida(string name, int vida, int attack, int defense, string arma, int danioDeArma) : base(name, vida, attack, defense)
        {
            Arma = arma;
            this.danioDeArma = danioDeArma;
        }

        public void Ataque()
        {
            int daniototal = attack + danioDeArma;
            Console.WriteLine("El ataque de " + name + " es de " + daniototal);
        }

        public void Saludar()
        {
            Console.WriteLine(name + " dice hola");
        }

        public override void estadisticas()
        {
            base.estadisticas();
            Console.WriteLine("Metodo utilizado " + Arma);
            Console.WriteLine("Daño de hechizo " + danioDeArma);
        }

        public void Sanacion(Personaje personaje)
        {
            // Cura a un personaje otorgandole 10% de su vida
            int vidaOtorgada = personaje.vida / 10;
            personaje.Sanacion(vidaOtorgada);
            Console.WriteLine("Otorgaste " + vidaOtorgada + " de vida a " + personaje.name);
        }

        ~Druida() { }
    }






}