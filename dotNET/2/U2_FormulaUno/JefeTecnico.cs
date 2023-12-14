namespace FormulaUno
{
    internal class JefeTecnico : Empleado
    {
        private string especialidad;

        public string Especialidad { get => especialidad; set => especialidad = value; }

        public JefeTecnico(int iD, string escuderia,
            string nombreCompleto, string gradoIngenieria,
            string email, string fechaNacimiento,
            string nacionalidad, int sueldo,
            string especialidad)
            : base(iD, escuderia, nombreCompleto, gradoIngenieria,
                  email, fechaNacimiento, nacionalidad, sueldo)
        {
            Especialidad = especialidad;
        }

        // Oculta al metodo de la clase padre
        public new void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Especialidad: " + Especialidad);
        }

    }

}
