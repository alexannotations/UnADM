namespace u3_a4_alac
{
    internal class CarteraVirtual
    {
        // lista
        List<MonedaVirtual>? monedero = new List<MonedaVirtual>();
        private int dolaresGastados;

        public CarteraVirtual()
        {
            dolaresGastados = 0;
        }


        public CarteraVirtual(MonedaVirtual moneda)
        {
            monedero.Add(moneda);
            dolaresGastados = 0;
        }


        public void agregarCriptomonedas(int cantidad, MonedaVirtual moneda)
        {
            for (int i = 0; i < cantidad; i++)
                monedero.Add(moneda);
        }

        /**  */
        public void comprarCriptomoneda(int dolares, MonedaVirtual moneda)
        {
            if (dolaresGastados < 1000)
            {
                dolaresGastados = dolaresGastados + dolares;
                double monedasCompradas = dolares / moneda.Precio;
                moneda.Valor = monedasCompradas;
                monedero.Add(moneda);
                Console.WriteLine("Compraste " + monedasCompradas + " de criptomonedas. Y se han agregado a tu cartera.");
            }
            else
            {
                throw new ComprasException("No puedes gastar más de 1000 USD");
            }

        }


        public void mostrarCartera()
        {
            Console.WriteLine("Cartera");
            double valorUSD = 0;
            double conteo = 0;
            foreach (MonedaVirtual moneda in monedero)
            {
                Console.WriteLine("Tienes " + moneda.Valor 
                    + " de " + moneda.Nombre 
                    + " con valor de " + moneda.Valor * moneda.Precio + " USD" );
                valorUSD = valorUSD + moneda.Valor * moneda.Precio;
                conteo = conteo + moneda.Valor;
            }
            Console.WriteLine("Cartera con " + conteo 
                + " criptomonedas valuadas en: " + valorUSD + " USD.\n"
                + "Haz gastado: " + dolaresGastados + " USD.");
        }


    }
}
