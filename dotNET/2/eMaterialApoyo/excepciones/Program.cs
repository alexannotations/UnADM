/** 
 * Si se tiene un programa que llama a un objeto y el objeto llama a un método que lanza una 
 * excepción, se inicia un proceso recursivo.
 * Primero se espera que el método que lanzó la excepción tenga código para su control; 
 * si el método no tiene control para la excepción se espera que el objeto procese la excepción; 
 * si este no tiene código para su control, se espera que el programa inicial que llamó al objeto controle el problema;
 * si éste no tiene código de control, el programa se detiene y muestra la ventana de error. 
 * A esto se le conoce como propagación de la excepción. (Archer, 2010).
 * 
 * 
 * Para provocar un error y generar un objeto exception
 * puede introducir una letra o string, o un flotante
 * 
 * */

namespace u3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // eTipoConversion.Ejecutar();

            // eEscrituraHDD.Ejecutar();

            //lanzarExcepcionPersonalizada();

            ejemploIA();



        }

        public static void lanzarExcepcionPersonalizada()
        {
            byte edad;
            try
            {
                // lanza la excepcion personalizada al no cumplir el rango de edad
                edad = EjecutarEjemploEdadFuera.leerEdad();
            }
            catch (EdadFueraDeRangoException efdre)
            {
                // si se quita el objeto Exception, no aparece el mensaje "Por las caract..."
                System.Console.WriteLine("\nNo es una edad valida. " + efdre.ToString());
            }
            finally
            {
                // en todos los casos siempre se ejecuta
                System.Console.Read();
            }
        }

        public static void ejemploIA()
        {
            // Creamos un objeto de la clase Producto con un precio válido
            Producto p1 = new Producto(10.5m);
            // Mostramos el precio del producto por la consola
            Console.WriteLine("El precio del producto 1 es: " + p1.Precio);

            // Creamos otro objeto de la clase Producto con un precio inválido
            Producto p2 = new Producto(-5m);
            // Mostramos el precio del producto por la consola
            Console.WriteLine("El precio del producto 2 es: " + p2.Precio);
        }


    }
}