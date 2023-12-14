import javax.swing.*;
import java.awt.*;
import java.io.IOException;

public class VentanaFondo extends JFrame {
    MenuPrincipal menuMain;
    public VentanaFondo() throws HeadlessException, IOException {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setTitle("Protección Civil - Binomios caninos México");
        this.setLocation(300,300);
        this.setSize(610,450);
        this.setBackground(Color.BLACK);
        menuMain = new MenuPrincipal();
        getContentPane().add(menuMain);
    }
}
