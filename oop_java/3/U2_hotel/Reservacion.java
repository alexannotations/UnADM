import java.util.concurrent.*;

public class Reservacion
        implements Runnable {

    private int numeroHabitacion;
    private int numeroNoches;
    private static final int TIEMPO_RESERVA = 24;
    // El semáforo que controla el acceso a las 5 habitaciones
    private static final Semaphore SEMAFORO = new Semaphore(5);


    public Reservacion(int numeroHabitacion, int numeroNoches) {
        this.numeroHabitacion = numeroHabitacion;
        this.numeroNoches = numeroNoches;
    }   // end

    /** Runnable */
    public void run() {
        try {
            // Se solicita un permiso al semáforo para acceder a una habitación
            SEMAFORO.acquire();
            // Se muestra un mensaje indicando que se ha reservado la habitación
            System.out.println("Se ha reservado la habitación " + numeroHabitacion + " por " + numeroNoches + " noches");
            // Se simula el tiempo de reserva con un sleep
            Thread.sleep(TIEMPO_RESERVA * numeroNoches * 1000);
            // Se muestra un mensaje indicando que se ha liberado la habitación
            System.out.println("Se ha liberado la habitación " + numeroHabitacion);
            // Se devuelve el permiso al semáforo para permitir el acceso a otra habitación
            SEMAFORO.release();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }   // end

}
