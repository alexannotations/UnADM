/* Esta clase puede ser abstracta, por los diferentes tipos de triangulos
 */

package figuras;
public class Triangulo  extends Figura{

    // Constructor
    public Triangulo(String nombre, double base, double altura){
        // super es para invocar al constructor parametrizado de figura (superclase) 
        super(nombre, base, altura);
    }

    // Metodos
    @Override
    public double calcularArea(){
    	return 3.0;
    }

    @Override
    public double calcularPerimetro(){
        return 3.0;
    }

}
