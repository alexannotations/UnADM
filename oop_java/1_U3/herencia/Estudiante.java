package herencia;
/**
 * @author ESAD
 * se colocó la palabra reservada extends en la declaración de la clase, seguida de Persona, 
 * lo que significa que esta clase está siendo heredada o extendida de la clase Persona.
 */
public class Estudiante extends Persona{ 
    int matricula;
    String carrera; 

    public void colocarMatricula(int m){
        matricula=m;
    } 
    public void colocarCarrera(String c){
        carrera=c;
    } 
    public int obtenerMatricula(){
        return matricula;
    } 
    public String obtenerCarrera(){
        return carrera;
    }
}
