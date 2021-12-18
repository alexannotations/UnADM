package serieNumeros;

import java.util.Scanner;

public class Menu {

private String op1 = "\n1 - Ingresar intervalo de numeros.";
private String op2 = "\n2 - Ordenar ascendente.";
private String op3 = "\n3 - Ordenar descendente.";
private String op4 = "\n4 - Extraer pares.";
private String op5 = "\n5 - Extraer impares.";
private String op6 = "\n6 - Factorial.";
private String op7 = "\n7 - Acumular de factoriales.";
private String op9 = "\n9 - Salir.";

	public void opciones() {
		
		boolean aceptacion;
		int key=0;
		Scanner inputKeyBoard = new Scanner(System.in);
		Numero numeros = new Numero();
		int[] serieNumerica;

		do {
			System.out.println(op1+op2+op3+op4+op5+op6+op7+op9);
			
			try {
				key = inputKeyBoard.nextInt();
			} catch (Exception e) {
				System.out.println("Error: " +e);
			}
			
			switch (key) {
			case 1:
				System.out.println("1");
				System.out.println("Indica los valores cuando se indique:");
				 do{
					System.out.print("\nValor Superior: ");
					int sup = inputKeyBoard.nextInt();
					System.out.print("\nValor Inferior: ");
					int inf = inputKeyBoard.nextInt();
					aceptacion = numeros.setRango(sup, inf);
				}while (aceptacion==false);
				System.out.println("Los valores introducidos son: " +numeros.getRangoInferior() +" - "+numeros.getRangoSuperior() +" . " +aceptacion);
				numeros.generaSerieNumerica();
				break;
				
			
			case 2:
				// La serie se genera en orden, por lo que no se ordena
				System.out.println("2");
				serieNumerica = numeros.getSerieNumerica();
				for (int i = 0; i < serieNumerica.length; i++) {
					System.out.println(" - " + serieNumerica[i] +" - ");
				}
				break;

			case 3:
				// La serie se genera en orden, por lo que no se ordena
				// Corregir el error si no exite el arreglo
				System.out.println("3");
				serieNumerica = numeros.getSerieNumerica();
				for (int i = serieNumerica.length; i >= 0; i--) {
					System.out.println(i);
					System.out.println(" - " + serieNumerica[i] +" - ");
				}
				System.out.println(serieNumerica.length);
				break;
				
			case 4:
				System.out.println("4");
				serieNumerica = numeros.getSerieNumerica();
				for (int i = 0; i < serieNumerica.length; i++) {
					if (serieNumerica[i]%2==0) {
						System.out.println(" - " + serieNumerica[i] +" - ");
					}
				}				
				break;
				
			case 5:
				System.out.println("5");
				serieNumerica = numeros.getSerieNumerica();
				for (int i = 0; i < serieNumerica.length; i++) {
					if (serieNumerica[i]%2==1) {
						System.out.println(" - " + serieNumerica[i] +" - ");
					}
				}	
				break;
				
			case 6:
				System.out.println("6");
				break;
				
			case 7:
				System.out.println("7");
				break;
				
			case 9:
				System.out.println("9 - Saliendo");
				break;
				
			default:
				System.out.println("Elige una opción valida.");
				break;
			} // end switch
			
		} while (key!=9);
		
	}	// end opciones()
	
}
