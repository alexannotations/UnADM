import javax.swing.*;

public class TablaArchivo extends JPanel {

    JTable proyectos;

    public TablaArchivo() {
        proyectos = new JTable(10,6);

        add(new JLabel("Información del archivo", SwingConstants.CENTER));
        add(proyectos);
    }
}
