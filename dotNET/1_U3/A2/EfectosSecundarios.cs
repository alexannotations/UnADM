/* * * * * * * * * * * * 
 * Programa con estructuras de control selectivas
 * Propiedades del proyecto: plataforma de destino .NET 5.0
 * Autor:   Alex AC
 * Date:    Septiembre 2021
 * 
 * * * * * * * * * * * */
 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unidad3
{
    class EfectosSecundarios
    {
        string nombre;
        int dosis;
        string fabricante;
        string tipo_vacuna;
        string efectos_secundarios;

        public EfectosSecundarios(int vacuna)
        {
            int switch_on = vacuna;
            switch (switch_on)
            {
                case 1:
                    nombre = "Sputnik V";
                    dosis = 2;
                    fabricante = "Rusia; GAMALEYA";
                    tipo_vacuna = "ADN";
                    efectos_secundarios = "Enfermedad parecida a la gripe,\n\t\t\t\tDolor de cabeza,\n\t\t\t\tFatiga,\n\t\t\t\tReacciones en el sitio de la inyección.\n";
                    break;

                case 2:
                    nombre = "Pfizer";
                    dosis = 2;
                    fabricante = "Pfizer / Biontech";
                    tipo_vacuna = "ARNm";
                    efectos_secundarios = "Enrojecimiento,\n\t\t\t\tCefalea,\n\t\t\t\tNauseas,\n\t\t\t\tEscalofrío,\n\t\t\t\tFatiga,\n\t\t\t\tMialgia";
                    break;

                case 3:
                    nombre = "Astra Zeneca";
                    dosis = 2;
                    fabricante = "Oxford / AstraZeneca";
                    tipo_vacuna = "ADN";
                    efectos_secundarios = "Hinchazón,\n\t\t\t\tCefalea,\n\t\t\t\tEscalofríos,\n\t\t\t\tFatiga,\n\t\t\t\tNauseas,\n\t\t\t\tMialgia\n";
                    break;

                default:
                    Console.WriteLine($"La opción ({switch_on}) no es valida.", switch_on);
                    break;
            }
        }

        public void mostrarDatos() 
        {
            Console.Clear();
            Console.WriteLine($"\n\tNombre: \t\t{nombre}\n\tNo. dosis: \t\t{dosis}\n\tFabricante: \t\t{fabricante}\n\tVacuna: \t\t{tipo_vacuna}\n\tEfectos secundarios:");
            Console.SetCursorPosition(32, 5);
            Console.WriteLine(efectos_secundarios);
        }
    }
}
