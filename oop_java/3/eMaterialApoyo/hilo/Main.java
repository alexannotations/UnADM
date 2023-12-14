/**
 * Ejemplo tomado de POO 3 Unidad 2 de la UnADM
 * */

package HiloEjemplo;

public class Main {
    /**
     * Este método inicia la ejecución del programa.
     * Crea dos objetos de tipo HiloIA.HiloMensaje (hilos) y los inicia.
     */
    public static void main(String[] args) throws Exception {
        //ejecutarHiloMensaje();
        //ejecutarMIHilo();
        ejecutarwithRunnable();

    }

    public static void ejecutarwithRunnable(){
        /* Se crea una instancia de la clase, otra de la clase Thread, pasando como parametros
        * la referencia de nuestro objeto y el nombre del nuevo Thread.
        * Por ultimo se llama al metodo start() de la clase Thread. Este metodo iniciara el nuevo
        * thread y llamara al metodo run() de nuestra clase */
        WithRunnable ejemploRunnable = new WithRunnable();
        Thread thread = new Thread(ejemploRunnable, "Karla");
        thread.start();
        WithRunnable ejemploRunnable2 = new WithRunnable();
        Thread thread2 = new Thread(ejemploRunnable2, "Arely");
        thread2.start();

        System.out.println("Termina cith runnable");
    }

    public static void ejecutarMIHilo(){
        System.out.println("Iniciando hilo pricipal.");
        MIHilo mh = new MIHilo("#");
        mh.start();
    }

    public static void ejecutarHiloMensaje() throws Exception{

        HiloMensaje hilo1 = new HiloMensaje("Hilo 1"); // Objeto que representa el primer hilo.
        HiloMensaje hilo2 = new HiloMensaje("Hilo 2"); // Objeto que representa el segundo hilo.

        hilo1.start(); //Se inicia la ejecución del primer hilo.
        hilo2.start(); //Se inicia la ejecución del segundo hilo.

        try {
            //Esta instrucción detiene el hilo principal del programa
            //por n milisegundos. Sin embargo, los dos hilos anteriores
            //continúan su ejecución.
            Thread.currentThread().sleep(3000);
            System.exit(0);

        }catch (InterruptedException e){
            System.out.println(Thread.currentThread().getName() + " interrumpido. " + e );
        }


    }
}
