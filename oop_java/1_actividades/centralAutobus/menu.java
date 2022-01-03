package centralAutobus;

import java.util.Scanner;

public class menu {
	
	
	public static void seleccionarOpciones() {
		int selectedOption = 0;
		Scanner keyBoard = new Scanner(System.in);
		do {
			
			System.out.println("\n\t 1 Reservar asiento\n\t 2 Cancelar asiento\n\t 3 consultar AUTOBUS\n\t 9 Salir");
			selectedOption = keyBoard.nextInt();
			
			switch (selectedOption) {
			case 1:
				 System.out.println("Reservar");
				break;
	
			case 2:
				System.out.println("Cancelar");
				break;
			
			case 3:
				System.out.println("Consultar autobús");
				break;
			
			case 9:
				System.out.println("Saliendo . . .");
				break;
				
			default:
				System.out.println("Elige una opción valida.");
				break;
				
			} // end switch
			
		}while(selectedOption != 9);
		
		keyBoard.close();
	}
}
