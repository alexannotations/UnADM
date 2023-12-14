import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.io.*;

public class MostrarInfoCanino
        extends JPanel
        implements ActionListener {
    private Canino canino;

    // bytes
    FileInputStream in = null;
    FileOutputStream out = null;

    // caracteres
    FileReader inputStream = null;
    FileWriter outputStream = null;

    private JLabel title = new JLabel("Mostrar información canina");
    private JLabel clave;
    private JLabel nombre;
    private JLabel raza;
    private JLabel edad;
    private JLabel personalAsignado;
    private JLabel telefono;
    private JLabel rutaFoto;
    private JButton btnCargar;
    private JButton btnBytes;
    private JButton btnCaracteres;

    private JTextArea fotoBytes;
    private JTextArea fotoCaracteres;


    public MostrarInfoCanino() throws IOException {
        setLayout(new BoxLayout(this, BoxLayout.PAGE_AXIS));
        btnCargar = new JButton("Cargar datos");
        btnBytes = new JButton("Bytes");
        btnCaracteres = new JButton("Caracteres");

        fotoBytes = new JTextArea();
        fotoCaracteres = new JTextArea();

        btnCargar.addActionListener(this);
        btnBytes.addActionListener(this);
        btnCaracteres.addActionListener(this);
        add(title);
        add(btnCargar);
        add(btnBytes);
        add(btnCaracteres);
    }

    public void cargarDatos(Canino canino) throws IOException{
        this.canino = canino;
        clave = new JLabel("ID: " +canino.getId());
        nombre = new JLabel("Nombre del canino:" +canino.getNombre());
        raza = new JLabel("Raza: " +canino.getRaza());
        edad = new JLabel("Edad en años: " +canino.getEdad());
        personalAsignado = new JLabel("Nombre del personal a cargo: " +canino.getPersonalAsignado());
        telefono = new JLabel("Telefóno: " +canino.getTelefono());
        rutaFoto = new JLabel("Ubicación foto: " + canino.getFoto());
        // Cargar la imagen desde el archivo
        BufferedImage imagen = ImageIO.read(new File(canino.getFoto()));
        // Crear un JLabel con la imagen
        JLabel foto = new JLabel (new ImageIcon (imagen));

        add(clave);
        add(nombre);
        add(raza);
        add(edad);
        add(personalAsignado);
        add(telefono);
        add(rutaFoto);
        add(foto);
    }

    private void crearBytes() throws IOException {
        // https://docs.oracle.com/javase/tutorial/essential/io/bytestreams.html
        try {
            in = new FileInputStream(canino.getFoto());
            out = new FileOutputStream("outCanino.stream");
            int c;

            while ((c = in.read()) != -1) {
                out.write(c);
            }
        } catch (IOException e) {
            throw new RuntimeException(e);
        } finally {
            if (in != null) {
                in.close();
            }
            if (out != null) {
                out.close();
            }
        }
    }

    private void createCaracteres() throws IOException {
        // https://docs.oracle.com/javase/tutorial/essential/io/charstreams.html
        try {
            inputStream = new FileReader(canino.getFoto());
            outputStream = new FileWriter("outCanino.txt");

            int c;
            while ((c = inputStream.read()) != -1) {
                outputStream.write(c);
            }
        } catch (IOException e) {
            throw new RuntimeException(e);
        } finally {
            if (inputStream != null) {
                inputStream.close();
            }
            if (outputStream != null) {
                outputStream.close();
            }
        }
    }


    @Override
    public void actionPerformed(ActionEvent e) {
        try {
            if (e.getSource() == btnCargar) {
                System.out.println("Información");
                cargarDatos(canino);
            }
            if (e.getSource() == btnBytes) {
                System.out.println("Bytes");
                crearBytes();
            }
            if (e.getSource() == btnCaracteres) {
                System.out.println("Caracteres");
                createCaracteres();
            }
        } catch (IOException ex) {
            throw new RuntimeException(ex);
        }
    }


}
