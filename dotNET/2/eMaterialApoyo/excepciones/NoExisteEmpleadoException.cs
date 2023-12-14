/**
 * Excepción definida por el programador 
 * Se recomienda finalizar el nombre de la clase con "Exception"
 * Al definir una nueva excepcion, se deben implementar tres constructores. al sobre escribirlos, 
 * se agrega una nueva excepcion a la biblioteca proporcionada por C#
 * 
 *  Exception            ->     se produce por la interacción con el Framework .Net
 *  ApplicationException ->     se produce por la interaccion con un usuario
 *  
 *      Supone un medio para establecer diferencias entre 
 *      excepciones definidas por aplicaciones y 
 *      excepciones definidas por el sistema
 * 
 * Una excepcion debe ser serializable, 
 *  (puede convertirse en una secuencia de bytes, 
 *   permitiendo guardar el estado del objeto)
 * Si hereda de Exception o ApplicationException no es necesario realizar el proceso.
 *   
 *   
 * * */

namespace u3
{
    // CamelCaseException
    class NoExisteEmpleadoException : ApplicationException
    {
        // sin parametros
        public NoExisteEmpleadoException() 
        {
        }

        // con un mensaje como parametro
        public NoExisteEmpleadoException(string message) 
            : base(message) 
        {
        }

        // con posibilidad de pasar una excepcion interna anidada
        public NoExisteEmpleadoException(string message, ApplicationException inner) 
            : base(message, inner)
        {
        }


    }
}
