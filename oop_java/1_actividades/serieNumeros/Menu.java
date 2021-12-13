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
		
		int key=0;
		Scanner inputKeyBoard = new Scanner(System.in);

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
				break;
			
			case 2:
				System.out.println("2");
				break;

			case 3:
				System.out.println("3");
				break;
				
			case 4:
				System.out.println("4");
				break;
				
			case 5:
				System.out.println("5");
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
