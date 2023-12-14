namespace FormulaUno
{
    internal abstract class Empleado
    {
        // campos encapsulados
        private int id;
        private string escuderia;
        private string nombreCompleto;
        private string gradoIngenieria;
        private string email;
        private string fechaNacimiento;
        private string nacionalidad;
        private int sueldo;


        // miembros de acceso a campos
        public int ID { get => id; set => id = value; }
        public string Escuderia { get => escuderia; set => escuderia = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string GradoIngenieria { get => gradoIngenieria; set => gradoIngenieria = value; }
        public string Email { get => email; set => email = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }


        // constructor
        protected Empleado(int iD, string escuderia, string nombreCompleto, 
            string gradoIngenieria, string email, string fechaNacimiento, 
            string nacionalidad, int sueldo)
        {
            ID = iD;
            Escuderia = escuderia;
            NombreCompleto = nombreCompleto;
            GradoIngenieria = gradoIngenieria;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            Nacionalidad = nacionalidad;
            Sueldo = sueldo;
        }


        // no es necesario que el metodo este marcado como virtual en la clase base para poder sobrecargarlo
        public void mostrarInformacion() 
        {
            System.Console.WriteLine("\n" + "ID: " + ID);
            Console.WriteLine("Escuderia: " + Escuderia);
            Console.WriteLine("Nombre Completo: " + NombreCompleto);
            Console.WriteLine("Grado de Ingenieria: " + GradoIngenieria);
            Console.WriteLine("e-mail: " + Email);
            Console.WriteLine("Fecha de Nacimiento: " + FechaNacimiento);
            Console.WriteLine("Nacionalidad: " + Nacionalidad);
            Console.WriteLine("Sueldo: $" + Sueldo);
        }
    }
}
