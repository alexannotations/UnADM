/* ** U3
 * Para poder declarar dentro de cualquier código una operación como abstracta 
 * se usa la palabra reservada abstract antes del tipo de retorno. 
 * 		Por ejemplo:		Public abstract String getNombre();
 * 
 * En relación al ejemplo, debes tener en cuenta que estas clases se declaran utilizando 
 * la palabra reservada abstract y que no se puede utilizar la palabra clave new cuando se están implementado; 
 * además de que la clase abstracta está pensada para ser 
 * la clase principal y definir las subclases.
 * 
 * Una clase abstracta se utiliza cuando deseamos definir una abstracción que englobe objetos de distintos tipos 
 * y queremos hacer uso del polimorfismo.
 *  
 * */
package transporte;

public class Inicio {

	public static void main(String[] args) {

		Terrestre carrito = new Terrestre();
		carrito.mostrarInformacion();

		/*
		 // La clase vehiculo no se puede instanciar al ser abstracta 
		Vehiculo unTransporte = new Vehiculo();
		*/
		
		Acuatico barquito = new Acuatico();
		barquito.mostrarInformacion();

		Aereo avioncito = new Aereo();
		avioncito.mostrarInformacion();
		
        Avion A380 = new Avion();
        A380.setNombre("A380");
        A380.mostrarInformacion();
        
        Avioneta cessnaSkylane = new Avioneta();
        cessnaSkylane.setNombre("cessnaSkylane");
        cessnaSkylane.mostrarInformacion();
        
        Auto cocheCivic = new Auto("Honda", "Civic");
        cocheCivic.setNombre("mi nave");
        cocheCivic.mostrarInformacion();
		
	}

}
