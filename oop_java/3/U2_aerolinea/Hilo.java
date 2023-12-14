import javax.swing.*;

public class Hilo implements Runnable {

    Reservacion reservacion;
    JProgressBar bp;
    private int max;
    private int ticketsSolicitados; // tickets por entregar en una venta

    private static int contador=0;
    private static Reservacion ganador=null;

    public Hilo(Reservacion reservacion, JProgressBar bp){
        this.reservacion = reservacion;
        this.max = reservacion.getMaxSellTickets();
        this.bp = bp;
        ticketsSolicitados = 0;
    }

    @Override
    public void run() {
        do {
            ticketsSolicitados = Venta.generarReservacionAleatoria();
            //System.out.println(this+"-"+ticketsSolicitados+"/"+bp.getValue() + " "+contador);
            reservacion.sellTickets(ticketsSolicitados);
            //System.out.print(reservacion.getBoletosVendidos()+"/"+reservacion.getMaxSellTickets() +" ");
            bp.setValue(Venta.porcentajeOcupacion(reservacion));
            try {
                Thread.sleep(50);
            } catch (InterruptedException ex) {
                throw new RuntimeException(ex);
            }

        }while (reservacion.getBoletosVendidos() < reservacion.getMaxSellTickets());

        if (bp.getValue()>=99&&contador==0) {
            contador++;
            ganador=reservacion;
        }
    }

    public static Reservacion getGanador(){
        return ganador;
    }

}
