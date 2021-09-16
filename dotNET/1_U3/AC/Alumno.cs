using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadComplementaria
{
    class Alumno
    {
        private string nombre;
        private int edad;
        private char sexo;
        private DateTime fecha_de_nacimiento;
        private bool vacunaCOVID;
        private string correo_electronico;
        private string boleta_en_texto_binario;
        private int numero_positivo_de_la_suerte;




        // Metodos Getters and Setters

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad { get => edad; set => edad = value; }

        public char Sexo { get { return sexo; } set { sexo = value; } }

        public DateTime GetFechaNacimiento() => this.fecha_de_nacimiento;   // Getter Methods: We can get access to private variables.

        public void SetFechaNacimiento(string value) => this.fecha_de_nacimiento = DateTime.Parse(value); // Setter Methods: We can modify private fields.

        public bool VacunaCOVID { get => vacunaCOVID; }
        public void SetVacunaCOVID(string value)
        {
            value = value.ToLower();
            if (value == "si" || value == "yes" || value == "y" || value == "s")
                vacunaCOVID = true;
            else
                vacunaCOVID = false;
        }

        public string Email { get => correo_electronico; set => correo_electronico = value; }

        public string BoletaTextBinario { get => boleta_en_texto_binario; set => boleta_en_texto_binario = value; }

        public int NumeroSuerte
        {
            get { return numero_positivo_de_la_suerte; }
            set { numero_positivo_de_la_suerte = value; }
        }


    }
}
