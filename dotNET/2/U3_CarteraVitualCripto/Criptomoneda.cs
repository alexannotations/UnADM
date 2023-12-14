using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u3_a4_alac
{
    class Criptomoneda
    {
        public static MonedaVirtual bitcoin() 
        {
            int numero = 1;
            string nombre = "Bitcoin";
            string id = "BTC";
            double precio = 43999.20;
            DateOnly fechaConsulta = new DateOnly(2023, 12, 09);
            
            return new MonedaVirtual(
                numero, nombre, id, precio, fechaConsulta
                );
        }


        public static MonedaVirtual ethereum()
        {
            int numero = 2;
            string nombre = "Ethereum";
            string id = "ETH";
            double precio = 2358.85;
            DateOnly fechaConsulta = new DateOnly(2023, 12, 09);

            return new MonedaVirtual(
                numero, nombre, id, precio, fechaConsulta
                );
        }


        public static MonedaVirtual tether()
        {
            int numero = 3;
            string nombre = "Tether";
            string id = "USDT";
            double precio = 1;
            DateOnly fechaConsulta = new DateOnly(2023, 12, 09);

            return new MonedaVirtual(
                numero, nombre, id, precio, fechaConsulta
                );
        }


        public static MonedaVirtual bnb()
        {
            int numero = 4;
            string nombre = "BNB";
            string id = "BNB";
            double precio = 240.06;
            DateOnly fechaConsulta = new DateOnly(2023, 12, 09);

            return new MonedaVirtual(
                numero, nombre, id, precio, fechaConsulta
                );
        }


        public static MonedaVirtual xrp()
        {
            int numero = 5;
            string nombre = "XRP";
            string id = "XRP";
            double precio = 0.672849;
            DateOnly fechaConsulta = new DateOnly(2023, 12, 09);

            return new MonedaVirtual(
                numero, nombre, id, precio, fechaConsulta
                );
        }


        public static MonedaVirtual solana()
        {
            int numero = 6;
            string nombre = "Solana";
            string id = "SOL";
            double precio = 74.29;
            DateOnly fechaConsulta = new DateOnly(2023, 12, 09);

            return new MonedaVirtual(
                numero, nombre, id, precio, fechaConsulta
                );
        }


        public static MonedaVirtual usdc()
        {
            int numero = 7;
            string nombre = "USDC";
            string id = "USDC";
            double precio = 1;
            DateOnly fechaConsulta = new DateOnly(2023, 12, 09);

            return new MonedaVirtual(
                numero, nombre, id, precio, fechaConsulta
                );
        }


        public static MonedaVirtual lido()
        {
            int numero = 8;
            string nombre = "Lido Staked Ether";
            string id = "STETH";
            double precio = 2357.25;
            DateOnly fechaConsulta = new DateOnly(2023, 12, 09);

            return new MonedaVirtual(
                numero, nombre, id, precio, fechaConsulta
                );
        }


        public static MonedaVirtual cardano()
        {
            int numero = 9;
            string nombre = "Cardano";
            string id = "ADA";
            double precio = 0.593084;
            DateOnly fechaConsulta = new DateOnly(2023, 12, 09);

            return new MonedaVirtual(
                numero, nombre, id, precio, fechaConsulta
                );
        }


        public static MonedaVirtual dogecoin()
        {
            int numero = 10;
            string nombre = "Dogecoin";
            string id = "DOGE";
            double precio = 0.100396;
            DateOnly fechaConsulta = new DateOnly(2023, 12, 09);

            return new MonedaVirtual(
                numero, nombre, id, precio, fechaConsulta
                );
        }


        public static MonedaVirtual litecoin()
        {
            int numero = 19;
            string nombre = "Litecoin";
            string id = "LTC";
            double precio = 77.09;
            DateOnly fechaConsulta = new DateOnly(2023, 12, 09);

            return new MonedaVirtual(
                numero, nombre, id, precio, fechaConsulta
                );
        }


        public static MonedaVirtual monero()
        {
            int numero = 27;
            string nombre = "Monero";
            string id = "XMR";
            double precio = 176.20;
            DateOnly fechaConsulta = new DateOnly(2023, 12, 09);

            return new MonedaVirtual(
                numero, nombre, id, precio, fechaConsulta
                );
        }

    }
}
