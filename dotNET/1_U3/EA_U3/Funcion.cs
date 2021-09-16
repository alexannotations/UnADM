/* * * * *
 * Funcion para convertir un numero en 1.
 * n es par     -> n=n/2
 * n es impar   -> n=n*3+1
 * Septiembre 2021
 * * * * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_U3
{
    class Funcion
    {
        int par = 0;
        int impar = 0;

        public void HacerUno(int numero)
        {
            int original = numero;
            int contador = 0;
            numero = HacerPositivo(numero);

            while (numero != 1)
            {
                numero = IdentificaParidad(numero);
                contador++;
            }
            Console.WriteLine($"Numero de pasos tomados por la función para convertir |{original}| en uno: {contador}");
            Console.WriteLine($"Pares: {par} - Impares: {impar}");
        }

        int HacerPositivo(int numero)
        {
            if (numero <0)
                numero *= -1;
            return numero;
        }

        int IdentificaParidad(int numero)
        {
            if (numero % 2 != 0)
            {
                impar++;
                int entero_devuelto = EsImpar(numero);
                return entero_devuelto;
            }
            else if (numero % 2 == 0)
            {
                par++;
                int entero_devuelto = EsPar(numero);
                return entero_devuelto;
            }
            else
            {
                Console.WriteLine(" (´･_･`) Esta linea NO deberia mostrarse :-S");
                return -1;
            }
        }

        int EsPar(int numero) => numero = numero / 2;

        int EsImpar(int numero) => numero = numero * 3 + 1;

    }
}
