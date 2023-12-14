public class Reservacion {

    private Vuelo vuelo;
    private int boletosVendidos;

    public Reservacion(Vuelo vuelo) {
        this.vuelo = vuelo;
        boletosVendidos = 0;
    }

    public Vuelo getVuelo() {
        return vuelo;
    }

    public void setVuelo(Vuelo vuelo) {
        this.vuelo = vuelo;
    }

    /** Obtener boletos vendidos
     * NO hay setter, buyTickets() cumple esta tarea
     * */
    public int getBoletosVendidos() {
        return boletosVendidos;
    }

    /** Obtener el máximo de boletos que se pueden vender */
    public int getMaxSellTickets() {
        return vuelo.getAsientos();
    }

    /**
     * Simula la reservación de boletos
     * incremantando el atributo boletos vendidos
     *  y regresa su nuevo valor
     * Existe sobre venta de boletos
     * * */
    public int sellTickets(int asientos){
        boletosVendidos = boletosVendidos + asientos;
        return this.getBoletosVendidos();
    }

    /** Indica el total de ventas en dinero
     * precio boleto x boletos vendidos
     * */
    public int showVentaTotal(){
        int total = vuelo.getPrecio() * this.getBoletosVendidos();
        return total;
    }

}
