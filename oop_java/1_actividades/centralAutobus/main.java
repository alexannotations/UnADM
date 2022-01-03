/* ****************
 * Tema: Boletos de Autobús.
 * El programa es para reservaciones o cancelaciones de asientos de autobús.
 * Generar un menú donde se presenten cuatro opciones: 1 Reservar, 2 cancelar, 3 consultar AUTOBUS y 4 salir. 
 * Utilizar un arreglo bidimensional para almacenar tres AUTOBUSES, con 50 espacios para ASIENTOS en cada AUTOBUS.
 * La distribución de las ASIENTOS por AUTOBUS estará representada en 4 por fila, y 13 filas en total.
 * El programa debe guardar inicialmente un 0 para representar cada asiento de los tres AUTUBUSES (arreglo).
 * Antes de reservar, se debe preguntar el número del AUTOBUS y qué ASIENTO se desea reservar; 
 * si este tiene un 1, estará reservado y no podrá reservarse mientas esté en 1. 
 * Si está en 0, cambiar a 1. En caso de cancelar, similar, pero debe estar en 1, para poder cambiar a 0.
 * La consulta simplemente solicita el número de AUTOBUS y mostrará los ceros y/o unos de este, 
 * siendo esto útil para saber cuáles ASIENTOS estarán libres u ocupados.
 * 
 * ****************/

package centralAutobus;

public class main {

	public static void main(String[] args) {

		menu.seleccionarOpciones();

	}

}
