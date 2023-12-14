/**
 * Alejandro Ayala Castro
 * octubre 2023
 * 
 */

namespace DPRN2_U1_EA_ALAC
{
    internal class ReconocimientoFacial
    {
        // Campos
        private Rostro[] rostros;
        private int porcentajeCoincidencia;
        private string elementosIdenticos;
        private bool identificacion;    // al menos >80% de coincidencia

        // constructor
        public ReconocimientoFacial(Rostro rostro1, Rostro rostro2)
        {
            this.rostros = new Rostro[] { rostro1, rostro2 };     // se instancia un array de 2 rostros
            Identificacion = false;
        }

        // Constructor sobrecargado
        public ReconocimientoFacial(Rostro[] rostro)
        {
            if (rostro.Length==2)
            {
                this.rostros = new Rostro[2]; // se instancia un array de 2 rostros
                for (int i = 0; i < 2; i++)
                    this.rostros[i] = rostro[i];
            }
            Identificacion = false;
        }

        // finalizador o destructor
        ~ReconocimientoFacial() { Console.WriteLine("El objeto ReconocimientoFacial ha sido finalizado"); }


        // Propiedades
        public int PorcentajeCoincidencia { get => porcentajeCoincidencia; set => porcentajeCoincidencia = value; }
        public string ElementosIdenticos { get => elementosIdenticos; set => elementosIdenticos = value; }
        public bool Identificacion { get => identificacion; set => identificacion = value; }

        // Miembros
        /**
         * Compara los rasgos faciales y la edad de los dos rostros 
         * para determinar la coincidencia.
         */
        public void algoritmoUno() 
        {
            // Se debe inicializar el arreglo, porque esto puede provocar una excepción de índice fuera de los límites del arreglo
            string[][] rasgosf = new string[2][]; 
            for (int i = 0; i < 2; i++)
                rasgosf[i] = alinearRasgos(rostros[i].RasgosFaciales);  // alinearRasgos retorna un array

            // el 50% de coincidencia al total de los rasgos
            int coincidenciaRasgos = compararRasgos(rasgosf[0], rasgosf[1]) / 2;
            // el 50% a la edad
            int coincidenciaEdad = (rostros[0].Edad == rostros[1].Edad) ? 50 : 0;
            PorcentajeCoincidencia = coincidenciaEdad + coincidenciaRasgos;
            Identificacion = (PorcentajeCoincidencia >= 80) ? true : false;
            Console.WriteLine("\n> > > > > > > > > > Algoritmo UNO");
        }


        /**
         * Compara todos los atributos del rostro 
         * para determinar la coincidencia.
         */
        public void algoritmoDos() 
        {
            // Otra forma de trabajar los rasgos faciale, en lugar del arreglo bidimensional
            string[] rasgos1 = alinearRasgos(rostros[0].RasgosFaciales);
            string[] rasgos2 = alinearRasgos(rostros[1].RasgosFaciales);

            // el 20% de coincidencia al total de los rasgos
            int coincidenciaRasgos = compararRasgos(rasgos1, rasgos2) * 2;
            // el 30% a la edad
            int coincidenciaEdad = (rostros[0].Edad == rostros[1].Edad) ? 300 : 0;

            int cPatron= compararAtributo(rostros[0].PatronTextura, rostros[1].PatronTextura) ? 100 : 0;
            int cForma = compararAtributo(rostros[0].Forma, rostros[1].Forma) ? 100 : 0;
            int cOtros = compararAtributo(rostros[0].Otros, rostros[1].Otros) ? 100 : 0;
            // ColorPiel
            int cTono = compararAtributo(rostros[0].ColorPiel.Tono, rostros[1].ColorPiel.Tono) ? 100 : 0;
            int cIntensidad = (rostros[0].ColorPiel.Intensidad == rostros[1].ColorPiel.Intensidad) ? 100 : 0;

            PorcentajeCoincidencia = (coincidenciaEdad + coincidenciaRasgos+ cPatron+ cForma+ cOtros+ cTono+ cIntensidad)/10;
            Identificacion = (PorcentajeCoincidencia >= 80) ? true : false;
            Console.WriteLine("\n> > > > > > > > > > Algoritmo DOS");
        }


        /**
         * Muestra la información de ambos rostros, 
         * su porcentaje de coincidencia, 
         * los elementos faciales idénticos y
         * si pasa o no el proceso de identificación.
         */
        public void resultadoDeIdentificacion() 
        {
            Console.WriteLine("\nEl porcentaje de coincidencia es: " + PorcentajeCoincidencia + "%");
            Console.WriteLine((Identificacion ? "Pasa" : "NO pasa") + " el proceso de identificación ") ;
            Console.WriteLine("\nElementos faciales identicos: " + ElementosIdenticos);
            for (int i = 0; i < 2; i++) 
            {
                Console.WriteLine($"\nInformación del rostro {i+1}.");
                rostros[i].mostrarDatosRostro();
            }
        }


        private bool compararAtributo(string atributo1, string atributo2)
        {
            // Comparación ordinal que no distingue entre mayúsculas y minúsculas
            return atributo1.Equals(atributo2, StringComparison.OrdinalIgnoreCase);
        }


        private int compararRasgos(string[] rasgo1, string[] rasgo2)
        {
            int contador=0;
            int maxLength;
            ElementosIdenticos = "";

            // determinamos cual es el array mayor
            if (rasgo1.Length > rasgo2.Length)
                maxLength = rasgo1.Length;
            else
                maxLength = rasgo2.Length;

            // comparamos todas las coincidencias del array
            for (int i = 0; i < rasgo1.Length; i++)
            {
                for (int j = 0; j < rasgo2.Length; j++)
                {
                    if (rasgo1[i] == rasgo2[j])
                    {
                        contador++;
                        ElementosIdenticos += rasgo2[j] + ", ";  // Guardamos los elementos identicos
                    }
                }
            }

            // Determinamos el % de coincidencia
            return (contador * 100 / maxLength * 100) / 100;
        }


        private string[] alinearRasgos(string rasgosFaciales) 
        {
            // dividimos el atributo separado por comas
            // para crear un array con los rasgos
            string[] rasgos = rasgosFaciales.Split(',');

            // limpia los valores y los reasigna nuevamente en el array
            for (int i = 0; i < rasgos.Length; i++)
                rasgos[i] = rasgos[i].Trim();

            // Ordenamos los rasgos y los regresamos
            Array.Sort(rasgos);
            return rasgos;
        }

    }   // end class

}
