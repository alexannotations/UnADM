namespace Herencia
{
    /**
     * A través de la herencia, una clase puede utilizarse como su propio 
     * tipo o como cualquier tipo de una clase padre. Cuando un objeto se utiliza como un tipo 
     * que no es ella misma sino de una clase padre, se tiene un polimorfismo a nivel clase.
     * 
     * Se observa un ejemplo de polimorfismo a nivel de objeto 
     * tambien llamado de inclusión, redefinición o subtipado.
     */
    public class MainIni
    {
        static void Main(string[] args) 
        {
            // Figura presenta polimorfismo a nivel de objeto como la clase Circulo
            // Figura se comporta como circulo
            Figura f = new Circulo(4.5);    // Considere que Figura es una clase abstracta
            // se utilizan los metodos de la clase Circulo
            Console.WriteLine(f.Perimetro());
            Console.WriteLine(f.Area());
        }
    }

    public abstract class Figura
    {
        protected double valor;
        public Figura(double valor)
        {
            this.valor = valor;
        }
        public abstract double Perimetro();
        public abstract double Area();
    }

    public class Circulo : Figura
    {
        public Circulo(double radio) : base(radio) 
        { 
        }
        public override double Perimetro()
        {
            return 3.1416 *2 *valor;
        }

        public override double Area()
        {
            return 3.1416 * valor * valor;
        }
    }
}
