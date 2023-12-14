namespace FormulaUno
{
    internal class IngenieroSoftware : Empleado
    {
        private string plataformas;

        public string Plataformas { get => plataformas; set => plataformas = value; }

        public IngenieroSoftware(int iD, string escuderia,
            string nombreCompleto, string gradoIngenieria,
            string email, string fechaNacimiento,
            string nacionalidad, int sueldo,
            string plataformas)
            : base(iD, escuderia, nombreCompleto, gradoIngenieria,
                  email, fechaNacimiento, nacionalidad, sueldo)
        {
            Plataformas = plataformas;
        }

        // Oculta al metodo de la clase padre
        public new void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Plataformas: " + Plataformas);
        }

    }
}
