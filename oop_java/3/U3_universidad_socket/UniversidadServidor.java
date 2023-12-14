import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.DataInputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class UniversidadServidor {

    public static void main(String[] args){
        System.out.println("\n\n\tUniversidad Mexicana Servidor");
        UniversidadMarco ventanaUniversidad = new UniversidadMarco();
        ventanaUniversidad.setVisible(true);
    }

}



/* ------------------------------------------------------------------ */
class UniversidadMarco
        extends JFrame{
    UniversidadFormulario formularioUniversidad;

    public UniversidadMarco() throws HeadlessException {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setTitle("Servidor de horarios");
        this.setLocation(600,300);
        this.setSize(400,300);
        this.setBackground(Color.BLACK);
        formularioUniversidad = new UniversidadFormulario();
        getContentPane().add(formularioUniversidad);
    }
}



/* ------------------------------------------------------------------ */
class UniversidadFormulario
        extends JPanel
        implements ActionListener,
                    Runnable{

    private JLabel title;
    private JTextArea respuestaRecibida;
    private JTextArea horariosSolicitados;
    private JButton btnEnviar;

    public UniversidadFormulario() {
        setLayout(new BoxLayout(this, BoxLayout.PAGE_AXIS));
        title = new JLabel("Respuesta recibida");
        respuestaRecibida = new JTextArea();
        horariosSolicitados = new JTextArea();
        btnEnviar = new JButton("Enviar respuesta a cliente");
        btnEnviar.addActionListener(this);

        add(title);
        add(respuestaRecibida);
        add(new JTextField("Horarios a enviar:"));
        add(horariosSolicitados);
        add(btnEnviar);
    }   //


    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == btnEnviar) {
            System.out.println("Enviar respuesta a cliente");

        }
    }   // end listener


    @Override
    public void run() {
        System.out.println("Hilo a la escucha");
        try {
            // se programa el socket para abrir un puerto y tenerlo a la escucha
            ServerSocket serverSocket = new ServerSocket(3456);
            //while (true) {   // bucle infinito
                // aceptar conexion del exterior
                Socket socket = serverSocket.accept();

                // flujo de entrada que recoje los datos enviados del cliente (socket por el que viaja la info de entrada)
                DataInputStream flujoentrada = new DataInputStream(socket.getInputStream());
                // leer lo que viene en el flujo de entra
                String mensaje_texto = flujoentrada.readUTF();
                // Idicamos que lo escriba en el JTextArea
                respuestaRecibida.append("\n" + mensaje_texto);
                // cierra la conexión ,por lo que no se puede recibir otro mensaje
                // para evitar esto se debe introduce en un bucle
                socket.close();
            //}
        }catch (IOException e){
                e.printStackTrace();
        }

    }   // end runnable

}

