package figuras;
public class Rectangulo  extends Figura{
    // No tiene atributos como se observa en el diagrama UML

    // Constructor
    public Rectangulo(String nombre, double base, double altura){
        // super es para invocar al constructor parametrizado de figura (superclase) 
        super(nombre, base, altura);
    }

    // Metodos
    @Override
    public double calcularArea(){
        //return super.getBase() * super.getAltura();
    	return this.getBase() * this.getAltura();
    }

    @Override
    public double calcularPerimetro(){
        return 2*this.getBase() + 2*this.getAltura();
    }

}
