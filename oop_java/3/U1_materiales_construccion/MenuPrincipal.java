import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class MenuPrincipal extends JPanel {

    MenuEdificio menuEdificio;
    JButton edificio;
    JButton salir;

    public MenuPrincipal(MenuEdificio me) {
        super();
        menuEdificio = me;

        initComponents();

        System.out.println("Ejecutar menu principal");
    }

    public void initComponents(){
        this.edificio = new JButton("Edificio");
        this.salir = new JButton("Salir de la aplicación");

        edificio.addActionListener(new EdificioListener());
        salir.addActionListener(new SalirAplicacionListener());

        this.add(edificio);
        this.add(salir);
        this.revalidate();
        this.repaint();
        System.out.println("Iniciando componentes de MenuPrincipal");
    }

    /**     //////////////////////////////     */
    private  class EdificioListener implements ActionListener {
        public EdificioListener() {

        }

        @Override
        public void actionPerformed(ActionEvent e)
        {
            removeAll();
            add(menuEdificio);
            revalidate();
            System.out.println("Mostrar menu edificio y ocultar el menu principal");
        }
    }   // END internal class EdificioListener


    /**     //////////////////////////////     */
    private  class SalirAplicacionListener implements ActionListener {
        @Override
        public void actionPerformed(ActionEvent e)
        {
            System.out.println("Terminar Aplicación");
            System.exit(0);
        }
    }   // END internal class SalirAplicacionListener
}
