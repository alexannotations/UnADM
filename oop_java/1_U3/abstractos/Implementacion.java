/**
 * La implementación de clases y métodos abstractos se realiza mediante herencia, 
 * por lo tanto debe utilizarse la palabra clave extends.
 * Nótese que se utilizó herencia para la implementación de la clase abstracta y sus métodos 
 * (se utilizó implements), y para indicar esa implementación se añade la marca @Override 
 * antes de cada método implementado, lo que indica que éste había sido declarado 
 * en la clase abstracta y se está reescribiendo.
 */

package abstractos;

public class Implementacion extends AbstractaAreas{

     @Override
    public void areaCirculo(int r) {
        double areaCirculo= Math.PI *(r * r);
        System.out.println("El area del circulo es: "+areaCirculo);
    }

     @Override
    public void areaCuadrado(int l) {
        int areaCuadrado= l * l;
        System.out.println("El area del cuadrado es: "+areaCuadrado);
    }

     @Override
    public void areaRectangulo(int b, int a) {
        int areaRectangulo= b * a;
        System.out.println("El area del rectangulo es: "+areaRectangulo);
    }
}
   