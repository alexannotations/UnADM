package figuras;

public class FiguraMain {

	public static void main(String[] args) {

		// Crear un rectangulo R2
		Rectangulo r2 = new Rectangulo("Rectangulo 2", 2, 5);
		System.out.println(r2.calcularArea());
		System.out.println(r2.calcularPerimetro());

		// f1 es un objeto polimorfico
		// Puedo definir variables de tipo figura (tipo abstracto)
		Figura f1;
		// pero no se puede instanciar, marca error
		// Figura f = new Figura("F",2,3);
		// Se pueden almacenar objetos, o bien instanciar alguna clase concreta
		f1 = r2;
		Figura f2;
		f2 = new Rectangulo("r3", 6, 3);
		System.out.println(f2.calcularArea());
		// Ejemplos de polimorfismo con la misma variable f2
		// Observe como se asigna el tipo de objeto a la variable f2
		f2 = new Cuadrado("r3", 6, 3);
		System.out.println(f2.calcularArea());
		
		f2 = new Triangulo("r3", 6, 3);
		System.out.println(f2.calcularArea());
		
		
	}

}
