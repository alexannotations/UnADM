package herencia;
/**
 * @author ESAD
 * Se están llamando las otras dos clases, observa que el objeto de la clase Estudiante 
 * asigna valores a sus cinco atributos y de la misma manera obtiene los datos y los imprime.
 */
public class Main {
    public static void main(String[] args){

    //primero se crean los objetos de Persona y Estudiante.
        Persona per=new Persona();
        Estudiante est=new Estudiante();

    //Colocar datos dentro del objeto persona
        per.colocarEdad(20);
        per.colocarNombre("Juan Perez");
        per.colocarPeso(80);

    //Se obtienen los datos de la persona para imprimirlos
        System.out.println("Nombre: "+per.obtenerNombre()+" Edad: "+per.obtenerEdad() 
            +" Peso: "+per.obtenerPeso());
        
    //Se colocan datos dentro del objeto estudiante
        est.colocarEdad(19);
        est.colocarNombre("Jose Hernandez");
        est.colocarPeso(60);
        est.colocarMatricula(1000011);
        est.colocarCarrera("Desarrollo de Software");
        System.out.println("Nombre: "+est.obtenerNombre()+" Edad: "+est.obtenerEdad() 
            +" Peso: "+est.obtenerPeso()+" Matricula: "+est.obtenerMatricula()
                +" Carrera: "+est.obtenerCarrera());
    } 
}
