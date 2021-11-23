public class AmbitoVariables{ 

    public static void main(String[] args){ 

        if (true) { 
            int a=10;   //Decalaración de la variable dentro del bloque que corresponde
                        // a la sentencia if (dentro del ámbito del if).
        }
        
        System.out.println(a); // Acceso a la variable fuera del ámbito donde 
                                //fue declarada (fuera del bloque if, delimitado 
                                //por llaves).
        
    } // end main()

            /** Constantes
         * static permite el acceos a una variable miembro de una determinada clase,
         * sin cargar alguna instancia para ser utilizada
         * final provoca que el contenido de la variable no pueda ser cambiado
         */
        static final double PI = 3.1415927;
}
