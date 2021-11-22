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
    }
}
