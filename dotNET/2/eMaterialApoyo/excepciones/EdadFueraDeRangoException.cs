/**
 * 
 * 
 * * */

namespace u3
{
    class EdadFueraDeRangoException : ApplicationException
    {
        public EdadFueraDeRangoException():
            base("Ingresaste una edad fuera de rango de 18 - 65 años, son los valores permitidos por el IMSS")
        {

        }

        public EdadFueraDeRangoException(string mensaje):
            base(mensaje)
        {

        }


        public EdadFueraDeRangoException(string mensaje, Exception anidada):
            base(mensaje, anidada)
        {

        }

    }


    class EjecutarEjemploEdadFuera
    {
        static public byte leerEdad()
        {
            byte edad = 0;
            string tmp;

            System.Console.Write("Edad del trabajador: ");
            tmp = System.Console.ReadLine();

            try 
            {
                // al no poder realizar la conversion lanza un error FormatException
                edad = System.Convert.ToByte(tmp);
            }
            catch (FormatException fe)
            {
                System.Console.WriteLine("\n\nError no tecleaste un número." + fe);
            }
            finally 
            {
                // el bloque siempre se ejecuta
                // si la edad esta fuera del rango lanza la excepcion

                //// edad entre 18 y 65 años
                //if (edad < 18 || edad > 65)
                //    throw new EdadFueraDeRangoException();


                // si la edad no esta entre 25 y 40 años lanza la excepcion personalizada
                if (edad < 25 || edad > 40)
                    throw new EdadFueraDeRangoException("\nPor las caracteristicas del puesto el rango permitido debe ser entre 25 y 40 años.");

            }

            return edad;

        }
    }


}
