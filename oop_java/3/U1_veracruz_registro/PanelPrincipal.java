import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class PanelPrincipal extends JPanel {

    MenuPersonal menuPersonal=new MenuPersonal();
    JButton btPersonal = new JButton("Personal");
    JButton btSalir = new JButton("Salir");

    public PanelPrincipal() {
        setBackground(Color.PINK);
        add(new JLabel("Bienvenido"));

        btPersonal.addActionListener(new OpenFormAltasListener(this));
        btSalir.addActionListener(new SalirFormListener());

        add(btPersonal);
        add(btSalir);
    }

    public void showPersonalAltas()
    {
        this.add(menuPersonal);
        btPersonal.setVisible(false);
        btSalir.setVisible(false);
    }



}
