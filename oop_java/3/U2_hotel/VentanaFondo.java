import javax.swing.*;
import java.awt.*;

public class VentanaFondo extends JFrame {
    MenuPrincipal menuMain;
    public VentanaFondo() throws HeadlessException {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setTitle("Hotel Juan");
        this.setLocation(300,300);
        this.setSize(610,450);
        this.setBackground(Color.BLACK);
        menuMain = new MenuPrincipal();
        getContentPane().add(menuMain);
    }
}
