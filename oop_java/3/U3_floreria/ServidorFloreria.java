import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.DataInputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class ServidorFloreria {

    public static void main(String[] args){
        System.out.println("\n\n\tFlores de mi Huerto Servidor");
        MarcoServidor ventana = new MarcoServidor();
        ventana.setVisible(true);
    }

}



/* ------------------------------------------------------------------ */
class MarcoServidor
        extends JFrame{
    ServidorFormulario formulario;

    public MarcoServidor() throws HeadlessException {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setTitle("Servidor de Floreria Juan");
        this.setLocation(600,300);
        this.setSize(400,300);
        this.setBackground(Color.BLACK);
        formulario = new ServidorFormulario();
        getContentPane().add(formulario);
    }
}



/* ------------------------------------------------------------------ */
class ServidorFormulario
        extends JPanel
        implements ActionListener,
        Runnable{

    private JLabel registro;
    private JTextArea registroArea;
    private JComboBox comboCatalogo;
    private JButton btnBuscar;
    private JButton btnSalir;
    private JButton btnImprimir;

    public ServidorFormulario() {
        setLayout(new BoxLayout(this, BoxLayout.PAGE_AXIS));
        registro = new JLabel("Registro");
        registroArea = new JTextArea();
        comboCatalogo = new JComboBox(new String[] {
                "Flores",
                "Arreglos florales",
                "Regalos disponibles",
                "Revisar imágenes",
                "Precios",
                "Descripción"
        });

        btnBuscar = new JButton("Buscar");
        btnBuscar.addActionListener(this);
        btnImprimir = new JButton("Imprimir");
        btnImprimir.addActionListener(this);
        btnSalir = new JButton("Salir");
        btnSalir.addActionListener(this);


        add(registro);
        add(registroArea);
        add(new JTextField("Seleccione Catalogo:"));
        add(comboCatalogo);
        add(btnBuscar);
        add(btnImprimir);
        add(btnSalir);
    }   //


    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == btnBuscar) {
            System.out.println("buscar");

        }
        if (e.getSource() == btnImprimir) {
            System.out.println("imprimir");

        }
        if (e.getSource() == btnSalir) {
            System.out.println("Bye");
            System.exit(0);
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
            registroArea.append("\n" + mensaje_texto);
            // cierra la conexión ,por lo que no se puede recibir otro mensaje
            // para evitar esto se debe introduce en un bucle
            socket.close();
            //}
        }catch (IOException e){
            e.printStackTrace();
        }

    }   // end runnable

}

