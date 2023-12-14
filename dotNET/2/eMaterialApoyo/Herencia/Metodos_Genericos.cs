namespace Herencia
{
    // al inicio de la clase se definen T1 y T2 que son parametros de tipo
    class Metodos_Genericos
    {
        static void Main(string[] args)
        {
            // Se utiliza la clase generica para guardar un par de datos

            // Un numero entero y un nombre de persona
            ClaseGenerica<int, string> cg = new ClaseGenerica<int, string>();
            cg.GuardarValor(1,"Lilia");
            cg.ImprimePar();

            // Dos strings
            ClaseGenerica<string, string> cgs = new ClaseGenerica<string, string>();
            cgs.GuardarValor("Lilia", "Najer");
            cgs.ImprimePar();

            // Con el polimorfismo, a traves de metodos genericos
            // es posible resolver problemas de funcionalidad similar utilizando una misma firma
        }
    }

    class ClaseGenerica <T1, T2>
    {
        // son genericos porque pueden ser cualquier tipo que se necesite
        // en el momento de la implementacion
        T1 valor1;
        T2 valor2;

        // recibe dos parámetros de tipo mediante un método,
        internal void GuardarValor(T1 valor1, T2 valor2)
        {
            // los guarda en la clase
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        internal void ImprimePar()
        {
            //  muestra el par de parámetros recibidos
            Console.WriteLine("(" + valor1 + "," + valor2 + ")");
        }
    }
}
