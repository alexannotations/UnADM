import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.IOException;

public class MenuPrincipal
        extends JPanel
        implements ActionListener {

    private JMenuBar menuBar;
    private JMenu menuInicio;
    private JMenuItem menuItemRegistrar;
    private JMenuItem menuItemStreams;

    FormularioCanino formularioCanino;
    MostrarInfoCanino infoCanino;



    public MenuPrincipal() throws IOException {
        super();
        setBackground(Color.WHITE);
        menuBar = new JMenuBar();
        menuInicio = new JMenu("Registro");
        menuItemRegistrar = new JMenuItem("Registrar canino");
        menuItemStreams = new JMenuItem("Ver Caninos");
        menuInicio.add(menuItemRegistrar);
        menuInicio.add(menuItemStreams);
        menuBar.add(menuInicio);
        formularioCanino = new FormularioCanino();
        infoCanino = new MostrarInfoCanino();
        menuItemRegistrar.addActionListener(this);
        menuItemStreams.addActionListener(this);
        add(menuBar);
    }

    /** ------------- ActionListener -------------- */
    @Override
    public void actionPerformed(ActionEvent e) {

        if (e.getSource() == menuItemRegistrar) {
            System.out.println("Menu Registrar");
            remove(infoCanino);
            add(formularioCanino);
            formularioCanino.revalidate();
        }   // menuItemRegistrar

        if (e.getSource() == menuItemStreams) {
            System.out.println("Mostrar información");
            try {
                infoCanino.cargarDatos(formularioCanino.getCanino());
            } catch (IOException ex) {
                throw new RuntimeException(ex);
            }
            remove(formularioCanino);
            add(infoCanino);
            // hace visible el panel
            // https://stackoverflow.com/questions/57340812/jpanel-wont-update
            infoCanino.revalidate();
            //infoCanino.repaint();
        }



    }   // end

}
