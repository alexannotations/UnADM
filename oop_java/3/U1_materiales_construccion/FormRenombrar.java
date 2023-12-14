import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;

public class FormRenombrar extends JPanel {

    JLabel nombreArchivoActualLabel;
    JTextField nombreArchivoActual;  // debe aparecer bloqueado
    JButton buttonSeleccionar;   // debe abrir ChooseFile

    JLabel nombreArchivoNuevoLabel;
    JTextField nombreArchivoNuevo;  // debe escribirse
    JButton buttonCambiar;

    File file;



    public FormRenombrar() {
        setLayout(new BoxLayout(this,BoxLayout.Y_AXIS ));
        nombreArchivoActualLabel = new JLabel("Nombre actual: ", SwingConstants.RIGHT);
        nombreArchivoNuevoLabel = new JLabel("Nombre nuevo: ", SwingConstants.RIGHT);

        nombreArchivoActual=new JTextField(15);  // debe aparecer bloqueado
        buttonSeleccionar=new JButton("Seleccionar archivo");   // debe abrir ChooseFile
        nombreArchivoNuevo = new JTextField(15);  // debe escribirse
        buttonCambiar = new JButton("Cambiar nombre");
        nombreArchivoActual.setEnabled(false);

        buttonSeleccionar.addActionListener(new SeleccionarArchivoListener() );
        buttonCambiar.addActionListener(new CambiarNombreListener(this));

        JButton regresar = new JButton("Regresar");
        regresar.addActionListener(new BtnRegresarListener());

        add(new JLabel("Renombrar Archivo", SwingConstants.CENTER));
        add(nombreArchivoActualLabel);
        add(nombreArchivoActual);
        add(buttonSeleccionar);
        add(nombreArchivoNuevoLabel);
        add(nombreArchivoNuevo);
        add(buttonCambiar);
        add(regresar);
    }

    /**     //////////////////////////////     */
    class SeleccionarArchivoListener implements ActionListener{

        @Override
        public void actionPerformed(ActionEvent e) {
            // crea un objeto para una ventana de selección de archivo
            JFileChooser fc=new JFileChooser();
            fc.showOpenDialog(null);
            // asignamos el archivo seleccionado a un objeto File
            file = fc.getSelectedFile();
            // muestra el nombre del archivo en el campo "Nombre de archivo"
            nombreArchivoActual.setText(file.getName());
        }
    }   // END clase interna SeleccionarArchivoListener

    // ******* ******* ******* LISTENER_REGRESAR ******* ******* ******* //
    class BtnRegresarListener implements ActionListener {

        public BtnRegresarListener() {
        }

        @Override
        public void actionPerformed(ActionEvent e) {
            removeAll();
            add(new MenuEdificio());
            System.out.println("Regresando al menu edificio");
            revalidate();
        }
    } // END inner class BtnRegresarListener

}
