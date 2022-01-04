package centralAutobus;

import java.util.Scanner;

public class menu {
	
	private static int bus ;
	private static int seat;
	
	private static String opInvalida = "Elige una opción valida.";
	private static String op1 = "\n\t 1 Reservar asiento";
	private static String op2 = "\n\t 2 Cancelar asiento";
	private static String op3 = "\n\t 3 Consultar AUTOBUS";
	private static String op4 = "\n\t 9 Salir";
	
	private static String op31 = "\n\t 1 Todas las unidades";
	private static String op32 = "\n\t 2 Ocupación de un autobús";
	private static String op33 = "\n\t 3 Autobus y Asiento";
	
	private static String textoAutobus = "Indique el autobus: ";
	private static String textoAsiento = "Indique el asiento: ";
	
	// sin static genera error de sintaxis en los objetos
	static Scanner keyBoard = new Scanner(System.in);
	static bus autobus = new bus();
	
	public static void seleccionarOpciones() {
		int selectedOption = 0;
		
		do {
			
			System.out.println(op1 + op2 + op3 + op4);
			selectedOption = keyBoard.nextInt();
			
			switch (selectedOption) {
			case 1:
				 System.out.println("Reservar");
				 seleccionarBusSeat();
				 autobus.reservarAsiento(bus,seat);
				break;
	
			case 2:
				System.out.println("Cancelar");
				seleccionarBusSeat();
				autobus.cancelarAsiento(bus,seat);
				break;
			
			case 3:
				System.out.println("Consultar autobús:" +op31 +op32 +op33);
				selectedOption = keyBoard.nextInt();
				switch (selectedOption) {
				case 1:
					autobus.showFlotaBuses();
					break;

				case 2:
					System.out.print(textoAutobus);
					bus = keyBoard.nextInt();
					autobus.showBus(bus);
					break;
					
				case 3:
					seleccionarBusSeat();
					autobus.showBusSeat(bus,seat);
					break;
					
				default:
					System.out.println(opInvalida);
					break;
				}// end switch2
				break;
			
			case 9:
				System.out.println("Bye");
				break;
				
			default:
				System.out.println(opInvalida);
				break;
			} // end switch1
			
		}while(selectedOption != 9);
		
		keyBoard.close();
	} // END seleccionarOpciones()
	
	
	static void seleccionarBusSeat() {
		System.out.print(textoAutobus);
		bus = keyBoard.nextInt()-1;
		System.out.print(textoAsiento);
		seat = keyBoard.nextInt()-1;
	}
	
	
}
