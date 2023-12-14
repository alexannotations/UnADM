namespace u3_a2_alac
{
    internal class NumeroExcept
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Ingrese un número: ");
                // variable a dividir
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                // diferente de cero
                int result = 10 / number;
                Console.WriteLine("El resultado es: " + result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("El numero debe ser diferente de cero: " + ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Debe introducir un número: " + ex);
            }


            try
            {
                string[] names = { "Alice", "Bob", "Charlie" };
                // el indice max es 2
                Console.WriteLine("Ingresa un índice para obtener un nombre: ");
                // índice a mostrar
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El nombre selecionado es: " + names[index]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("El numero es mayor a los indices disponibles: " + ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Debe introducir un número: " + ex);
            }


            try
            {
                Console.WriteLine("Ingrese una cadena para dividir: ");
                // cadema de más de 5 para no lanzar la excepción
                string text = Console.ReadLine();
                int length = 5;
                string subString = text.Substring(0, length);
                Console.WriteLine("La subcadena es: " + subString);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("La cadena es demasiado corta: " + ex);
            }
            finally { Console.WriteLine("El programa ha finalizado correctamente."); }

        }
    }
}