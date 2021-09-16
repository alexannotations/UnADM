using System;
using System.Globalization;

namespace U2_A3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" AAC\n ES18\n U2_A3_ALAC\n");

            string word1, word2, word3;

            //Pedimos valores al usuario
            Console.Write("Introduca una palabra: ");
            word1 = Console.ReadLine();
            Console.Write("Introduce una segunda palabra: ");
            word2 = Console.ReadLine();
            Console.Write("Introduce una tercer palabra: ");
            word3 = Console.ReadLine();

            Console.WriteLine(unirPalabraTitulo(word1, word2, word3));
            Console.WriteLine(unirPalabraMayusculas(word1, word2, word3));
            Console.WriteLine(unirPalabraMinusculas(word1, word2, word3));

        }

        static string unirPalabraTitulo(string word1, string word2, string word3) {
            TextInfo words = CultureInfo.CurrentCulture.TextInfo;
            return(words.ToTitleCase(word1) + " " + words.ToTitleCase(word2) + " " + words.ToTitleCase(word3));
        }

        static string unirPalabraMayusculas(string word1, string word2, string word3)
        {
            TextInfo words = CultureInfo.CurrentCulture.TextInfo;
            return(words.ToUpper(word1) + " " + words.ToUpper(word2) + " " + words.ToUpper(word3));
        }

        static string unirPalabraMinusculas(string word1, string word2, string word3)
        {
            TextInfo words = CultureInfo.CurrentCulture.TextInfo;
            return (words.ToLower(word1) + " " + words.ToLower(word2) + " " + words.ToLower(word3));
        }
          
    }
}
