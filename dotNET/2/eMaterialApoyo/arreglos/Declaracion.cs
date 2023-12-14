

namespace arreglos
{
    class Declaracion
    {
        public Declaracion() 
        {
            // unidimensional
            // se representan dato[0], dato[1]
            int[] vectorDato;
            vectorDato = new int[10];

            int[] dato = new int[10];

            int[] otraForma = new int[] { 0, 1, 2, 3, 4, 5 };

            int[] datoForma = { 0, 1, 2, 3, 4, 5 };


            // Multidimensionales   [filas, columnas]
            // multi[0,0], multi [0,1]
            // multi[1,0], multi [1,1]
            int[,] multidimensional;
            multidimensional = new int[10, 3];

            int[,] otroMulti = new int[4, 3];

            int[,] multi = { { 0, 1, 2, }, { 1, 2, 3, }, { 2, 3, 4, } };


            // matriz escalonada
            // es una variación del arreglo multidimensional, una matriz de matrices.
            // Es una matriz unidimensional, y cada elemento en sí mismo es una matriz.
            int[][] escalonada = new int[3][];
            escalonada[0] = new int[5];
            escalonada[1] = new int[8];
            escalonada[2] = new int[3];


            // Algunas funciones propias al definir un objeto arreglo

            double[] a = { 3.3, 2.2, 1.1, 5.6 };

            System.Console.WriteLine("Numero de elementos: " + a.Length);
            System.Console.WriteLine("Promedio de los datos: " + a.Average());
            System.Console.WriteLine("Valor máximo: " + a.Max());
            System.Console.WriteLine("Valor mínimo: " + a.Min());
            System.Console.WriteLine("La suma es: " + a.Sum());

        }

    }   // END class
}
