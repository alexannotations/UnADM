/* La conversión de tipos de datos (conocida también como casting) 
 * es pasar un objeto de un tipo en otro. 
 */
public class Casting {
    
    public static void main(String[] args) {

        conversionEnteros();

    }


    static void conversionEnteros(){
        int di=33;
        int dv=5;
        int ci=di/dv;    // ci = 6
        System.out.println(ci);
        // Observe que el resultado se trunco
        // se realiza el casting
        float cd= (float) di/dv;
        System.out.println(cd+ "\n");
    }


    static void conversionClases(){
        /* En un ejemplo más amplio si se tienen 3 clases A, B y C 
        que se pueden almacenar en un arreglo de la siguiente manera: */
//        Object [] array = new Object[3];
//        array[0] = new A();
//        array[1] = new B();
//        array[2] = new C();  
        /* Si se quieren usar estos objetos, se tendrá que hacer un cambio entre resultados 
        que los tienes como array[i], que son Object, y no puedes llamar a métodos específicos 
        de las clases A, B y C.  */
//        ((A)array[0]).metodoDeA();
        /*  No puedes convertir cualquier tipo a cualquier tipo. 
        Si intentas convertir array[0] a B, te dará error, salvo que A herede de B. */

    }


}
