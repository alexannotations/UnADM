/* @author ESAD
 *  Se realizaron algunos ajustes a los ejemplos
 * 
 */
import javax.swing.JOptionPane;
import java.util.Scanner;

public class EstructurasControl {

    public static void main(String[] args){
/*        
        estructuraSWITCH();
        cicloWHILE();
        cicloDOWHILE();
        cicloFOR();
        cicloFOR_anidado();
        cicloFOR_anidadoDesc();
        cicloFOR_EACH();

        // Esta al final, porque se oculta el cuadro de dialogo JOptionPane

*/				
        estructuraIF(capturaCalificacion());
        IFanidado(capturaCalificacion());

    }

    public static int capturaCalificacion(){
        Scanner KeyBoardInput = new Scanner (System.in);
		System.out.print("Introduzca una calificacion entre 0 y 100: ");
		int calificacion = KeyBoardInput.nextInt();
		System.out.println("Indico: " +calificacion);
        return calificacion;
    }

    public static void estructuraIF(int calificacion){
                
        if(calificacion> 70){
        System.out.println("Aprobado");
        }   
        else{
        System.out.println("Reprobado");
        }
        System.out.println("Esto se imprimirá se cumpla o no la condición.\n");
    }
    

    public static void IFanidado(int calificacion){
        
        if(calificacion> 90 && calificacion <= 100){
        System.out.println("Excelente\n");
        }
        else if(calificacion >80 && calificacion <= 90){
        System.out.println("Muy Bien\n");
        }
        else if(calificacion >70 && calificacion <= 80){
        System.out.println("Bien\n");
        }
        else if(calificacion < 70){
        System.out.println("Muy mal\n");
        }
    }


    public static void estructuraSWITCH(){
        int mes= Integer.parseInt(JOptionPane.showInputDialog("Cuál es el número del mes"));

        switch(mes){
            case 1: System.out.print("Enero");
        break;
            case 2: System.out.print("Febrero");
        break;
            case 3: System.out.print("Marzo");
        break;
            case 4: System.out.print("Abril");
        break;
            case 5: System.out.print("Mayo");
        break;
            case 6: System.out.print("Junio");
        break;
            case 7: System.out.print("Julio");
        break;
            case 8: System.out.print("Agosto");
        break;
            case 9: System.out.print("Septiembre");
        break;
            case 10: System.out.print("Octubre");
        break;
            case 11: System.out.print("Noviembre");
        break;
            case 12: System.out.print("Diciembre");
        break;
            default:System.out.print("Mes no válido");
        }
    }


    public static void cicloWHILE(){
        int n= Integer.parseInt(JOptionPane.showInputDialog("Ingresa un numero"));
        while(n != 9){
            n= Integer.parseInt(JOptionPane.showInputDialog("Para salir Ingresa el 9"));
            }
    }
    

    public static void cicloDOWHILE(){
        int n;
        do{
            n= Integer.parseInt(JOptionPane.showInputDialog("Para salir Ingresa el 3"));
        }
        while(n != 3);
    }


    public static void cicloFOR(){
        int n= Integer.parseInt(JOptionPane.showInputDialog("Cuántos números quieres ver"));
        System.out.println();
        for(int i=1; i<=n; i=i+1){
            System.out.print(" "+i);
        }
        System.out.println();
    }


    public static void cicloFOR_anidado(){
        /* Como se puede ver, se tiene un ciclo dentro de otro.
         * Su manera de funcionar es que entra al primero, después al segundo y, 
         * hasta que el segundo termine sus repeticiones, 
         * el primero volverá a incrementar su valor y volverá a entrar al segundo 
         * tomando sus valores iniciales    */
        int n= Integer.parseInt(JOptionPane.showInputDialog("Cuantos temas son"));
        int m= Integer.parseInt(JOptionPane.showInputDialog("Cuantos subtemas contiene cada tema"));
        
        for(int i=1; i<=n; i=i+1){
            for(int j=1; j<=m; j=j+1){
                System.out.print(i+","+j);
                System.out.print("\n");
            }
        }
    }


    public static void cicloFOR_anidadoDesc(){
        /**  Si se quisieran anidar más de dos ciclos for es posible realizarlo, 
         * tomando en cuenta que siempre el ciclo que se encuentre más adentro será el que se realice primero.
         * También puede ser que el ciclo, en lugar de ir de manera ascendente, se realice de forma
         * descendente, para esto se debe tomar en cuenta que el inicio sea el último elemento, 
         * la condición de paro el 0 y su incremento sea restar 1   */
        int n= Integer.parseInt(JOptionPane.showInputDialog("Cuántos números quieres ver"));
        for(int i=n; i>0; i--){
            System.out.println(i);
        }
    }
    

    public static void cicloFOR_EACH(){
        /** Recorrer colecciones de objetos es mucho más comodo usando una instrucción forEach, 
         * que un bucle FOR clásico. 
         * En este caso tenemos una lista y la vamos a recorrer a través del método size que define el tope.    */
        String[] lista= new String[]{"hola","que","tal","estas"};
        
        for (int i=0;i<lista.length;i++) {
            System.out.println(lista[i]);
        }

        System.out.println();
        /** Java ForEach recorre la lista de elementos de una forma mas compacta y el código se reduce.
         * No se necesita saber cual es la propiedad que define el limite de la lista para recorrerla. 
         * Es decir no invocamos el método size o length. 
         * Porque el método forEach es una sintaxis sugar sobre el uso de iteradores a nivel del framework de Colecciones.
         * https://www.arquitecturajava.com/java-foreach-y-sus-opciones/
        */
        for(String cadena :lista) {
            System.out.println(cadena);
          }
    }
    
}
