/*
 * /* ** U3
 * Interfaces
 * Una interfaz no encapsula datos, solo define cuáles son los métodos que han de implementar los objetos 
 * de aquellas clases que implementan la interfaz.
 * 	- En java las interfaces se declaran con la palabra reservada interface de manera similar como se declaran las clases abstractas.
 * 	- Para indicar que una clase implementa una interfaz se utiliza la palabra reservada implements.
 * 	- La clase debe entonces implementar todos los métodos definidos por la interfaz.
 * 
 * Una clase puede implementar a la vez tantos interfaces como se desee, 
 * pero con un solo método de una solo interfaz que falte por implementar la clase será abstracta.
 * 
 * 
 * */
package transporte;

public class Aerosub implements IAereo, IAcuatico{

	public void despegar() {
		
	}
	
	
	public void acuatizar() {
		
	}
	
	
	public void emerger() {
		
	}
	
	
	public void sumergirse() {
		
	}
	

}
