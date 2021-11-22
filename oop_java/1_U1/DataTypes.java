public class DataTypes
{
    public static void main(String[] args)
    {
        int x;                  // un dato declarado pero sin valor inicial.
        boolean isReal=true;    // Los nombres son sensibles a
                                // mayúsculas y minúsculas,
                                // deben empezar por una letra y
                                // pueden contener números,_,$
        byte a = 121;           // Deben ser inferiores a 126
        short b = -10000;       // Deben ser inferiores a 25000
        int c = 100000;         // Deben ser inferiores a 2100 mill.
        long d = 999999999999L; // Deben poner L al final
        float e = 234.99F;      // Deben ser < 3E38; F al final
        double f = 55E100;
        char charValue= '4';    // char '4' no es el entero 4
                                //Las cadenas (strings) son objetos, no primitivos.
                                //Ejemplo:
        String institucion = "esad";
        
        DataTypes data = new DataTypes();
        data.showDataTypes();
    }

    void showDataTypes(){
               //byte, short, int, long like an object
        System.out.println("bits tipo byte:" + Byte.SIZE);
        System.out.println("bytes tipo byte:" + Byte.BYTES);
        System.out.println("valor minimo tipo byte:" + Byte.MIN_VALUE);
        System.out.println("valor maximo tipo byte:" + Byte.MAX_VALUE);
        System.out.println();

        System.out.println("bits tipo short:" + Short.SIZE);
        System.out.println("bytes tipo short:" + Short.BYTES);
        System.out.println("valor minimo tipo short:" + Short.MIN_VALUE);
        System.out.println("valor maximo tipo short:" + Short.MAX_VALUE);
        System.out.println();

        System.out.println("bits tipo int:" + Integer.SIZE);
        System.out.println("bytes tipo int:" + Integer.BYTES);
        System.out.println("valor minimo tipo int:" + Integer.MIN_VALUE);
        System.out.println("valor maximo tipo int:" + Integer.MAX_VALUE);
        System.out.println();

        System.out.println("bits tipo long:" + Long.SIZE);
        System.out.println("bytes tipo long:" + Long.BYTES);
        System.out.println("valor minimo tipo long:" + Long.MIN_VALUE);
        System.out.println("valor maximo tipo long:" + Long.MAX_VALUE);

        byte byteVar = 15;
        System.out.println("byteVar = " + byteVar);
        short shortVar = 100;
        System.out.println("shortVar = " + shortVar);
        int intVar = 500;
        System.out.println("intVar = " + intVar);
        long longVar = 1000;
        System.out.println("longVar = " + longVar);

        // Soporte desde Java 10
        //var numero = 10;
        //System.out.println("numero = " + numero);
    }

}
