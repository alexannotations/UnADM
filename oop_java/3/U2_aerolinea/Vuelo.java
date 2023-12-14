public class Vuelo {

    private String destino;
    private int asientos;
    private int precio;


    public String getDestino() {
        return destino;
    }

    public void setDestino(String destino) {
        this.destino = destino;
    }

    public int getAsientos() {
        return asientos;
    }

    public void setAsientos(int asientos) {
        this.asientos = asientos;
    }

    public int getPrecio() {
        return precio;
    }

    public void setPrecio(int precio) {
        this.precio = precio;
    }

    public Vuelo(String destino, int asientos, int precio) {
        this.setDestino(destino);
        this.setAsientos(asientos);
        this.setPrecio(precio);
    }
}
