using System.Drawing;
using System.Text;

namespace SeguridadNacional
{

    class CifradoNombre : Cifrado
    {
        private string nombreEstudiante;
        private int desplazamiento;

        public string NombreEstudiante { get => nombreEstudiante; set => nombreEstudiante = value; }
        public int Desplazamiento { get => desplazamiento; }


        public CifradoNombre(string nombre, string mensaje) : base(mensaje)
        {
            NombreEstudiante = nombre;
        }



        /**
         * Asigna un valor numérico a cada carácter de tu nombre.
         * Suma todos los dígitos para obtener un desplazamiento.
         * Desplaza n posiciones las letras del mensaje original.
         * 
         * * */
        new public void Cifrar()
        {
            //base.Cifrar();
            Console.WriteLine(" ... llamando al miembro Cifrar de la clase CifradoNombre");

            /**
             * Console.WriteLine(i + " - " + Char.ToString( Convert.ToChar(i)) + " - " + (i-64));
             * ASCII
             *      A[65] - Z[90]   -64[1 - 26]
             *      a[97] - z[122]  -64[33 - 58]
             *  
             *  char letra.ToUpper()   
             *  Convertimos a mayúsculas para facilitar la asignación del valor
             *  pero prodría omitirse y asignar un numero a cada letra segun sea mayúscula o minúscula
             *  
             *              
             //string letras;
             //// Obtener los valores ASCII del abecedario
             //for (int i = 60; i < 130; i++)
             //{
             //    byte[] valores = { 65, 66, 67 }; // Los códigos ASCII de las letras A, B y C
             //    letras = Encoding.ASCII.GetString(valores); // letras = "ABC"
             
             //    // Muestra la relación de letras con su valor numérico
             //    Console.WriteLine(i + " - " + Char.ToString(Convert.ToChar(i)) + " - " + (i - 64));
             //}
             *  
             *  */

            string mayusculas = NombreEstudiante.ToUpper();

            byte[] bytes = Encoding.ASCII.GetBytes(mayusculas); // Los códigos ASCII de las letras del mensaje
            // Crear un nuevo array de bytes para el mensaje cifrado. NO se puede asignar directamente: bytesCifrado = bytes;
            byte[] bytesCifrado = new byte[bytes.Length];
            Array.Copy(bytes, bytesCifrado, bytes.Length); // Copiar los elementos de bytes en bytesCifrado

            int acumulador = 0;
            int suma = 0;

            foreach (byte valorLetra in bytes) // Recorrer cada elemento 'valorLetra' del array 'bytes'
            {
                int i = valorLetra - 64; // Conversión implícita de byte a int, con resta para asignar 1 a 'A'
                acumulador += i;    // suma los valores de las letras
            }

            while (acumulador > 0) // El acumulador se va reduciendo para sumar las unidades de un numero
            {
                suma = suma + acumulador % 10; // Suma el último dígito (unidad) del número a la suma
                acumulador = acumulador / 10; // Quitar el último dígito del número
            }

            desplazamiento = suma;  // Desplazamiento es de solo lectura

            for (int i = 0; i < bytes.Length; i++)
            {
                bytesCifrado[i] = (byte)(bytes[i] + Desplazamiento); // Sumar el desplazamiento al elemento actual de bytes y asignarlo a bytesCifrado
            }
            // se hace un encoding a los bytes para obtener el mensaje cifrado
            string nombreCifrado = Encoding.ASCII.GetString(bytesCifrado);

            Console.WriteLine("Desplazamiento: " + Desplazamiento + " Nombre cifrado: " + nombreCifrado);
        }

        internal override void DestruirMensaje()
        {
            base.DestruirMensaje();     // invoca al metodo oculto de la clase padre
            Console.WriteLine("y nombre ... ");
            NombreEstudiante = null;
        }
    }


}