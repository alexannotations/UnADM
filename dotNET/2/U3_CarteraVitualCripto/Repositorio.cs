using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace u3_a4_alac
{
    internal class Repositorio
    {
        internal static string[] opciones = {
                    "\n 1 Crear cartera" ,
                    "\n 2 Agregar criptomonedas a cartera" ,
                    "\n 3 Comprar criptomonedas" ,
                    "\n 4 Mostrar cartera"
        };

        static string? mensaje = null;
        
        // creamos la cartera
        static CarteraVirtual cartera = new CarteraVirtual();

        static Dictionary<string, MonedaVirtual> lista = null;



        /** * *******  *******  *******  ___  *******  *******  ******* */
        public static void ro1()
        {
            Console.WriteLine(opciones[0] + ": ");


            if (lista==null)
            {
                lista = new Dictionary<string, MonedaVirtual>();
                // Generamos una lista con la monedas disponibles
                lista.Add("BTC", Criptomoneda.bitcoin());
                lista.Add("ETH", Criptomoneda.ethereum());
                lista.Add("USDT", Criptomoneda.tether());
                lista.Add("BNB", Criptomoneda.bnb());
                lista.Add("XRP", Criptomoneda.xrp());
                lista.Add("SOL", Criptomoneda.solana());
                lista.Add("USDC", Criptomoneda.usdc());
                lista.Add("STETH", Criptomoneda.lido());
                lista.Add("ADA", Criptomoneda.cardano());
                lista.Add("DOGE", Criptomoneda.dogecoin());
                lista.Add("LTC", Criptomoneda.litecoin());
                lista.Add("XMR", Criptomoneda.monero());
            }

            Console.WriteLine("Cartera generada");
        }


        /** * *******  *******  *******  ___  *******  *******  ******* */
        public static void ro2()
        {
            Console.WriteLine(opciones[1] + ": ");
            
            foreach (var item in lista)
            {
                Console.WriteLine(item.Key);
            }

            Console.Write("Indique que criptomoneda desea agregar: ");
            string eleccion = Console.ReadLine();

            if (lista.ContainsKey(eleccion))
            {
                try
                {
                    Console.Write("Cuantas monedas desea agregar de " + lista[eleccion].ID + ": ");
                    int cantidad = Int32.Parse(Console.ReadLine());
                    cartera.agregarCriptomonedas(cantidad, lista[eleccion]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Error la llave no existe");
            }

        }


        /** * *******  *******  *******  ___  *******  *******  ******* */
        public static void ro3()
        {
            Console.WriteLine(opciones[2] + ": ");
            try
            {
                foreach (var item in lista)
                {
                    Console.WriteLine(item.Key);
                }
            }
            catch(NullReferenceException e) 
            {
                Console.WriteLine(e);
            }

            Console.Write("Indique que criptomoneda desea comprar: ");
            string eleccion = Console.ReadLine();

            if (lista.ContainsKey(eleccion))
            {
                try
                {
                    Console.WriteLine("Se puede comprar: " + lista[eleccion].ID);
                    Console.Write("Cuantos USD desea invertir: ");
                    int cantidad = Int32.Parse(Console.ReadLine());
                    cartera.comprarCriptomoneda(cantidad, lista[eleccion]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Error la llave no existe");
            }
        }


        /** * *******  *******  *******  ___  *******  *******  ******* */
        public static void ro4()
        {
            Console.WriteLine(opciones[3] + ": ");
            cartera.mostrarCartera();

        }


    }
}
