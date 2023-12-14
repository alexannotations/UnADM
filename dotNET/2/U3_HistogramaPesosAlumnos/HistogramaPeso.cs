namespace u3_a3_alac
{
    internal class HistogramaPeso
    {
        // campos encapsulados
        private int alumnos;
        private int[] pesos;
        private int pesoTmp;

        // miembros de acceso a campos
        public int[] Pesos 
        { 
            get => pesos; 
            set => pesos = value; 
        }


        // constructor
        // Normalmente un grupo esta compuesto de 120 estudiantes
        public HistogramaPeso() 
        {
            this.alumnos = 120;
            pesos = new int[this.alumnos];
            // pesos random para todos los estudiantes
            for (int i = 0; i < pesos.Length; i++)
                Pesos[i] = Repositorio.generarPesoRandom();
        }

        // Permite indicar la cantidad de alumnos a registrar
        public HistogramaPeso(int alumnos)
        {
            this.alumnos = alumnos;
            pesos = new int[alumnos];
        }


        // metodos

        public void ingresarPeso()
        {
            int index;

            try
            {
                Console.Write("Indique el indice del alumno: ");
                index = Convert.ToInt16(Console.ReadLine());

                Console.Write("Indique el peso del alumno: ");
                pesoTmp = Convert.ToInt16(Console.ReadLine());
                Pesos[index] = pesoTmp;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (pesoTmp < 40 || pesoTmp > 120)
                    throw new RangoFueraException("Los alumnos deben tener un peso entre 40 y 120 kg");
            }
        }   //

        /** Se manejan varias excepciones sobre la captura de datos del usuario */
        public void ingresarPeso(int index)
        {
            int peso;
            
            try {
                Console.Write($"Indique el peso del alumno[{index}]: ");
                peso = Convert.ToInt16(Console.ReadLine());
                if (!(peso > 40 && peso < 120))
                    throw new RangoFueraException("Indique un peso entre 40 y 120.");

                Pesos[index] = peso;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ingrese un número");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Indice fuera de rango");
            }
            catch (RangoFueraException e)
            {
                Console.WriteLine("Peso desconocido" + e);
            }

        }   //


        public void mostrarHistograma()
        {
            int rows = 80;  // pesos posibles entre 40 y 120
            int min = 40;   // peso minimo
            int[,] tablaConteo = new int[rows, 2];

            // Valores para el histograma
            //Console.WriteLine("Valores histograma");
            for (int i = 0; i < rows; i++)
            {
                tablaConteo[i,0] = min;
                min++;
                //Console.Write(tablaConteo[i,0] + " - ");
            }


            // ordena el array, aunque funciona sin importar si esta ordenado
            Array.Sort(pesos);

            // recorre el array que funciona como tabla
            Console.WriteLine("\n\tPesos Alumnos");
            for (int i = 0; i < rows; i++) 
            {
                tablaConteo[i, 1] = 0;
                // recorre el array  de pesos
                for (int j = 0; j < Pesos.Length; j++)
                {
                    // suma uno al valor del peso
                    if (tablaConteo[i,0] == Pesos[j])
                        tablaConteo[i, 1]++;
                }
            }

            // Muestra en pantalla el histograma
            Console.WriteLine("Peso - sum\t\tNúmero de estudiantes\n --------------------------------------------------");
            for (int i = 0; i < rows; i++)
            {
                // solo muestra los pesos que tienen al menos un alumno
                if (tablaConteo[i, 1]>0)
                {
                    Console.Write(tablaConteo[i, 0] + " kg - " + tablaConteo[i, 1] + "\t\t");
                    for (int j = 0; j < tablaConteo[i, 1]; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }

        }   //



    }
}
