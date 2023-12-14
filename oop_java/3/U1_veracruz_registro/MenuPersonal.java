import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class MenuPersonal extends JPanel {

    JTextField campoName = new JTextField(15);
    JTextField campoCapacitacion = new JTextField(15);
    JTextField campoPiso = new JTextField(15);
    JTextField campoEdificio = new JTextField(15);

    JButton btGuardar = new JButton("Guardar");
    JButton btAbrir = new JButton("Abrir");
    JButton btSalir = new JButton("Salir");

    String filePath = null;


    public MenuPersonal() {
        setBackground(Color.CYAN);

        // ***********************
        JPanel formulario = new JPanel();
        formulario.setLayout(new GridLayout(4,2));

        formulario.add(new JLabel("Nombre del empleado"));
        formulario.add(campoName);
        formulario.add(new JLabel("Capacitación"));
        formulario.add(campoCapacitacion);
        formulario.add(new JLabel("Piso"));
        formulario.add(campoPiso);
        formulario.add(new JLabel("Edificio"));
        formulario.add(campoEdificio);

        // ***********************
        JPanel controles = new JPanel();
        // controles.setLayout(new FlowLayout(FlowLayout.CENTER));

        controles.add(btGuardar);
        controles.add(btAbrir);
        controles.add(btSalir);

        add(formulario);
        add(controles);

        FileTextListener fileTextListener = new FileTextListener(this);
        btGuardar.addActionListener(fileTextListener);

        AbrirArchivoListener abrirArchivoListener = new AbrirArchivoListener(this);
        btAbrir.addActionListener(abrirArchivoListener);


        btSalir.addActionListener(new SalirFormListener());

    }




    // ************************
    private  class AbrirArchivoListener implements ActionListener
    {
        private MenuPersonal menuPersonal;

        public AbrirArchivoListener(MenuPersonal menuPersonal) {
            this.menuPersonal = menuPersonal;
        }

        @Override
        public void actionPerformed(ActionEvent e)
        {
            FileManager fileManager = new FileManager();
            fileManager.openDirectoryMenu(menuPersonal);
        }
    }
}
