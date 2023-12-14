namespace u3_a4_alac
{
    internal class MonedaVirtual
    {
        private int numero; // posición por capitalización de mercado
        private string nombre;
        private string id;  // abreviatura de la divisa - código de moneda
        private double precio;
        private DateOnly fechaConsulta;
        private double valor;

        public MonedaVirtual(int numero, string nombre, string id, double precio, DateOnly fechaConsulta)
        {
            Valor = 1;
            Numero = numero;
            Nombre = nombre;
            ID = id;
            Precio = precio;
            FechaConsulta = fechaConsulta;
        }

        public MonedaVirtual(double valor, int numero, string nombre, string id, double precio, DateOnly fechaConsulta)
        {
            Valor = valor;
            Numero = numero;
            Nombre = nombre;
            ID = id;
            Precio = precio;
            FechaConsulta = fechaConsulta;
        }


        public int Numero { get => numero; set => numero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ID { get => id; set => id = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateOnly FechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}
