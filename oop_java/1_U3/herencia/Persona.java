
package herencia;
/**
 * @author ESAD
 * La clase Persona cuenta con tres atributos (edad, peso, nombre) y con seis métodos 
 * para colocar y obtener los valores de los atributos. Observa que los tres atributos 
 * se encuentran a nivel de clase, lo que significa que podrán ser utilizados en toda ella.
 * 
*/

public class Persona {
    int edad;
    float peso;
    String nombre;

    public void colocarEdad(int e){
        edad=e;
    } 

    public void colocarPeso(float p){
        peso=p;
    }

    public void colocarNombre(String n){
        nombre=n;
    }

    public int obtenerEdad(){
        return edad;
    }

    public float obtenerPeso(){
        return peso;
    } 

    public String obtenerNombre(){
        return nombre;
    }
}
    