import javax.swing.*;
import java.awt.*;


public class Ventana extends JFrame {

    MenuMain menuMain;

    public Ventana() throws HeadlessException {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setTitle("Proyectos arquitectónicos");
        this.setLocation(300,300);
        this.setSize(600,270);
        this.setBackground(Color.BLACK);
        menuMain = new MenuMain(new BorderLayout());
        getContentPane().add(menuMain);
    }
}
