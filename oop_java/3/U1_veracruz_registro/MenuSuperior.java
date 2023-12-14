import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class MenuSuperior extends JMenuBar {
    JMenu menu = new JMenu("Menu");
    JMenu personalMenu = new JMenu("Personal");

    JMenuItem salir = new JMenuItem("Cerrar");
    JMenuItem personalAltas =new JMenuItem("Altas");

    public MenuSuperior() {

        menu.add(personalMenu);
        menu.addSeparator();
        menu.add(salir);
        personalMenu.add(personalAltas);
        setBackground(Color.RED);

        // listeners
        personalAltas.addActionListener(new OpenFormAltasListener(new PanelPrincipal()));
        salir.addActionListener(new SalirAplicacion());

        add(menu);
    }


    // ************************
    private  class SalirAplicacion implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e)
        {
            System.out.println("Terminar Aplicación");
            System.exit(0);
        }
    }


}
