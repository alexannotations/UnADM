import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.net.UnknownHostException;

public class ClienteFloreria {

    public static void main(String[] args){
        System.out.println("\n\n\tFlores de mi Huerto Cliente");
        MarcoCliente ventana = new MarcoCliente();
        ventana.setVisible(true);
    }

}



/* ------------------------------------------------------------------ */
class MarcoCliente
        extends JFrame{
    FloreriaFormulario formulario;

    public MarcoCliente() throws HeadlessException {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setTitle("Flores de mi Huerto Cliente");
        this.setLocation(100,300);
        this.setSize(400,500);
        this.setBackground(Color.BLACK);
        formulario = new FloreriaFormulario();
        getContentPane().add(formulario);
    }

}



/* ------------------------------------------------------------------ */
class FloreriaFormulario
        extends JPanel
        implements ActionListener,
        Runnable{

    private JLabel title = new JLabel("Formulario de pedido");
    private JLabel labelArticulos;
    private JLabel labelDireccion;
    private JLabel labelCostoProducto;
    private JLabel labelCargosEnvio;

    private JTextArea textArticulos;
    private JTextField textDireccion;
    private JTextField textCostoProducto;
    private JTextField textCargosEnvio;

    private JButton btnEnviar;
    private JButton btnSalir;

    public FloreriaFormulario() {
        setLayout(new BoxLayout(this, BoxLayout.PAGE_AXIS));
        labelArticulos = new JLabel("Lista de articulos: ");
        textArticulos = new JTextArea();
        labelDireccion = new JLabel("Dirección: ");
        textDireccion = new JTextField();
        labelCostoProducto = new JLabel("Costo del producto: ");
        textCostoProducto = new JTextField();
        labelCargosEnvio = new JLabel("Cargos por el envío.: ");
        textCargosEnvio = new JTextField();

        btnEnviar = new JButton("Enviar");
        btnEnviar.addActionListener(this);
        btnSalir = new JButton("Salir");
        btnSalir.addActionListener(this);

        add(title);

        add(labelArticulos);
        add(textArticulos);
        add(labelDireccion);
        add(textDireccion);
        add(labelCostoProducto);
        add(textCostoProducto);
        add(labelCargosEnvio);
        add(textCargosEnvio);

        add(btnEnviar);

        add(btnSalir);
    }

    private String salvarDatos(){
        Pedido pedido = new Pedido();
        return pedido.toString();
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

        if (e.getSource() == btnSalir) {
            System.out.println("Bye");
            System.exit(0);
        }

    }   // end listener

    @Override
    public void run() {

    }   // end runnable
}

