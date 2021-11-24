/**
 *  Cuando algún error ocurre, la máquina virtual Java crea un objeto de la clase exception, 
 * se notifica el hecho al sistema de ejecución y se dice que se ha lanzado una excepción.
 * Se generará una excepción interrumpiendo la ejecución del programa. La manera de evitar esto 
 * es realizando un manejo de dicha excepción. Esto se efectúa mediante la sentencia try-catch.
 * 
 *  El bloque de sentencias que pudiera tener un error se coloca dentro del bloque try{ }, 
 * y en el bloque catch(){} se coloca el tipo de error y el nombre dado, normalmente siempre es e, 
 * entonces una vez que atrapa el error lo imprime a pantalla para que el usuario conozca el error, 
 * todo esto sin provocar un cierre inesperado del código.
 * 
 *  */

package excepciones;

class EjemploExcepcion{

    public static void main(String argumentos[]){

        try{
            int i = 5, j = 0;
            int k = i/j;    // Division entre cero
        }
        // catch (tipo_de_error nombre_error)
        catch(java.lang.ArithmeticException e){
            System.out.println("Se produjo un error: " + e);
        }

    }

}
