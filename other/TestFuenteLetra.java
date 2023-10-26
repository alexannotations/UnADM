/* * * * * * * * * *
 * Listar las fuentes que estan instaladas en el sistema operativo
 *
 *  */
import java.awt.*;

public class TestFuenteLetra {

    public static void main(String[] args) {
        String [] nombresFuentes = GraphicsEnvironment.getLocalGraphicsEnvironment().getAvailableFontFamilyNames();
        for(String nombreDeLaFuente: nombresFuentes){
            System.out.println(nombreDeLaFuente);
        }
    }

}
