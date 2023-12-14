namespace DPRN2_U1_EA_ALAC
{
    internal class Test
    {
        /**
         * Prueba para verificar que se reciben los
         * parametros para inicializar la clase Color
         */
        public static void testColor()
        {
            Console.WriteLine("Test Color object");
            // Crea el objeto
            Color color = new Color("Moreno", 50);
            Console.WriteLine(color.Intensidad);

            // NO debe aceptar el parametro recibido
            Color color101 = new Color("Amarillo Simpsons", 101);
            Console.WriteLine(color101.Intensidad);
        }
    }
}
