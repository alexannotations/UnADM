/**
 * Arreglos unidimensionales
 * La sintaxis general para declarar e instanciar un array es:
 * tipoDeDato[] identificadorDelArray = new tipoDeDato[tamañoDelArray]
 * Se pueden usar array de caulquier tipo de dato soportado:
 * char x[];    int y[];   clsAlumnos objAlumnos[];
 * Necesitan ser inicializadas a un valor, por default:
 *      - false cuando es boolean
 *      - null para objetos de tipo Object
 *      - vacio para String
 *      - 0 para cualquier otro tipo de dato
 * 
 * 
 * */

public class Arreglos {

    public static void main(String[] args) {
        //arreglo declarado en vacío
        int numeros[] = new int[50];

        //arreglo declarado con valores iniciales
        String nombres[] = {"Juan", "Pedro", "Luis", "Hugo"};

        recorridoSinLoops();
        
        // Recorrido con loop
        for (int i=0;i<4; i++) {
        	System.out.println(nombres[i] +" esta en la posicion " +i);			
		}
        
        operacionesArreglos();

	}
    
    
    public static void operacionesArreglos() {
    	// arreglos unidimensionales
    	int[] a = new int[10];
    	int[] b = new int[10];
    	
    	int c[] = new int[10];	// array que contendra los resultados de la suma
    	int d[] = new int[10];	// array que contendra los resultados de la multiplicacion
    	
    	int acumulacionSuma = 0;
    	long acumulacionMultiplicacion = 1; // Se asigna uno para que acumulacionMultiplicacion no resulte cero, al ser su valor incial
    	
    	// Asignamos algunos valores a los arrays a[] y b[]
    	for (int i = 0; i < 10; i++) {
			a[i] = i+1;
			b[i] = i+1;		// Si se usa i++ el operador asigna y suma a i, por tanto genera un error fuera de indice
		}
    	
    	// Mostramos los valores almacenados en los arrays
    	for (int i = 0; i < 10; i++) {
			System.out.print(a[i] +", ");
		}
    	System.out.println();
    	for (int i = 0; i < 10; i++) {
			System.out.print(b[i] +", ");
		}
    	System.out.println();
    	
    	// Realizamos la suma y multiplicacion de a[] y b[] 
    	for (int i = 0; i < 10; i++) {
    		c[i] = a[i] + b[i];
    		d[i]= a[i] * b[i];
    		acumulacionSuma += c[i];
    		acumulacionMultiplicacion *= d[i];
		}
    	
    	// Imprimimos el resultado de sumar los arrays
    	System.out.println();
    	for (int i = 0; i < 10; i++) {
			System.out.print(c[i] +", ");
		}
    	
    	System.out.println();
    	// Imprimimos el resultado de multiplicar los arrays
    	for (int i = 0; i < 10; i++) {
			System.out.print(d[i] +", ");
		}
    	
    	// Imprimimos las acumulaciones
    	System.out.println("\nAcumulacion de la suma es " + acumulacionSuma);
    	System.out.println("Acumulacion de la multiplicacion es " + acumulacionMultiplicacion);
    
    }
    
    
    public static void recorridoSinLoops() {
    	
        //al declarar un arreglo con valores, también podría escribirse así:
        String nombres2[] = new String[4];
	        nombres2[0] = new String("Luisa");
	        nombres2[1] = new String("Ana");
	        nombres2[2] = new String("Karen");
	        nombres2[3] = new String("Ingrid");
        
        // Recorrido, por medio de un indice se controla la posicion
        // Pero lo mejor es recorrerlo con loops
        System.out.println(nombres2[0] +" esta en la posicion 0");
        System.out.println(nombres2[1] +" esta en la posicion 1");
        System.out.println(nombres2[2] +" esta en la posicion 2");
        System.out.println(nombres2[3] +" esta en la posicion 3");
    }

    
}
