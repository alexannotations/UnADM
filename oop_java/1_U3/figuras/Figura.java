/* * * * * * * * * 
 * Clases Abstractas y Polimorfismo
 * https://www.youtube.com/watch?v=2vOkWKJdJUQ&list=PLhU2otMFcLuCQPcEcRQfi3UQQ-ms5YH0L
 * La clase abstracta en su implementacion no esta completa, al no tener claro al 
 * menos el comportamiento de un metodo.
 * * * * * * * *  */
package figuras;

public abstract class Figura{
    // Atributos
    private String nombre;
    private double base;
    private double altura;

    /* Constructor con parametros
         La clase no se puede instanciar (directamente) al ser abstracta
        Esto no impide que tenga constructor, y se pueda invocar 
        a traves del super. para inicializar los atributos haciendo uso del polimorfismo
        Observe que no devuelve parametros, ni se indica */
    public Figura(String nombre, double base, double altura){
        this.nombre = nombre;
        this.base = base;
        this.altura = altura;
    }

    /* Metodos abstractos
        No se ponen llaves al no conocer la implementacion del metodo */
    public abstract double calcularArea();
    public abstract double calcularPerimetro();

    // Getters
    public double getBase(){
        return this.base;       // this hace referencia al atributo de la misma clase
    }

        public double getAltura(){
        return this.altura;
    }

}
