/** Sobrecarga de métodos
 * Permite declarar varios métodos con el mismo nombre dentro de una sola clase.
 * se requieren métodos que realizan prácticamente las mismas acciones, 
 * pero de manera diferente.
 * La sobrecarga de los operadores permite redefinir las funciones que 
 * se le asignan por definición a un operador. Por ejem. '+' puede sumar o unir.
 * */
package abstractos;

/**
* @author ESAD
*/
public class Sobrecarga {

    // Recibe  dos parámetros enteros
    public int suma(int a, int b){
        return a+b;
    }

    // Recibe tres parámetros enteros
    public int suma(int a, int b, int c){
        return a+b+c;
    }

    // Recibe dos parámetros de tipo flotante
    public float suma(float a, float b){
        return a+b;
    }

    // Recibe tres flotantes
    public float suma(float a, float b, float c){
        return a+b+c;
    }

}
