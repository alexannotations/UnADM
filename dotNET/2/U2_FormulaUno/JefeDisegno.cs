namespace FormulaUno
{
    internal class JefeDisegno : Empleado
    {
        private string masterDisegno;

        public string MasterDisegno { get => masterDisegno; set => masterDisegno = value; }

        public JefeDisegno(int iD, string escuderia,
            string nombreCompleto, string gradoIngenieria,
            string email, string fechaNacimiento,
            string nacionalidad, int sueldo,
            string masterDisegno)
            : base(iD, escuderia, nombreCompleto, gradoIngenieria,
                  email, fechaNacimiento, nacionalidad, sueldo)
        {
            MasterDisegno = masterDisegno;
        }

        // Oculta al metodo de la clase padre
        public new void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Master en diseño: " + MasterDisegno);
        }

    }
}
