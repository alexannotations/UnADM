package abstractos;

public class principal {
	
	public static void main(String[] args) {
		
		Implementacion objetoAbstracto = new Implementacion();
		objetoAbstracto.areaRectangulo(3,6);


		/* Sobrecarga de métodos */
		Sobrecarga sumaSobrecargada = new Sobrecarga();
		int resultado = sumaSobrecargada.suma(3,3);
		System.out.println("Metodo sobrecargado1: " +resultado);
		
		resultado = sumaSobrecargada.suma(3,3,3);
		System.out.println("Metodo sobrecargado2: " +resultado);
		
		// con cast float to int
		resultado = (int)sumaSobrecargada.suma(3.5f,3.6f);
		System.out.println("Metodo sobrecargado3: " +resultado);
		
		float resultadof = sumaSobrecargada.suma(3.5f, 3.6f, 3.3f);
		System.out.println("Metodo sobrecargado4: " +resultadof);
		
	}

}
