using System;

namespace Unidad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Programación NET1\n AAC\n DPRN1_U3_A3_ALAC");

            int switch_on;
            do
            {
                Console.WriteLine("\n\n A3 - Programa con estructuras cíclicas.\n Seleccione una opción: \n\t1 - Diseño gráfico.\n\t2 - Pagos semanales.\n\t9 - Salir.");
                switch_on = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (switch_on)
                {
                    case 1:
                        DisenioGrafico caracter = new DisenioGrafico();
                        char letra = caracter.verificarCaracter();
                        int alto = caracter.verificarAlto();
                        int ancho = caracter.verificarAncho();
                        Console.Clear();
                        Console.WriteLine($" Usted ingreso.\n  Caracter: {letra}\n  Ancho: {ancho}\n  Alto: {alto}\n");
                        caracter.dibujarU(letra, ancho, alto);
                        break;

                    case 2:
                        PagosSemanales ahorrador = new PagosSemanales();
                        int meses_para_jubilarse = ahorrador.setTiempoPorLaborar();
                        decimal ahorro_mensual = ahorrador.setAhorroMensual();
                        ahorrador.showMensualDesglosado(ahorro_mensual, meses_para_jubilarse);

                        break;

                    case 9:
                        Console.WriteLine("Saliendo.");
                        break;

                    default:
                        Console.WriteLine($"La opción ({switch_on}) no es valida.", switch_on);
                        break;
                }
            } while (switch_on != 9);
            
        }

    }
}
