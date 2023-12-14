/** 
 * Ejemplo desarrollado por IA
 * 
 * 
 * */
namespace u3
{
    class Producto
    {
        // Definimos un campo privado que almacena el precio del producto
        private decimal precio;

        // Definimos una propiedad pública que permite acceder al precio del producto
        public decimal Precio
        {
            // El método get devuelve el valor del campo precio
            get
            {
                return precio;
            }
            // El método set asigna un valor al campo precio, pero solo si es positivo
            set
            {
                // Usamos un bloque try-catch para controlar la excepción que se puede producir si el valor es negativo
                try
                {
                    // Si el valor es negativo, lanzamos una excepción personalizada con un mensaje
                    if (value < 0)
                    {
                        throw new ArgumentException("El precio no puede ser negativo");
                    }
                    // Si el valor es positivo, lo asignamos al campo precio
                    precio = value;
                }
                // Capturamos la excepción y mostramos el mensaje de error por la consola
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }


        // Definimos un constructor que recibe el precio del producto como parámetro
        public Producto(decimal precio)
        {
            // Asignamos el precio del producto usando la propiedad Precio
            Precio = precio;
        }


    }
}
