import java.time.LocalDate;
import java.util.Random;

public class Venta {

    /**
     * Simula la venta de boletos para cualquier venta de vuelo
     * regresando un numero aleatorio entre 1 y 4
     *
     * */
    public static int generarReservacionAleatoria(){

        Random random = new Random();           // Crear un objeto de la clase Random
        int numero = random.nextInt(4);  // Generar un número entero entre 0 y 3
        numero = numero + 1;                    // Sumar 1 al número para obtener un rango de 1 a 4

        return numero;
    }


    /**
     * */
    public static String mostrarInfoVentaFinal(Reservacion reservacion){
        LocalDate fecha = LocalDate.now();

        if (reservacion!=null) {
            String info = "\n\n" + fecha +
                    "\nInformación del vuelo: \n\n Destino: " + reservacion.getVuelo().getDestino() +
                    "\n Total de asientos: " + reservacion.getVuelo().getAsientos() +
                    "\n Precio por boleto: $" + reservacion.getVuelo().getPrecio() + ".00" +
                    "\n\n Boletos vendidos: " + reservacion.getBoletosVendidos() +
                    "\n Total de venta realizada: \n$" + reservacion.showVentaTotal() + ".00" +
                    "\n Porcentaje vendido: " + porcentajeOcupacion(reservacion) + "%";
            return info;
        }else
            return fecha + "\nEjecute Iniciar \n  y después\nMostrar resultados";
    }

    /**
     * Calcular la cantidad de ventas realizadas, representadas en porcentaje de boletos vendidos.
     * */
    public static int porcentajeOcupacion(Reservacion reservacion){
        int porcentaje = ((reservacion.getBoletosVendidos()*100) / reservacion.getMaxSellTickets());
        return porcentaje;
    }

    /**
     * */
    public static Reservacion IniciarVentas(Vuelo vuelo){
        Reservacion reservacion = new Reservacion(vuelo);
        int ticketsSolicitados = 0;
        int ticketsVendidos = 0;
        do {
            ticketsSolicitados = Venta.generarReservacionAleatoria();
            System.out.print(ticketsSolicitados + " ");
            ticketsVendidos = reservacion.sellTickets(ticketsSolicitados);
        }while (ticketsVendidos < reservacion.getMaxSellTickets());

        return reservacion;
    }

}
