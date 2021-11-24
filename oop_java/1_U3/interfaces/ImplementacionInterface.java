package interfaces;
/**
 * @author ESAD
 * La implementación de la interface se utiliza la palabra reservada implements, 
 * la cual emula la herencia múltiple. Esto permite que se coloque la implementación 
 * de varias interfaces en una misma clase, colocando una coma (,) entre el nombre 
 * de las interfaces que se están implementado. Y al final la implementación cuenta 
 * con seis métodos, tres tomados de la primera interface y tres de la segunda.
 * 
*/
public class ImplementacionInterface implements InterfaceAreas, InterfacePerimetros{

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

    @Override
    public void perimetroCirculo(int r) {
    throw new UnsupportedOperationException("Not supported yet.");
    }

    @Override
    public void perimetroCuadrado(int l) {
    throw new UnsupportedOperationException("Not supported yet.");
    }

    @Override
    public void perimetroRectangulo(int b, int a) {
    throw new UnsupportedOperationException("Not supported yet.");
    }

}
