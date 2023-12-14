import java.awt.*;

public class Main {

    public static void main(String[] args) {
        try {
            Ventana ventana = new Ventana();
            ventana.setVisible(true);
        } catch (HeadlessException e) {
            // Manejo de la excepción
        }
    }
}
