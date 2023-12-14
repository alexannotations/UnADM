namespace DPRN2_U1_A2_ALAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Foco bombillo = new Foco();
            Console.WriteLine(bombillo.estado);
            bombillo.cambiarEstado();
            Console.WriteLine(bombillo.estado);
            Console.WriteLine(bombillo.color);
            bombillo.color="red";
            Console.WriteLine(bombillo.color);
        }
    }
}