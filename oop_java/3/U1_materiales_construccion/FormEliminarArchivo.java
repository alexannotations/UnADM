import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;

public class FormEliminarArchivo extends JPanel {

    JLabel nombreArchivoLabel = new JLabel("Nombre: ", SwingConstants.RIGHT);
    JTextField nombreArchivo;
    JButton buttonSeleccionar;
    JButton buttonEliminar;
    File file;

    public FormEliminarArchivo() {
        setLayout(new BoxLayout(this,BoxLayout.Y_AXIS ));
        nombreArchivo=new JTextField(15);  // debe aparecer bloqueado
        buttonSeleccionar=new JButton("Seleccionar archivo");   // debe abrir ChooseFile
        buttonEliminar = new JButton("Eliminar archivo");

        nombreArchivo.setEnabled(false);
        buttonSeleccionar.addActionListener(new SeleccionarArchivoListener() );

        buttonEliminar.addActionListener(
                /* Clase interna anonima para manejo de eventos */
                new ActionListener()    /* interfaz: ActionListener() Puede ser remplazada por Lambda e->  */
                {
                    public void actionPerformed(ActionEvent e)
                    {
                        /* El archivo sera eliminado sin ir a la papelera de reciclaje */
                        if (file.delete())
                            JOptionPane.showMessageDialog(null, "El archivo ha sido borrado satisfactoriamente");
                        else
                            JOptionPane.showMessageDialog(null, "El archivo NO puede ser borrado");
                    } // END actionPerformed
                } // END anonymous inner class
        ); // END addActionListener call

        JButton regresar = new JButton("Regresar");
        regresar.addActionListener(new BtnRegresarListener());

        add(new JLabel("Eliminar Archivo", SwingConstants.CENTER));
        add(nombreArchivoLabel);
        add(buttonSeleccionar);
        add(nombreArchivo);
        add(buttonEliminar);
        add(regresar);
    }

        /**     //////////////////////////////     */
        class SeleccionarArchivoListener implements ActionListener {

            @Override
            public void actionPerformed(ActionEvent e) {
                // crea un objeto para una ventana de selección de archivo
                JFileChooser fc=new JFileChooser();
                fc.showOpenDialog(null);
                // asignamos el archivo seleccionado a un objeto File
                file = fc.getSelectedFile();
                // muestra el nombre del archivo en el campo "Nombre de archivo"
                nombreArchivo.setText(file.getName());
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
