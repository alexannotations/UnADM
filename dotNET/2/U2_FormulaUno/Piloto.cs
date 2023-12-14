namespace FormulaUno
{
    internal class Piloto : Empleado
    {
        private string licenciaIC;
        private int experiencia;

        public string LicenciaIC { get => licenciaIC; set => licenciaIC = value; }
        public int Experiencia { get => experiencia; set => experiencia = value; }

        public Piloto(int iD, string escuderia,
            string nombreCompleto, string gradoIngenieria,
            string email, string fechaNacimiento,
            string nacionalidad, int sueldo,
            string licencia, int experiencia)
            : base(iD, escuderia, nombreCompleto, gradoIngenieria,
                  email, fechaNacimiento, nacionalidad, sueldo)
        {
            LicenciaIC = licencia;
            Experiencia = experiencia;
        }

        // Oculta al metodo de la clase padre
        public new void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Tipo de licencia internacional de competición: " + LicenciaIC);
            Console.WriteLine("Experiencia: " + Experiencia + " años.");
        }

    }
}
