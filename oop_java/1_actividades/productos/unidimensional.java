/* * * *
 * U4 A1
 * Crea un proyecto, que te permita leer y almacenar el nombre y precio de 10 productos comerciales; 
 * as� mismo el programa debe mostrar su nombre, su precio y posici�n para precios mayores o iguales a $500. 
 * @author AAC
 * 
 * */

package productos;
import java.util.Scanner;

public class unidimensional {
    
	public static void main(String args[]) {	
        int index = 10; //Se almacena en una variable las posiciones del arreglo
        Scanner keyBoard = new Scanner(System.in);
        //Se crean dos arreglos unidimensionales, al tratarse de dos tipos de datos
        String producto[] = new String[index];
        float precio[] = new float[index];

        System.out.println("\n\tProductos\n");

        System.out.println("\tIntroduce los datos segun se solicite:");
        for (int i = 0; i < index; i++) {
            System.out.print("\t\tNombre del producto [" +(i+1) +"]: ");
            producto[i] = keyBoard.nextLine();
            System.out.print("\t\tPrecio del producto [" +(i+1) +"]: ");
            try {
                precio[i] = keyBoard.nextFloat();

            }catch(Exception e) {
            	System.out.println(e);
            }
            keyBoard.nextLine(); /* (en el buffer queda el retorno de carro)
            captura el intro (nextLine) que no guardo nextFloat al almacenar el numero, 
            sin asignarlo, esto ocurre al querer leer un String despues de leer un numero */
        }

        //Impresi�n en pantalla
        System.out.println("\n\tPrograma que muestra solo los productos con precio mayor a $500.00\n");
        System.out.printf("\n\t%s\t%12.8s\t -> %.8s\n", "ID", "Producto", "Precio");	// funci�n de impresi�n con formato
        System.out.println("\t----------------------------------------");

        //Ciclo para mostrar unicamente precios mayores a 500
        for (int i = 0; i < index; i++) {
            if (precio[i] >= 500) {
                System.out.printf("\t%s %18.14s\t -> $ %,.2f\n", (i+1), producto[i] , precio[i]);
            }
        }
        
	}
}
