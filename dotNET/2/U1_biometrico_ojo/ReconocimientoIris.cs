using System.Runtime.Intrinsics.X86;

namespace DPRN2_U1_EA_ALAC
{
    internal class ReconocimientoIris
    {
        Iris[] iris = new Iris[2];
        int coincidenciaPorcentaje;
        string elementosIdenticos;
        string identificacion;

        public ReconocimientoIris(Iris[] iris)
        {
            if (iris.Length==2)
                this.iris = iris;
            else
                Console.WriteLine("Debe ingresar un arreglo de 2 iris");
        }

        public int algoritmoUno() 
        {
            int coincidencia = 0;
            if (Enumerable.SequenceEqual(iris[0].PatronRayas, iris[1].PatronRayas))
            {
                elementosIdenticos += "Patrón rayas. ";
                coincidencia ++;
            }

            if (Enumerable.SequenceEqual(iris[0].Curvatura, iris[1].Curvatura))
            {
                elementosIdenticos += "Curvatura. ";
                coincidencia++;
            }

            return coincidencia;
        }

        public void algoritmoDos() 
        {   // compara todos
            int coincidencia = this.algoritmoUno();
            if (Object.Equals(iris[0].colorIris, iris[1].colorIris))
            {
                elementosIdenticos += "Color. ";
                coincidencia++;
            }
            if (iris[0].PatronTextura == iris[1].PatronTextura)
            {
                elementosIdenticos += "Patrón textura. ";
                coincidencia++;
            }
            if (iris[0].Forma == iris[1].Forma)
            {
                elementosIdenticos += "Forma. ";
                coincidencia++;
            }
            if (iris[0].Otros == iris[1].Otros)
            {
                elementosIdenticos += "Otros. ";
                coincidencia++;
            }
            this.coincidenciaPorcentaje= Convert.ToInt32(coincidencia*100/6);
        }

        public bool resultadoDeIdentificacion() 
        {
            // mostrar info
            Console.WriteLine(iris[0]);
            Console.WriteLine(iris[1]);
            Console.WriteLine("Coincidencia del: "+coincidenciaPorcentaje+"%");
            if (coincidenciaPorcentaje>80)
            {
                Console.WriteLine("Hay coincidencia");
                return true;
            }
            else
            {
                Console.WriteLine("NO coinciden");
                return false;
            }
        }

    }
}
