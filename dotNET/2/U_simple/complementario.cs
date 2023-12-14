/** 
 * Alejandro Ayala Castro
 * Grupo: DS-DPRN2-2302-B2-002
 * 
 * Clase retomada de:
 * HECTOR FLORES GANTE
 * 
 */
using System;

namespace _23net2_u1_a2
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnioFabricacion { get; set; }
        public string Color { get; set; }
        public double Velocidad { get; set; }
        public bool MotorEncendido { get; set; }
        public string Marcha { get; set; }      // Propiedad propuesta para identificar el avance

        // Constructor
        public Carro(){        }

        // finalizador o destructor
        ~Carro(){ /* declaraciones de limpieza ... */ }

        // Metodos propuestos por Hector
        public void Arrancar(){}
        public void Acelerar(){}
        public void Apagar(){}

        public void Reversa()
        {
            if(MotorEncendido)
            {
                Marcha="R";
                Velocidad -=cantidad;
                Console.WtriteLine("El coche {Marca} {Modelo} avanza en reversa");
            }else
            {
                Console.WtriteLine("El coche {Marca} {Modelo} esta apagado");
            }
        }

        public void Frenar() { }

    }
}


