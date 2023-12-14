using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Modificador_Virtual
    {
        static void Main(string[] args)
        {
            Dimension d = new Dimension(5.6, 2.3);
            Console.WriteLine("area rectangulo: " + d.Area());

            CirculoD cd = new CirculoD(3.4);
            Console.WriteLine("area rectangulo: " + cd.Area());

            //Dimension e = new EsferaD(2.8);
            EsferaD e = new EsferaD(2.8);
            Console.WriteLine("area rectangulo: " + e.Area());

            //Dimension c = new Cilindro(5.6, 2.3);
            Cilindro c = new Cilindro(5.6, 2.3);
            Console.WriteLine("area rectangulo: " + c.Area());
        }
    }


    class Dimension
    {
        public const double PI = Math.PI;
        protected double x, y;

        public Dimension(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // metodo virtual a ser redefinido
        public virtual double Area()
        {
            return x * y;
        }
    }


    class CirculoD : Dimension
    {

        // en este caso y = 0
        public CirculoD(double r) : base(r, 0)
        {
        }

        // sobrescribe el metodo virtual
        public override double Area()
        {
            // observe que no se usa r porque genera error
            // se usa x considerando la posicion de los parametros
            return PI * x * x;
        }
    }


    class EsferaD : Dimension
    {
        public EsferaD(double r) : base(r, 0)
        {
        }

        // sobrescribe el metodo virtual
        public override double Area()
        {
            return 4 * PI * x * x;
        }
    }


    class Cilindro : Dimension
    {
        public Cilindro(double r, double h) : base(r, h)
        {
        }

        // sobrescribe el metodo virtual
        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }


}
