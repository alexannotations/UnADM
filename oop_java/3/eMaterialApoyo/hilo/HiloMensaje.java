package HiloEjemplo;

/**
* Esta clase representa un hilo.
* Hereda de la clase Thread y sobreescribe el
* método run.
*/
public class HiloMensaje extends Thread{

    private String nombreHilo;      //Esta variable sirve para dar nombre al hilo y se imprimirá cada vez que el hilo esté en ejecución.
    private boolean corriendo;  //Esta variable sirve para detener la ejecución en cualquier momento que el usuario desee


    /**
     * Constructor vacío para la clase HiloMensaje.
     * Asigna por default el nombre "Hilo sin nombre".
     */
    public HiloMensaje()
    {
        this ("Hilo sin nombre");
    }

    /**
     * Constructor para la clase HiloMensaje.
     * Recibe como parametro el nombre que recibira
     * el hilo.
     */
    public HiloMensaje(String nombre){
        nombreHilo = nombre;
        corriendo = false;
    }
    /**
     * Devuelve el valor de la variable
     * nombreHilo.
     */
    public String getNombre()
    {
        return nombreHilo;
    }


    /**
     * Este método se manda llamar de forma automática cuando se
     * inicia la ejecución del hilo. En otras palabras, en este método
     * se deben escribir las instrucciones que se desean ejecutar
     * como un hilo paralelo.
     */
    @Override
    public void run()
    {
        //Esta variable servirá para llevar un conteo de las veces que se itera
        //el ciclo while más abajo.
        int i = 0;


        //Se establece la variable "corriendo" en true para indicar que el hilo
        //esta en ejecucion.
        corriendo = true;

        //Mientras la variable "corriendo" tenga el valor verdadero,
        //se imprimirá un mensaje mostrando el nombre del hilo y el numero de veces
        //que se ha iterado en el ciclo.
        while (corriendo)
            System.out.println("Hola, soy el hilo " + nombreHilo + " en iteracion " + (++i));

    }


    /**
     * Sirve para saber si actualmente el hilo esta en ejecucion.
     */
    public boolean estaCorriendo()
    {
        return corriendo;
    }
    /**
     * Sirve para forzar un hilo a detenerse.
     */
    public void detener()
    {
        corriendo = false;
    }
}
