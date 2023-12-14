import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class MenuPrincipal
        extends JPanel
        implements ActionListener {

    private JMenuBar menuBar;
    private JMenu menuReservacion;
    private JMenuItem menuItemReservar;
    private JMenuItem menuItemHistorial;

    FormularioReservar formularioReserva;
    FormularioHistorial formularioHistoria;


    public MenuPrincipal() {
        super();
        setBackground(Color.WHITE);
        menuBar = new JMenuBar();
        menuReservacion = new JMenu("Reservación");
        menuItemReservar = new JMenuItem("Reservar");
        menuItemHistorial = new JMenuItem("Historial");
        menuReservacion.add(menuItemReservar);
        menuReservacion.add(menuItemHistorial);
        menuBar.add(menuReservacion);
        formularioReserva = new FormularioReservar();
        formularioHistoria = new FormularioHistorial();
        menuItemReservar.addActionListener(this);
        menuItemHistorial.addActionListener(this);
        add(menuBar);
    }

    /** ------------- ActionListener -------------- */
    @Override
    public void actionPerformed(ActionEvent e) {

        if (e.getSource() == menuItemReservar) {
            System.out.println("Menu Reservar");
            remove(formularioHistoria);
            add(formularioReserva);
        }

        if (e.getSource() == menuItemHistorial) {
            System.out.println("Submenu Historial");
            remove(formularioReserva);
            add(formularioHistoria);
        }

    }   // end

}
