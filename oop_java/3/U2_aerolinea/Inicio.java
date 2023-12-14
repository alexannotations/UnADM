public class Inicio {
    public static void main(String[] args) {
        //ejecutarVenta();

        VentanaFondo ventana = new VentanaFondo();
        ventana.setVisible(true);

    }


    /*
    * Ejecuta unas ventas de reservas para un vuelo en la terminal para propósitos de prueba
    */
    public static void ejecutarVenta(){

        // creamos los vuelos como paramatros a las distintas ciudades y sus ventas
        Reservacion angeles = new Reservacion(new Vuelo("los ángeles",186,5500));
        Reservacion madrid = new Reservacion(new Vuelo("Madrid",144,11300));
        Reservacion bogota = new Reservacion(new Vuelo("Bogotá",190,7600));

        int maxAngeles = angeles.getMaxSellTickets();
        int ticketsSolicitadosAngeles = 0;
        int ticketsVendidosAngeles = 0;

        // hacemos ventas aleatorias de asientos para los ángeles
        // hasta llegar al maximo de reservas disponible
        // la cantidad de iteraciones que se requieren para llegar
        // al maximo de ventas es aleatorio
        do {
            ticketsSolicitadosAngeles = Venta.generarReservacionAleatoria();
            System.out.print(ticketsSolicitadosAngeles + " ");
            ticketsVendidosAngeles = angeles.sellTickets(ticketsSolicitadosAngeles);
        }while (ticketsVendidosAngeles < maxAngeles);

        //System.out.println(Venta.mostrarInfoVentaFinal(angeles));

        /** ------------  ------------  ------------ */
        int ticketsSolicitadosMadrid = 0;
        int ticketsVendidosMadrid = 0;
        do {
            ticketsSolicitadosMadrid = Venta.generarReservacionAleatoria();
            System.out.print(ticketsSolicitadosMadrid + " ");
            ticketsVendidosMadrid = madrid.sellTickets(ticketsSolicitadosMadrid);
        }while (ticketsVendidosMadrid < madrid.getMaxSellTickets());

        //System.out.println(Venta.mostrarInfoVentaFinal(madrid));

    }   // END ejecutarVentas()


}
