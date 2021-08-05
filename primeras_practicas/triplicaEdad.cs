/* Ejemplo de algoritmo
 * Si las edades en años de un padre y su hijo son respectivamente; 41 y 9.
 * ¿Al cabo de cúantos años, la edad del padre tríplica la del hijo?
 * 2021/ago/04 AAC
 * */

using System;

namespace edadTriplicada
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int edadPapa, edadPapaInicial = 41;
            int edadHijo = 9;
            edadPapa = edadPapaInicial;

            // La instrucción do -while permite repetir una instrucción hasta que una expresión especificada sea false.
            do
            {
                edadPapa++;
                edadHijo++;
                Console.Write("P: {0}. H: {1}\n", edadPapa, edadHijo);
            } while (edadPapa != edadHijo * 3);

            // Se presentan diversas formas para interpolar o concatenar Strings
            Console.WriteLine($"Edades \n Papá: {edadPapa}\n Hijo: {edadHijo}. ");
            Console.WriteLine("Pasan " + (edadPapa-edadPapaInicial) + " años para que se triplique la edad del papá respecto al hijo.");
        }
    }
}
