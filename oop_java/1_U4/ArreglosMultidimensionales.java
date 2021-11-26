/** Arreglos Multidimensionales 
 * La declaración de los arrays en Java se hace mediante una variable referenciada.
 * Las dimensiones se manejan por medio de corchetes, y dentro se indica cada dimension
 * tipoDeDato[][][]... identificadorDelArray = 
 *      new tipoDeDato[tamañoDeDimension0][tamañoDeDimension1][tamañoDeDimension2]...
 * 
 * El numero total de elementos de un array multidimensional es 
 * la multiplicacion de cada dimension contra todas las restantes.
 * 
 * 
 * */

public class ArreglosMultidimensionales {

    public static void main(String[] args) {
   	
    	declaracionArrays();
    	System.out.println();
    	ejemplo1();
    	System.out.println();
    	ejemplo2();

	} // end main method

    
    public static void declaracionArrays(){
    	
        int numeros[][] = new int[3][3];
        int numeros2[][] = {{1,2,3},
        					{4,5,6},
        					{7,8,9}};
        
     // Analogamente a una tabla: 5 filas , 3 columnas
        int numeros3[][] = new int[5][3];
                
     // * Es lo mismo que escribir
        String nombres[][] = new String[2][4];
        nombres[0][0] = new String("Juan");
        nombres[0][1] = new String("Pedro");
        nombres[0][2] = new String("Luis");
        nombres[0][3] = new String("Hugo");
        nombres[1][0] = new String("Ana");
        nombres[1][1] = new String("Paulina");
        nombres[1][2] = new String("Rosy");
        nombres[1][3] = new String("Blanca");
        
    }
    
    
    public static void ejemplo1() {
   	 // [2][4]		Ver "Es lo mismo que escribir" en declaracionArrays()
   	String nombres[][] = {{"Juan", "Pedro", "Luis","Hugo"},
   						{"Ana", "Paulina", "Rosy","Blanca"}};
   	
   	// Recorrido
   	for (int i = 0; i < 2; i++) {		// Contador encargado de recorrer las filas
   		for (int j = 0; j < 4; j++) {	// Contador encargado de recorrer las columnas
   			System.out.println(nombres[i][j] + " esta en la posicion " + i + "-" +j +" del array.");
			}
		}
    	
    } // end ejemplo1()

    
    public static void ejemplo2() {
    	int [][] a = new int[10][10];	// son 100 valores numericos
    	int [][] b = new int[10][10];	// son 100 valores numericos
    	int c[][] = new int[10][10];	// Almacenara los resultados de la suma
    	int d[][] = new int[10][10];	// Almacenara los resultados de la multiplicacion
    	int acumulacionSuma = 1;
    	long acumulacionMultiplicacion = 1;
    	
    	// Asignamos valores a los elementos del arreglo
    	for (int i = 0; i < 10; i++) {		// acceso a las filas
			for (int j = 0; j < 10; j++) {	// acceso a las columnas
				a[i][j] = 3;
				b[i][j] = 3;
			}
		}
    	
    	// Operaciones de suma y multiplicacion
    	for (int i = 0; i < 10; i++) {		// acceso a las filas
			for (int j = 0; j < 10; j++) {	// acceso a las columnas
				c[i][j] = a[i][j] + b[i][j];
				d[i][j] = a[i][j] * b[i][j];
	    		acumulacionSuma += c[i][j];
	    		acumulacionMultiplicacion *= d[i][j];
			}
		}
    	
    	// Mostramos el resultado de sumar los array
    	System.out.println();
    	for (int i = 0; i < 10; i++) {		// acceso a las filas
    		for (int j = 0; j < 10; j++) {	// acceso a las columnas
    			System.out.print(c[i][j] +", ");
    		}
    		System.out.println(); 		// retorno de carro para dar forma de matriz
    	}
    	
    	// Mostramos el resultado de multiplicar los array
    	System.out.println();
    	for (int i = 0; i < 10; i++) {		// acceso a las filas
    		for (int j = 0; j < 10; j++) {	// acceso a las columnas
    			System.out.print(d[i][j] +", ");
    		}
    		System.out.println(); 		// retorno de carro para dar forma de matriz
    	}
    	
    	
    	// Mostramos las acumulaciones
    	System.out.println("\nAcumulacion de la suma es: " +acumulacionSuma);
    	System.out.println("Acumulacion de la multiplicacion es: " +acumulacionMultiplicacion);
    	
	}
    	
    /* Se puede utilizar un mismo contador para n arrays, siempre y cuando éstos sean del 
		mismo tamaño, como en el ejemplo2 donde se sumó y multiplicó en un mismo ciclo. 	*/

    
} // end class
