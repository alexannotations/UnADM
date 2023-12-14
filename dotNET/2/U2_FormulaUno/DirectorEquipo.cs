namespace FormulaUno
{
    internal class DirectorEquipo : Empleado
    {
        private string masterMotosport;
        private int experiencia;

        public string MasterMotosport { get => masterMotosport; set => masterMotosport = value; }
        public int Experiencia { get => experiencia; set => experiencia = value; }

        public DirectorEquipo(int iD, string escuderia, 
            string nombreCompleto, string gradoIngenieria, 
            string email, string fechaNacimiento, 
            string nacionalidad, int sueldo, 
            string masterMotosport, int experiencia) 
            : base(iD, escuderia, nombreCompleto, gradoIngenieria, 
                  email, fechaNacimiento, nacionalidad, sueldo)
        {
            MasterMotosport = masterMotosport;
            Experiencia = experiencia;
        }

        // Oculta al metodo de la clase padre
        public new void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Master en Motosport: " + MasterMotosport);
            Console.WriteLine("Experiencia: " + Experiencia + " años.");
        }

    }
}
