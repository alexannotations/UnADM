import javax.swing.*;
import java.awt.event.*;
import java.io.*;

public class FormularioCanino
        extends JPanel
        implements ActionListener {
    private Canino canino;
    public Canino getCanino() {
        return canino;
    }
    FileManager fileManager;

    private JLabel title = new JLabel("Formulario de registro");
    private JLabel labelClave;
    private JLabel labelNombre;
    private JLabel labelRaza;
    private JLabel labelEdad;
    private JLabel labelPersonalAsignado;
    private JLabel labelTelefono;
    private JLabel labelFoto;
    private JTextField textClave;
    private JTextField textNombre;
    private JTextField textRaza;
    private JTextField textEdad;
    private JTextField textPersonalAsignado;
    private JTextField textTelefono;
    private JButton btAbrirFoto;

    private JButton buttonGuardar;

    public FormularioCanino(){
        setLayout(new BoxLayout(this, BoxLayout.PAGE_AXIS));
        labelClave = new JLabel("ID:");
        labelNombre = new JLabel("Nombre del canino:");
        labelRaza = new JLabel("Raza:");
        labelEdad = new JLabel("Edad en años:");
        labelPersonalAsignado = new JLabel("Nombre del personal a cargo:");
        labelTelefono = new JLabel("Telefóno:");
        labelFoto = new JLabel("Fotografía:");
        textClave = new JTextField();
        textNombre = new JTextField();
        textRaza = new JTextField();
        textEdad = new JTextField();
        textPersonalAsignado = new JTextField();
        textTelefono = new JTextField();

        btAbrirFoto = new JButton("Agregar foto");

        buttonGuardar = new JButton("Guardar");

        add(labelClave);
        add(textClave);
        add(labelNombre);
        add(textNombre);
        add(labelRaza);
        add(textRaza);
        add(labelEdad);
        add(textEdad);
        add(labelPersonalAsignado);
        add(textPersonalAsignado);
        add(labelTelefono);
        add(textTelefono);
        add(labelFoto);

        add(btAbrirFoto);

        add(new JLabel());
        add(buttonGuardar);

        buttonGuardar.addActionListener(this);
        btAbrirFoto.addActionListener(this);


    }

    public void salvarDatos(){
        // Crear una instancia de la clase Canino con los valores recuperados del formulario
        try{
            canino = new Canino(
                    Integer.parseInt(textClave.getText()),
                    textNombre.getText(),
                    textRaza.getText(),
                    Integer.parseInt(textEdad.getText()),
                    textPersonalAsignado.getText(),
                    textTelefono.getText(),
                    fileManager.getArchivoImagen()
            );
        }catch (Exception e){
            System.out.println(e);
        }
    }

    /** ActionListener */
    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == btAbrirFoto) {
            fileManager = new FileManager();
            try {
                fileManager.openDirectoryMenu(this);
                JOptionPane.showMessageDialog(this, "La información se ha guardado correctamente.");
            } catch (IOException ex) {
                throw new RuntimeException(ex);
            }
        }   // btAbrirFoto

        if (e.getSource() == buttonGuardar) {
            salvarDatos();
            JOptionPane.showMessageDialog(this, "La información se ha guardado correctamente.");
        }   // buttonGuardar

    }   // end


}
