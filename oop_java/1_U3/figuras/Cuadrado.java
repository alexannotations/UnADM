package figuras;
public class Cuadrado  extends Figura{


    // Constructor
    public Cuadrado(String nombre, double base, double altura){
        // super es para invocar al constructor parametrizado de figura (superclase) 
        super(nombre, base, altura);
    }

    // Metodos
    @Override
    public double calcularArea(){
    	return 2.0;
    }

    @Override
    public double calcularPerimetro(){
        return 2.0;
    }

}
