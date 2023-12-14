namespace DPRN2_U2_A2_ALAC
{
    internal class Ajedrez
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ajedrez");

            // se instancian algunas piezas
            Reyna reyna = new Reyna();
            Rey rey = new Rey();
            Alfil alfil = new Alfil();
            Caballo caballo = new Caballo();
            Torre torre = new Torre();
            Peon peon = new Peon();

            peon.Mover();
            reyna.Mover();
            reyna.Mover(5,3);

        }
    }

    /** **************  **************  ************** */
    abstract class Pieza
    {
        protected string tipo;
        protected int[] posicion;

        // constructor que define el nombre del tipo de pieza
        protected Pieza(string tipo)
        {
            this.tipo = tipo;
        }

        // finalizador o destructor
        ~Pieza() { Console.WriteLine("La pieza ha sido destruida"); }

        // metodo  virtual para ser redefinido con override
        public virtual void Sacrificar()
        {
            Console.WriteLine("Haz perdido tu " + tipo);
        }

        // Método abstracto para aplicarse el polimorfismo de sobrecarga
        public abstract void Mover();
    }

    /** **************  **************  ************** */
    class Reyna : Pieza
    {
        // constructor que llama al constructor padre
        public Reyna() : base("Reyna") {        }

        // Método polimórfico con sobrecarga
        public override void Mover()
        {
            Console.WriteLine("Se desplaza libremente en cualquier direccion y distancia");
        }

        // Método polimórfico paramétrico 
        public void Mover(int x, int y)
        {
            posicion = new int[] { x, y };
            Console.WriteLine("Se mueve a: " + posicion[0] + ":" + posicion[1]);
        }

    }

    /** **************  **************  ************** */
    class Rey : Pieza
    {
        public Rey() : base("Rey") { }

        public override void Mover()
        {
            Console.WriteLine("Se desplaza en cualquier dirección una casilla");
        }
    }

    /** **************  **************  ************** */
    class Alfil : Pieza
    {
        public Alfil() : base("Alfil") { }

        public override void Mover()
        {
            Console.WriteLine("Se desplaza en diagonal cualquier distancia");
        }
    }

    /** **************  **************  ************** */
    class Caballo : Pieza
    {
        public Caballo() : base("Caballo") { }

        public override void Mover()
        {
            Console.WriteLine("Se desplaza en L (2+1)");
        }
    }

    /** **************  **************  ************** */
    class Torre : Pieza
    {
        public Torre() : base("Torre") { }

        public override void Mover()
        {
            Console.WriteLine("Se desplaza horizontal o vertical cualquier distancia");
        }
    }

    /** **************  **************  ************** */
    class Peon : Pieza
    {
        public Peon() : base("Peon") { }

        public override void Mover()
        {
            Console.WriteLine("Se desplaza hacia adelante una casilla");
        }
    }

}