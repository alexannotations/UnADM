/* AAC 2021 agosto
 * Formulario por consola que captura datos de un empleado
 * y los muestra en pantalla despues de algunos calculos.
 */

using System;

namespace Unidad1_NET1_EA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" AAC \n ES18 \n DPRN1_U1_EA_ALAC \n Captura de empleados\n ");

            Empleado nuevoEmpleado = new Empleado();
            Prestacion beneficios = new Prestacion(nuevoEmpleado.getSueldoInicial());
            
        }
    }

    public class Empleado
    {
        String nombre;
        byte edad;
        Char sexo;
        Char edoCivil;
        bool discapacidad;
        DateTime fechaNacimiento;
        DateTime fechaIngreso;
        TimeSpan horaEntrada;
        TimeSpan horaSalida;
        TimeSpan horasTrabajadas;
        float sueldoInicial;
        TimeSpan maxHorasExtra = TimeSpan.Parse("11:00");

        // Constructor por defecto
        public Empleado()
        {
            Console.Write("Indique el nombre completo del empleado: ");
            nombre = Console.ReadLine();

            Console.Write("Indique la edad del empleado: ");
            edad = byte.Parse(Console.ReadLine());

            Console.Write("Indique el genero del empleado (M o F): ");
            sexo = Char.Parse(Console.ReadLine());

            Console.Write("Indique el estado civil del empleado (S o C): ");
            edoCivil = Char.Parse(Console.ReadLine());

            Console.Write("¿Posee alguna discapacidad? (Y o N): ");
            // devuelve true en caso de colocar Y, en otro caso false
            discapacidad = Console.ReadLine().ToUpper().Contains("Y");

            // declaracion y creacion del objeto fechaNacimiento
            //DateTime fechaNacimiento = new DateTime();
            Console.Write("Fecha de nacimiento (dd/mm/aaaa): ");
            fechaNacimiento = DateTime.Parse(Console.ReadLine());

            //DateTime fechaIngreso = new DateTime();
            Console.Write("Fecha de ingreso (dd/mm/aaaa): ");
            fechaIngreso = DateTime.Parse(Console.ReadLine());

            Console.Write("Establezca la hora de entrada (hh:mm): ");
            horaEntrada = TimeSpan.Parse(Console.ReadLine());

            Console.Write("Establezca la hora de salida (hh:mm): ");
            horaSalida = TimeSpan.Parse(Console.ReadLine());
            horasTrabajadas = horaSalida - horaEntrada;

            Console.Write("Indique el sueldo mensual: ");
            sueldoInicial = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"\nDatos del empleado: \n{nombre}, {edad} años, Genero: {sexo}, Estado civil: {edoCivil}, Discapacidad: {discapacidad}, Fecha nacimiento: {fechaNacimiento.ToString("dd/MMM/yyyy")}\nFecha ingreso laboral: {fechaIngreso.ToString("dd/MMM/yyyy")}");
            Console.WriteLine("\nHora de entrada: " + horaEntrada.ToString() + "\nHora de salida: " + horaSalida.ToString() + "\nJornada ordinaria: " + horasTrabajadas.ToString() + " hrs.");

            Console.WriteLine("Horario máximo de salida: " + horaEntrada.Add(maxHorasExtra));
        }

        // Metodos
        public float getSueldoInicial()
        {
            return sueldoInicial;
        }
    }

    public class Prestacion
    {
        float salarioFinal;
        float porcentajeBonificacionAnual;
        float bonoAnual;
        float pagoHoraExtra;

        // Constructor (podrian usarse dos constructores: empleado de prueba y empleado fijo con dos parametros)
        public Prestacion(float salarioMensual)
        {
            salarioFinal = salarioMensual * 1.02f;
            Console.WriteLine($"El sueldo mensual en periodo de prueba es: ${salarioMensual}\nEl sueldo mensual DESPUES del periodo de prueba será: ${salarioFinal}");

            porcentajeBonificacionAnual = calculoBonoAnual((float)salarioFinal);
            bonoAnual = salarioFinal * porcentajeBonificacionAnual * 0.01f;
            Console.WriteLine("El bono anual será de {0}% equivalente a ${1}", porcentajeBonificacionAnual, bonoAnual);
            pagoHoraExtra = calculoHoraExtra(salarioFinal);
            Console.WriteLine("Hora extra: $" + pagoHoraExtra);
        }

        float calculoBonoAnual(float salarioMensual)
        {
            if (salarioMensual < 20000)
            {
                if (salarioMensual < 5000)
                {
                    if (salarioMensual < 1000)
                    {
                        //Console.WriteLine("salario menor a mil");
                        return 0;
                    }
                    else
                    {
                        //Console.WriteLine("salario MAYOR a mil");
                        return 3;
                    }
                }
                else
                {
                    //Console.WriteLine("salario MAYOR a 5mil");
                    return 5;
                }
            }
            //Console.WriteLine("salario MAYOR a 20mil");
            return 8;
        }

        float calculoHoraExtra(float salarioMensual)
        {
            float pagoHoraExtra = 0.26f * salarioMensual / 30;
            return pagoHoraExtra;
        }
    }
}
