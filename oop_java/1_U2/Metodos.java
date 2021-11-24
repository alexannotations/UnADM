/*
 * En Java los parámetros de tipo primitivo (int, long, double, …) siempre se pasan por valor.
 * Las variables de tipo objeto y arrays se pasan por referencia 
 * a su dirección de memoria de alojamiento.
 */

public class Metodos {

    // Metodo que no devuelve parametros, ni recibe parametros
    public static void saludar_usuario(){
        String cadena_Saludo = "Hola usuario, feliz viaje en Java";
        System.out.println(cadena_Saludo);
        System.out.println("Mensaje impreso desde un método");
    }
    

    //  Método que recibe, devuelve valores
    public int obtener_potencia(int base, int potencia){
        int resultado = (int) Math.pow(base, potencia);
        return resultado;
        }
        

    // Método principal
    public static void main(String[] args){

        // Se invoca o llama al metodo static
        saludar_usuario();
        
        // se crea el objeto para utilizar el metodo
        Metodos objetoMetodo = new Metodos();
        int b = 3;
        int p = 3;
        // se hace cast de Int a String, podria tambien recibirse como int
        String resultado = Integer.toString(objetoMetodo.obtener_potencia(b,p));
        System.out.println("El resultado de la potencia es: " +resultado);
    }
            
}
