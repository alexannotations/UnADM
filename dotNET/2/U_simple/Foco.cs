using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN2_U1_A2_ALAC
{
    internal class Foco
    {
        public bool estado { get; set; }        // true encendido | false apagado
        public string color { get; set; }

        public Foco()   // Al instanciar el foco su estado inicial es apagado con color blanco
        {
            this.estado = false;
            this.color = "blanco";
        }

        public Foco(string color)   // constructor sobrecargado, con estado inicial apagado pero se requiere un color
        {
            this.estado = false;
            this.color = color;
        }

        ~Foco()  // finalizador o destructor
        {            /* cleanup statements... */        }

        public void cambiarEstado()     // metodo sobrecargado, apaga o enciende el foco
        {
            if (estado)
                this.estado = false;
            else
                this.estado = true;
        }

        public void cambiarEstado(string color)     // metodo sobrecargado; establece un color y cambia el estado (on/off) del foco
        {
            this.color = color;
            if (estado)
                this.estado = false;
            else
                this.estado = true;
        }
    }
}
