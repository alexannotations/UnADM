/* ****************
 * Tema: Boletos de Autob�s.
 * El programa es para reservaciones o cancelaciones de asientos de autob�s.
 * Generar un men� donde se presenten cuatro opciones: 1 Reservar, 2 cancelar, 3 consultar AUTOBUS y 4 salir. 
 * Utilizar un arreglo bidimensional para almacenar tres AUTOBUSES, con 50 espacios para ASIENTOS en cada AUTOBUS.
 * La distribuci�n de las ASIENTOS por AUTOBUS estar� representada en 4 por fila, y 13 filas en total.
 * El programa debe guardar inicialmente un 0 para representar cada asiento de los tres AUTUBUSES (arreglo).
 * Antes de reservar, se debe preguntar el n�mero del AUTOBUS y qu� ASIENTO se desea reservar; 
 * si este tiene un 1, estar� reservado y no podr� reservarse mientas est� en 1. 
 * Si est� en 0, cambiar a 1. En caso de cancelar, similar, pero debe estar en 1, para poder cambiar a 0.
 * La consulta simplemente solicita el n�mero de AUTOBUS y mostrar� los ceros y/o unos de este, 
 * siendo esto �til para saber cu�les ASIENTOS estar�n libres u ocupados.
 * 
 * ****************/

package centralAutobus;

public class main {

	public static void main(String[] args) {

		menu.seleccionarOpciones();

	}

}
