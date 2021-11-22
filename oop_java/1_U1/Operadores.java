public class Operadores
{
    public static void main(String[] args)
    {

        /** Operadores Aritmeticos 
         * Este es un comentario de documentacion del programa
        */
        int j, k, m;
        int d= 123;

        j = d--; // j vale 123 y d vale 122
        // asigna d a j despues resta 1 a d
        System.out.println("j= " + j + "\t d= " +d );

        k = ++d; // k vale 123 y d vale 123
        // suma 1 a d y lo asigna a k
        System.out.println("k= " + k + "\t d= " +d );

        m = --d; // m vale 122 y d vale 122
        // resta 1 a d y lo asigna a m
        System.out.println("m= " + m + "\t d= " +d );

        k = d++; // k vale 122 y d vale 123
        // asigna d a k despues suma 1 a d
        System.out.println("k= " + k + "\t d= " +d );

        j++;
        m = j % k; // operador Resto para los tipos int 
        // j=124 y k=122, por tanto, m= 2
         System.out.println("m= " + m);

        m = j/k; // División entera: m= 1 
        System.out.println("m= " + m);


        /** Operadores logicos */
        double c= 1.0, b= 3.0; 
        if (c != 0.0 && b/c < 5.0)
            System.out.println("se cumple la condición solicitada");

        System.exit(0);
    }
}
