namespace FormulaUno
{
    internal class Mecanico : Empleado
    {
        private string certificaciones;

        public string Certificaciones { get => certificaciones; set => certificaciones = value; }

        // constructor que llama a la clase padre Empleado
        public Mecanico(int iD, string escuderia,
            string nombreCompleto, string gradoIngenieria,
            string email, string fechaNacimiento,
            string nacionalidad, int sueldo,
            string certificaciones)
            : base(iD, escuderia, nombreCompleto, gradoIngenieria,
                  email, fechaNacimiento, nacionalidad, sueldo)
        {
            Certificaciones = certificaciones;
        }

        // Oculta al metodo de la clase padre
        public new void mostrarInformacion()
        {
            base.mostrarInformacion();  // invoca al metodo de la clase padre
            // Se agrega información propia de la clase Mecanico
            Console.WriteLine("Certificaciones: " + Certificaciones);
        }

    }
}
