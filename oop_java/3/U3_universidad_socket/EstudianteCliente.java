import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.net.UnknownHostException;

public class EstudianteCliente {

    public static void main(String[] args){
        System.out.println("\n\n\tUniversidad Mexicana Cliente");
        EstudianteMarco ventanaEstudiante = new EstudianteMarco();
        ventanaEstudiante.setVisible(true);
    }

}



/* ------------------------------------------------------------------ */
class EstudianteMarco
        extends JFrame{
    EstudianteFormulario formularioEstudiante;

    public EstudianteMarco() throws HeadlessException {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setTitle("Cliente estudiantes horarios");
        this.setLocation(100,300);
        this.setSize(400,500);
        this.setBackground(Color.BLACK);
        formularioEstudiante = new EstudianteFormulario();
        getContentPane().add(formularioEstudiante);
    }

}



/* ------------------------------------------------------------------ */
class EstudianteFormulario
        extends JPanel
        implements ActionListener,
                    Runnable{

    private JLabel title = new JLabel("Formulario de registro");
    private JLabel labelNombre;
    private JLabel labelMatricula;
    private JLabel labelSemestre;
    private JLabel labelCarrera;
    private JLabel labelActividadesExtra;
    private JLabel labelRespuesta;

    private JTextField textNombre;
    private JTextField textMatricula;
    private JTextField textSemestre;
    private JTextField textCarrera;
    private JComboBox comboActividadesDeportes;
    private JComboBox comboActividadesTalleresCursos;
    private JTextArea areaRespuesta;

    private JButton btnEnviar;
    private JButton btnImprimir;

    public EstudianteFormulario() {
        setLayout(new BoxLayout(this, BoxLayout.PAGE_AXIS));
        labelNombre = new JLabel("Nombre del estudiante: ");
        textNombre = new JTextField();
        labelMatricula = new JLabel("Matricula: ");
        textMatricula = new JTextField();
        labelSemestre = new JLabel("Semestre: ");
        textSemestre = new JTextField();
        labelCarrera = new JLabel("Carrera: ");
        textCarrera = new JTextField();

        labelActividadesExtra = new JLabel("Actividades extracurriculares: ");
        comboActividadesDeportes = new JComboBox(new String[] {
                "Deportes",
                "Fútbol",
                "Voleibol",
                "Básquetbol",
                "Taekwondo"
        });
        comboActividadesTalleresCursos = new JComboBox(new String[] {
                "Talleres y Cursos",
                "Taller de fotografía digital",
                "Curso de programación web",
                "Curso de programación móvil"
        });

        labelRespuesta = new JLabel("Respuesta de la Universidad: ");
        areaRespuesta = new JTextArea();

        btnEnviar = new JButton("Enviar");
        btnEnviar.addActionListener(this);
        btnImprimir = new JButton("Imprimir");
        btnImprimir.addActionListener(this);

        add(title);

        add(labelNombre);
        add(textNombre);
        add(labelMatricula);
        add(textMatricula);
        add(labelSemestre);
        add(textSemestre);
        add(labelCarrera);
        add(textCarrera);
        add(labelActividadesExtra);
        add(comboActividadesDeportes);
        add(comboActividadesTalleresCursos);
        add(btnEnviar);
        add(labelRespuesta);
        add(areaRespuesta);
        add(btnImprimir);
    }

    private String salvarDatos(){
        ActividadExtracurricular actividadExtra = new ActividadExtracurricular(
            textNombre.getText(),
            textMatricula.getText(),
            textSemestre.getText(),
            textCarrera.getText(),
            comboActividadesDeportes.getSelectedItem().toString(),
            comboActividadesTalleresCursos.getSelectedItem().toString()
        );
        // Convendría hacer un Serializable
        return actividadExtra.toString();
    }


    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == btnEnviar) {
            String mensaje = salvarDatos();
            System.out.println("Enviar petición al servidor: " + mensaje);

            try {
                // creacion del socket (tendido del puente para la comunicacion)
                Socket socket = new Socket("127.0.0.1",3456);
                // flujo de datos de salida
                // se indica que por el socket circulara el flujo de datos
                DataOutputStream flujo_salida = new DataOutputStream(socket.getOutputStream());
                // que datos van a circular
                flujo_salida.writeUTF(mensaje);
                flujo_salida.close();

            }catch (UnknownHostException uhe){
                uhe.printStackTrace();
            }catch (IOException ioe){
                ioe.printStackTrace();
                System.out.println(ioe.getMessage());
            }
        }

        if (e.getSource() == btnImprimir) {
            String respuesta = areaRespuesta.getText();
            System.out.println("Imprimir: " + respuesta);

        }

    }   // end listener

    @Override
    public void run() {

    }   // end runnable
}

