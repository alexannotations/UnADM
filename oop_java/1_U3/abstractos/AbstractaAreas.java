/**
 * Las clases a partir de las cuales se pueden crear instancias se denominan "clases concretas".
 * Una clase abstracta es una clase que contiene los nombres de los comportamientos sin 
 * las implementaciones que ejecutan esos comportamientos. 
 * Los objetos no se pueden instanciar de una clase abstracta.
 * Cuando se hace la definición (declaración) de una clase abstracta, deberá ser antecedida
 * por el modificador abstract. Este tipo de clases puede contener métodos abstractos, que
 * son sólo la declaración de los mismos, pero sin la implementación de las instrucciones 
 * que se esperaría para cumplir el propósito para los cuales fueron escritos.
 * La implementación de dichos métodos se hace en las subclases.
 * El principal uso de estos elementos es crear una estructura de un sistema, 
 * lo que resulta útil para los analistas y arquitectos de software.
 *  */

package abstractos;

public abstract class AbstractaAreas {

    public abstract void areaCirculo(int d);
    public abstract void areaCuadrado(int l);
    public abstract void areaRectangulo(int b, int a);

}
/**
 * tanto la definición de la clase como de los métodos requiere colocar 
 * la palabra reservada abstract para indicar que ambos son abstractos. 
 * Y sólo se realiza su declaración, sin llegar a realizar la implementación de éstos.
 * Ademas un metodo abstract no debe ser privado, ni estatico.
 */

