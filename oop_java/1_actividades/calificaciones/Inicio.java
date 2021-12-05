/* * * * * * 
 * Un programa que calcule porcentaje de aprobados, porcentaje de reprobados y moda de la materia Programación Orientada a Objetos I,
 * con un listado mínimo de 10 estudiantes y al finalizar debe imprimir el listado de los estudiantes indicando el nivel de desempeño 
 * de cada uno y las estadísticas generales de la materia.
 * 		- Deberás solicitar se ingrese la calificación de cada alumno.
 * 		- De acuerdo al valor obtenido en la calificación, mostrarás el desempeño del estudiante.
 *  * */
package calificaciones;
import java.util.Scanner;

public class Inicio {

	public static void main(String[] args) {
		
		int group = 10;
		
		// Un array de objetos de la clase estudiante
		Estudiante student[] = new Estudiante[group];
		
		Clase materia = new Clase();
		Scanner inputKeyBoard = new Scanner(System.in);
		
		for (int i = 0; i < group; i++) {
			student[i] = new Estudiante();
			// Se autoasigna un nombre por default y se hace cast de int a String
			String nombre = "Estudiante" +String.valueOf(i);
			student[i].setNombre(nombre);
			System.out.print("Indique la calificacion del " +student[i].getNombre() +": ");
			try {
				int calificacion;
				do {
					calificacion = inputKeyBoard.nextInt();
					if (calificacion <0 || calificacion >100) {
						System.out.println("Introduzca un valor entre 0 y 100: ");
					} else {
						System.out.print(" OK ");
					}
				} while (calificacion <0 || calificacion >100);
				student[i].setCalificacion(calificacion);
			} catch (Exception e) {
				System.out.println("Error: " +e);
			}
		}
		
		
		System.out.println("\nHa terminado de guardar las calificaciones\n\n");
		
		System.out.println("\tNombre: " + " \tScore: " + " \tDesempeño: ");
		for (int i = 0; i < group; i++) {
			String studentName = student[i].getNombre();
			int studentScore = student[i].getCalificacion();
			String studentPerformance = materia.calculatePerformance(studentScore);
			System.out.println("\t" + studentName +" \t " +studentScore + " \t\t " +studentPerformance);
		}
		
			
		int calificacionAprobatoria = 60;
		
		for (int i = 0; i < group; i++) {
			if (student[i].getCalificacion()>=calificacionAprobatoria) {
				materia.oneAprobados();
			} else if(student[i].getCalificacion()<calificacionAprobatoria) {
				materia.oneReprobados();
			}
		}
		
		System.out.println("\n\tAprobados: " + materia.getAprobados() +"\n\tReprobados: " + materia.getReprobados());
		materia.getPercentage();
		
		
		System.out.println("\n\n");
		Estadistica estadistica = new Estadistica(group);
		int[] listaCalificaciones = new int[group];
		for (int i = 0; i < group; i++) {
			listaCalificaciones[i]=student[i].getCalificacion();
		}
		estadistica.calcularModa(listaCalificaciones);
		System.out.println("\n La moda es: " + estadistica.getModa());

	}

}
