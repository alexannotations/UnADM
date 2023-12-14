/**
 * agregar un formulario donde solicite: encargado y zona y se pueda visualizar
 * para después eliminarlo
 * */

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class FormEliminar extends JPanel {

    // solicitar nombre de archio y renombrar
    JTextField nombreArchivo;
    JButton btnSeleccionar;
    JButton btnEliminar;

    public FormEliminar() {
        setLayout(new BoxLayout(this,BoxLayout.Y_AXIS ));
        btnSeleccionar = new JButton("Seleccionar archivo");
        nombreArchivo = new JTextField(15);
        btnEliminar = new JButton("Eliminar");

        JButton regresar = new JButton("Regresar");
        regresar.addActionListener(new BtnRegresarListener());

        add(new JLabel("Eliminar un archivo", SwingConstants.CENTER));
        add(btnSeleccionar);
        add(nombreArchivo);
        add(btnEliminar);
        add(regresar);
    }

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
