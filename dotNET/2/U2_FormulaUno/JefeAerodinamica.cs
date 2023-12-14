namespace FormulaUno
{
    internal class JefeAerodinamica : Empleado
    {
        private int experienciaAerodinamica;

        public int ExperienciaAerodinamica { get => experienciaAerodinamica; set => experienciaAerodinamica = value; }

        public JefeAerodinamica(int iD, string escuderia,
            string nombreCompleto, string gradoIngenieria,
            string email, string fechaNacimiento,
            string nacionalidad, int sueldo,
            int experienciaAerodinamica)
            : base(iD, escuderia, nombreCompleto, gradoIngenieria,
                  email, fechaNacimiento, nacionalidad, sueldo)
        {
            ExperienciaAerodinamica = experienciaAerodinamica;
        }

        // Oculta al metodo de la clase padre
        public new void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Experiencia en aerodinámica: " + ExperienciaAerodinamica + " años.");
        }

    }
}
