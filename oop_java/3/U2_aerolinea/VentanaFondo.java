import javax.swing.*;
import java.awt.*;

public class VentanaFondo extends JFrame{

    MenuPrincipal menuMain;
    public VentanaFondo() throws HeadlessException {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setTitle("Hilos");
        this.setLocation(300,300);
        this.setSize(410,400);
        this.setBackground(Color.BLACK);
        menuMain = new MenuPrincipal(new BorderLayout());
        getContentPane().add(menuMain);
    }

}
