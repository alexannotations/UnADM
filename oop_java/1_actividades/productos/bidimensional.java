/* * * *
 * U4 A2
 * Se solicita implementar dos arreglos; uno unidimensional tipo String, donde se guardarán los nombres de los productos desde el teclado. 
 * Para aplicar un arreglo multidimensional, solicitar tres precios por producto, las cuales designaremos con el nombre de precio mayoreo, 
 * precio menudeo y descuento. Al final el programa debe mostrar por separado, los datos de los nombres de productos y después, 
 * los promedios del costo por producto.
 * @author AAC
 * 
 * */

package productos;
import java.util.Scanner;

public class bidimensional {
    
	public static void main(String args[]) {	
        int index = 5;
        Scanner keyBoard = new Scanner(System.in);
        String nombreProducto[] = new String[index];
        float precio[][] = new float[index][3];

        System.out.println("\n\tProductos (precios de mayoreo, menudeo y descuento.)\n");

        System.out.println("\tIntroduce los datos segun se solicite:");
        for (int i = 0; i < index; i++) {
            System.out.print("\t\tNombre del producto [" +(i+1) +"]: ");
            nombreProducto[i] = keyBoard.nextLine();
        }

        // Solicita precios de mayoreo, menudeo y descuento.
        System.out.println("Indique el precio que se indica.");
        for (int i = 0; i < index; i++) {
        	
        	System.out.println("\t" +nombreProducto[i] +": ");
        	
			for (int j = 0; j < 3; j++) {
				
				if (j==0) 					
					System.out.print("Mayoreo ");
				if (j==1) 					
					System.out.print("Menudeo ");
				if (j==2) 					
					System.out.print("Descuento ");

				System.out.print("\t[" +i +"][" +j +"] = ");
				precio[i][j]=keyBoard.nextFloat();
				
			}
		}

        System.out.println("\nTabla de productos\n");
        System.out.printf("\t%15s \t->%12.8s\t | %5.8s\t | %s\n", "Producto", "Mayoreo", "Menudeo", "Descuento");	// función de impresión con formato
        System.out.println("\t\t------------------------------------------------------------------");
        for (int i = 0; i < precio.length; i++) {
			System.out.printf("\t%15s \t->%12.4s\t | %5.8s\t | %5.8s %% \n", nombreProducto[i] , precio[i][0], precio[i][1], precio[i][2]);
		}
        
	}
}
