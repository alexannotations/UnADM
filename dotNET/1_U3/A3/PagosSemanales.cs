using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad3
{
    class PagosSemanales
    {

        int edad_jubilacion = 65;
        int edad_actual;
        int meses_para_jubilarse;
        decimal saldo_inicial = 0;
        decimal ahorro_mensual;
        DateTime fecha_nacimiento, fecha_actual;
        decimal tasa_mensual = 0.048M;


        public int setTiempoPorLaborar()
        {
            /** Consideraciones para efectos de la actividad.
             * El calculo de la edad aun no es exacto.
             * Restar dos DateTime devuelve un tipo TimeSpan, que su máx represetación es en dias.
             * Se considera un año de 12 meses, para desarrollar el desgloce.
             */
            Console.Write("Indique su fecha de nacimiento (dd/mm/aaaa): ");
            fecha_nacimiento = DateTime.Parse(Console.ReadLine());
            fecha_actual = DateTime.Today;
            edad_actual = Convert.ToInt32((fecha_actual - fecha_nacimiento).TotalDays/ 365.2425); // Para tener la aproximacion más cercana a un año
            meses_para_jubilarse = (edad_jubilacion - edad_actual)*12;
            Console.WriteLine("\n Fecha nacimiento: " + fecha_nacimiento.ToLongDateString() + "\n Fecha de hoy dia: " + fecha_actual.ToLongDateString() + "\n Usted tiene {0} años. Le faltan {1} meses para jubilarse.\n", edad_actual, meses_para_jubilarse);
            return meses_para_jubilarse;
        }

        public decimal setAhorroMensual()
        {
            Console.Write("Indique el monto de su ahorro mensual: ");
            ahorro_mensual = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Usted introdujo: ${0:N2}", ahorro_mensual);
            return ahorro_mensual;
        }

        public void showMensualDesglosado(decimal aportacion_mensual,int meses_para_jubilarse)
        {
            decimal acumulado = saldo_inicial;
            decimal acumulado_con_intereses = aportacion_mensual;
            int top = 10;
            int left = 20;
            // Ahorro mensual desglosado
            Console.SetCursorPosition(left, top);
            Console.WriteLine("Mes: \tPeriodo anterior: \tAportación Mensual: \tIntereses:\tFin del periodo:");

            for (int i = 0; i <= meses_para_jubilarse; i++)
            {
                top++;
                Console.SetCursorPosition(left, top);
                Console.WriteLine("{0}\t\t{1:N2}\t\t{2:N2}\t\t{3:N2}\t\t{4:N2}", i, (acumulado + acumulado * tasa_mensual), aportacion_mensual, (acumulado * tasa_mensual), (aportacion_mensual + acumulado + acumulado * tasa_mensual));

                acumulado += acumulado_con_intereses;
                acumulado_con_intereses = (acumulado * tasa_mensual) + aportacion_mensual;
            }

            Console.WriteLine($"\n\n\t\tEl ahorro alcanzado al cumplir {edad_jubilacion} años, es de ${decimal.Round(acumulado, 2)}.");

        }
    }
}
