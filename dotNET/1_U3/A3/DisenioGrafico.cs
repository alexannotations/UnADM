using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad3
{
    class DisenioGrafico
    {
        public int verificarAncho()
        {
            int caracter_ancho=0;
            while (caracter_ancho <= 3)
            {
                Console.Write("Ingrese el ancho a diseñar: ");
                caracter_ancho = int.Parse(Console.ReadLine());
                if (caracter_ancho <= 3)
                {
                    Console.WriteLine("Solicitud no válida. \nIntroduzca un valor mayor a 3.");
                }
            }
            return caracter_ancho;
        }

        public int verificarAlto()
        {
            int caracter_ancho = 0;
            while (caracter_ancho <= 3)
            {
                Console.Write("Ingrese el alto a diseñar: ");
                caracter_ancho = int.Parse(Console.ReadLine());
                if (caracter_ancho <= 3)
                {
                    Console.WriteLine("Solicitud no válida. \nIntroduzca un valor mayor a 3.");
                }
            }
            return caracter_ancho;
        }

        public char verificarCaracter() 
        {
            // Si se introduce una cadena de texto, solo se tomara el primer caracter
            string input_key_board;
            Console.Write("Ingrese un caracter: ");
            input_key_board = Console.ReadLine();
            char caracter = input_key_board[0];
            return caracter;
        }

        public void dibujarU(char caracter, int ancho, int alto) 
        {
            int top = 3;
            int left = 20;
            Console.Clear();
            Console.WriteLine("La letra U se presentaria asi:");
            for (int i = 0; i < alto-1; i++)
            {
                // imprime una linea
                Console.SetCursorPosition(left, top);
                Console.Write(caracter);
                for (int j = 1; j < ancho - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(caracter);
                if (i<(alto-1))
                {
                    Console.WriteLine();   
                }
                top++;
            }
            Console.SetCursorPosition(left, top);
            for (int k = 0; k < ancho; k++)
            {
                Console.Write(caracter);
            }
            Console.WriteLine("\n\n\n\n");
        }
    }
}
