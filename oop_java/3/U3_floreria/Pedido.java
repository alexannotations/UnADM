import java.util.ArrayList;
import java.util.Collection;
import java.util.List;

public class Pedido {

    private ArrayList<String> producto = new ArrayList<>();

    public ArrayList<String> getProducto() {
        return producto;
    }

    public void setProducto(ArrayList<String> producto) {
        this.producto = producto;
    }

    public Pedido() {
        System.out.println("Creando pedido");
    }

}
