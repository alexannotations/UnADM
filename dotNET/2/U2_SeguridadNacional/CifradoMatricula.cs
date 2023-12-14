using System.Text.RegularExpressions;

namespace SeguridadNacional
{

    class CifradoMatricula : Cifrado
    {
        private string matricula;
        public string Matricula { get => matricula; set => matricula = value; }

        public CifradoMatricula(string matricula, string mensaje) : base(mensaje)
        {
            Matricula = matricula;
        }


        public void EnviarMensaje(string medioDeEnvio)
        {
            Console.WriteLine("\nLa Matricula {0} será enviado por: {1}", Matricula, medioDeEnvio);
        }


        public void EnviarMensaje(int guia )
        {
            this.EnviarMensaje("Empresa de paqueteria.");
            Console.WriteLine(" Con número de guía para envió físico: " + guia);
        }


        internal override void DestruirMensaje()
        {
            base.DestruirMensaje();     // invoca al metodo oculto de la clase padre
            Console.WriteLine("y matrícula ... ");
            Matricula = null;
        }



        /**
 * Tomar mensaje a cifrar”
 * Tomar dígitos de matrícula de estudiante (convertir)
 * Introducir dentro de la cadena la posición de cada digito
 *      
 * [posicion-n][letra-n_deMensaje]
 * 
 * * */
        new public void Cifrar()
        {
            /* Se intercalan los numeros uno a uno entre las letras */
            //base.Cifrar();
            Console.WriteLine(" ... llamando al miembro Cifrar de la clase CifradoMatricula");

            // el patrón  @"\d+"  significa una o más repeticiones del dígito \d
            // el @ indica que la cadena se debe interpretar literalmente, sin escapar caracteres
            // solo se obtine el primer patrón numérico
            string number = Regex.Match(matricula, @"\d+").Value;
            char[] ordenedNumber = number.ToCharArray();    // crea un array con cada carácter del string 
            Array.Sort(ordenedNumber);  // los ordena unidimensionalmente


            // verificamos si existe un mensaje
            if (MensajeACifrar != null)
            {
                // checamos cual es la cadena más larga
                int max = (MensajeACifrar.Length > ordenedNumber.Length) ? MensajeACifrar.Length : ordenedNumber.Length;
                int min = (MensajeACifrar.Length < ordenedNumber.Length) ? MensajeACifrar.Length : ordenedNumber.Length;
                int maxNumberM = (int)Char.GetNumericValue(ordenedNumber[ordenedNumber.Length - 1]);

                char[] msjcfr = MensajeACifrar.ToCharArray();
                string newmsj = null;

                // Intercala los numeros segun su orden entre el mensaje
                for (int i = 0; i < max; i++)
                {
                    // Si el índice es menor que la longitud matricula, añadir el número al nuevo mensaje
                    if (i < ordenedNumber.Length)
                    {
                        newmsj = newmsj + ordenedNumber[i];
                    }
                    // Si el índice es menor que la longitud del mensaje, añadir el carácter al nuevo mensaje
                    if (i < msjcfr.Length)
                    {
                        newmsj = newmsj + msjcfr[i];
                    }
                }

                MensajeCifrado = newmsj;
                Console.WriteLine("El mensaje Encriptado: " + MensajeCifrado);
            }
            else
            {
                Console.WriteLine("No hay mensaje a cifrar");
            }

        }



        public void OCifrar()
        {
            /* agrupa los numeros pero en mensajes cortos faltan los mayores y no muestra el ultimo num. 
                y en mensajes largos agrega un numero extra si hay 2 numeros o más y no muestra el ultimo no.*/
            Console.WriteLine(" ... ");

            string number = Regex.Match(matricula, @"\d+").Value;
            char[] ordenedNumber = number.ToCharArray();
            Array.Sort(ordenedNumber);
            string MensajeCifrado;
            //Console.WriteLine(ordenedNumber);

            // verificamos si existe un mensaje
            if (MensajeACifrar != null)
            {
                char[] msjcfr = MensajeACifrar.ToCharArray();
                string newmsj = null;

                // checamos cual es la cadena más larga
                int max = (MensajeACifrar.Length > ordenedNumber.Length) ? MensajeACifrar.Length : ordenedNumber.Length;
                int min = (MensajeACifrar.Length < ordenedNumber.Length) ? MensajeACifrar.Length : ordenedNumber.Length;
                int maxNumberM = (int)Char.GetNumericValue(ordenedNumber[ordenedNumber.Length - 1]);
                int cn = 0, cm = 0;
                //Console.WriteLine(max + "-" + min + "-" + maxNumberM + "-");


                //intercalamos la matricula con el mensaje
                for (int i = 0; i < max; i++)
                {
                    for (int j = 0; j < min; j++)
                    {
                        cn = j;
                        while (cn < maxNumberM && i == (int)Char.GetNumericValue(ordenedNumber[cn]))
                        {
                            newmsj = newmsj + ordenedNumber[cn];
                            //Console.WriteLine(i + "-" + j + "<" + newmsj + ">");
                            cn++;
                        }
                    }

                    if (i < msjcfr.Length)
                    {
                        newmsj = newmsj + msjcfr[i];
                    }
                    //Console.WriteLine(i + "<" + newmsj + ">");
                }

                MensajeCifrado = newmsj;
                Console.WriteLine("El mensaje Encriptado: " + MensajeCifrado);

            }
            else
            {
                Console.WriteLine("No hay mensaje a cifrar");
            }

        }



    }

}