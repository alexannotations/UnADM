using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    /**
     * Interface para representar un convenio de intercambio de alumnos
     * y son funcionalidades que deben realizar las clases que las implementan.
     * 
     * Las interfaces permiten definir características de comportamiento o capacidades, 
     * que se aplican a las clases sin tener en cuenta su jerarquía.
     * 
     * Mediante la utilización de interfaces se pueden implementar características de 
     * comportamiento múltiples en una única clase.
     * 
     */
    internal interface IConvenio
    {
        // firma de metodo
        void cambiaCarrera(string nuevaCarrera);
    }
}
