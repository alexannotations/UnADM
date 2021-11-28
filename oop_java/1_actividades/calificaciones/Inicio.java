package calificaciones;
import java.util.Scanner;

public class Inicio {

	public static void main(String[] args) {
		
		int group = 10;
		
		// Un array de objetos de la clase estudiante
		Estudiante student[] = new Estudiante[group];
		
		Scanner inputKeyBoard = new Scanner(System.in);
		
		for (int i = 0; i < group; i++) {
			student[i] = new Estudiante();
			// Se autoasigna un nombre por default
			String nombre = "Estudiante" +String.valueOf(i);
			student[i].setNombre(nombre);
			System.out.print("Indique la calificacion del " +student[i].getNombre() +": ");
			
			try {
				student[i].setCalificacion(inputKeyBoard.nextInt());
			} catch (Exception e) {
				System.out.println("Error: " +e);
			}
			
			
		}
		
		System.out.println("\nHa terminado de guardar las calificaciones\n\n");
		
		for (int i = 0; i < group; i++) {
			System.out.println(" " +student[i].getNombre() +" - " +student[i].getCalificacion());
		}
		
		

	}

	void aprobados(){}
	void reaprobados(){}
	void moda(){}
	void performance(){}
}
