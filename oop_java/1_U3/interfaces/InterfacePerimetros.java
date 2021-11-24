package interfaces;
/**
 * @author ESAD
 * En esencia una interface podría identificarse como lo mismo que una clase abstracta. 
 * La gran diferencia entre ellas y lo que justifica la existencia de las interfaces 
 * es el hecho de que pueden emular el comportamiento de la herencia múltiple, 
 * que no lo soportan las clases abstractas
 * 
 * Una interface se puede considerar una clase abstracta, 
 * de hecho en ella se toma en cuenta lo siguiente (Flanagan, 1997):
 *      1. Todos los miembros son públicos.
 *      2. Todos los métodos son abstractos.
 *      3. Todos los campos son static y final.
 * 
 *  * */

public interface InterfacePerimetros {

    public abstract void perimetroCirculo(int r);
    public abstract void perimetroCuadrado(int l);
    public abstract void perimetroRectangulo(int b, int a);

}

