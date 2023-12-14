import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import javax.swing.JOptionPane;

/**
 * Esta clase representa el programa cliente.
 */
public class Aplicacion_Cliente extends javax.swing.JFrame {
    // End of variables declaration
    //Objeto que se comunicará con el servidor para enviarle datos.
    Socket cliente;
    //Objetos que permitirán leer y escribir flujos de bits través del socket.
    InputStream entrada;
    OutputStream salida;
    //Objetos que permitirán leer valores de algún tipo desde el socket.
    DataInputStream lector;
    DataOutputStream escritor;
    //Esta variable sirve para mantener o cerrar el ciclo de lectura de datos
    //desde el cliente
    boolean leyendo;
    // Variables declaration - do not modify
    private javax.swing.JButton btnAbrirPuerto;
    private javax.swing.JButton btnCerrarPuerto;
    private javax.swing.JButton btnEnviarDatos;
    private javax.swing.JLabel lblIp;
    private javax.swing.JLabel lblPuertoSocket;
    private javax.swing.JTextField txtDatos;
    private javax.swing.JTextField txtIp;
    private javax.swing.JTextField txtPuertoSocket;

    /**
     * Creates new form Aplicacion_Servidor
     */
    public Aplicacion_Cliente() {
        initComponents();
    }

    /**
     * El método principal invoca a que se ejecute la aplicación del cliente
     */
    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            @Override
            public void run() {
                new Aplicacion_Cliente().setVisible(true);
            }
        });
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">

    private void initComponents() {
    /* En esta sección se tienen los elementos que compondrán la apariencia grafica
    de la aplicación, declaraciones y acomodos en la pantalla */
        txtPuertoSocket = new javax.swing.JTextField();
        lblPuertoSocket = new javax.swing.JLabel();
        btnAbrirPuerto = new javax.swing.JButton();
        btnCerrarPuerto = new javax.swing.JButton();
        lblIp = new javax.swing.JLabel();
        txtIp = new javax.swing.JTextField();
        txtDatos = new javax.swing.JTextField();
        btnEnviarDatos = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Comunicacion con Sockets - Cliente");

        txtPuertoSocket.setText("12345");

        lblPuertoSocket.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        lblPuertoSocket.setText("Puerto:");

        btnAbrirPuerto.setText("Abrir");
        btnAbrirPuerto.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAbrirPuertoActionPerformed(evt);
            }
        });

        btnCerrarPuerto.setText("Cerrar");
        btnCerrarPuerto.setEnabled(false);

        lblIp.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        lblIp.setText("IP:");

        txtIp.setText("127.0.0.1");

        txtDatos.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                txtDatosKeyReleased(evt);
            }
        });

        btnEnviarDatos.setText("Enviar");
        btnEnviarDatos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEnviarDatosActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);

        layout.setHorizontalGroup(
                layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(layout.createSequentialGroup()
                                .addContainerGap()
                                .addGroup(layout.createParallelGroup(
                                                javax.swing.GroupLayout.Alignment.LEADING)
                                        .addGroup(layout.createSequentialGroup()
                                                .addGroup(layout.createParallelGroup(
                                                                javax.swing.GroupLayout.Alignment.LEADING, false)
                                                        .addComponent(lblPuertoSocket,
                                                                javax.swing.GroupLayout.DEFAULT_SIZE,
                                                                74, Short.MAX_VALUE)
                                                        .addComponent(lblIp,
                                                                javax.swing.GroupLayout.DEFAULT_SIZE,
                                                                javax.swing.GroupLayout.DEFAULT_SIZE,
                                                                Short.MAX_VALUE))
                                                .addPreferredGap(
                                                        javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                .addGroup(layout.createParallelGroup(
                                                                javax.swing.GroupLayout.Alignment.LEADING,
                                                                false)
                                                        .addGroup(layout.createSequentialGroup()
                                                                .addComponent(txtPuertoSocket,
                                                                        javax.swing.GroupLayout.PREFERRED_SIZE,
                                                                        111,
                                                                        javax.swing.GroupLayout.PREFERRED_SIZE)
                                                                .addPreferredGap(
                                                                        javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                                .addComponent(btnAbrirPuerto)
                                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                                .addComponent(btnCerrarPuerto))
                                                        .addComponent(txtIp)))
                                        .addGroup(layout.createSequentialGroup()
                                                .addComponent(txtDatos,
                                                        javax.swing.GroupLayout.PREFERRED_SIZE, 258,
                                                        javax.swing.GroupLayout.PREFERRED_SIZE)
                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                .addComponent(btnEnviarDatos)))
                                .addContainerGap(49, Short.MAX_VALUE))
        );

        layout.linkSize(javax.swing.SwingConstants.HORIZONTAL, new
                java.awt.Component[]{btnAbrirPuerto, btnCerrarPuerto});

        layout.setVerticalGroup(
                layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(layout.createSequentialGroup()
                                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE,
                                        Short.MAX_VALUE)
                                .addGroup(layout.createParallelGroup(
                                                javax.swing.GroupLayout.Alignment.BASELINE)
                                        .addComponent(lblIp)
                                        .addComponent(txtIp, javax.swing.GroupLayout.PREFERRED_SIZE,
                                                javax.swing.GroupLayout.DEFAULT_SIZE,
                                                javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(layout.createParallelGroup(
                                                javax.swing.GroupLayout.Alignment.BASELINE)
                                        .addComponent(txtPuertoSocket,
                                                javax.swing.GroupLayout.PREFERRED_SIZE,
                                                javax.swing.GroupLayout.DEFAULT_SIZE,
                                                javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addComponent(lblPuertoSocket)
                                        .addComponent(btnAbrirPuerto)
                                        .addComponent(btnCerrarPuerto))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addGroup(layout.createParallelGroup(
                                                javax.swing.GroupLayout.Alignment.BASELINE)
                                        .addComponent(txtDatos, javax.swing.GroupLayout.PREFERRED_SIZE,
                                                javax.swing.GroupLayout.DEFAULT_SIZE,
                                                javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addComponent(btnEnviarDatos))
                                .addGap(179, 179, 179))
        );

        java.awt.Dimension screenSize =
                java.awt.Toolkit.getDefaultToolkit().getScreenSize();

        setBounds((screenSize.width - 402) / 2, (screenSize.height - 145) / 2, 402, 145);
    }// </editor-fold>
    /* Aquí se termina la creación de la apariencia gráfica */


    /* El boton de Abrir Puerto será el que mande a llamar al método abrirConexionConElServidor */
    private void btnAbrirPuertoActionPerformed(java.awt.event.ActionEvent evt) {
        // your handling code here:
        abrirConexionConElServidor();
    }

    /* El botón de Enviar Datos será el que mande a llamar al método enviarDatos */
    private void btnEnviarDatosActionPerformed(java.awt.event.ActionEvent evt) {
        // your handling code here:
        enviarDatos();
    }

    /* Se tiene un manejo de evento sobre txtDatos para estar escuchando cada una de las teclas que se oprimen */
    private void txtDatosKeyReleased(java.awt.event.KeyEvent evt) {
        // your handling code here:
        if (evt.getKeyCode() == evt.VK_ENTER)
            enviarDatos();
    }

    /* A continuación se presenta el método de abrirConexionConElServidor para estar enviando los datos desde el cliente */
    public void abrirConexionConElServidor() {
        String msg = null;
        String ip = null;
        int puerto = 0;

        try {
            //Establecemos la ip del servidor
            ip = txtIp.getText().trim();
            //Establecemos el puerto a través del cual se abrirá el socket.
            puerto = Integer.valueOf(txtPuertoSocket.getText().trim());

            //Establecemos la conexión con el servidor
            cliente = new Socket(ip, puerto);

            //Habilitamos y deshabilitamos controles de la interfaz de usuario para evitar un funcionamiento indeseado.
            habilitarControlesAperturaDeSocket(false);

            //Notificamos al usuario que se ha creado un socket.
            msg = "Conexión realizada con el servidor exitosamente.";
            JOptionPane.showMessageDialog(this, msg, "Socket creado.",
                    JOptionPane.INFORMATION_MESSAGE);
            //Obtenemos los objetos para poder leer y escribir a través del socket
            entrada = cliente.getInputStream();
            salida = cliente.getOutputStream();
            lector = new DataInputStream(entrada);
            escritor = new DataOutputStream(salida);
        } catch (NumberFormatException nfe) {
            //Notificamos al usuario que se ha creado un socket
            msg = "El numero de puerto debe ser un numero entero mayor a 0 y menor a 65535.";
            JOptionPane.showMessageDialog(this, msg,
                    "Numero de puerto incorrecto",
                    JOptionPane.ERROR_MESSAGE);
            nfe.printStackTrace();
        } catch (Exception e) {
            //Si el usuario intenta acceder a un numero de puerto no disponible se captura el error y se le notifica al usuario.
            msg = "Error al intentar abrir socket.\n" +
                    "Ip: " + txtIp.getText() + "\n" +
                    "Puerto: " + puerto +
                    "\n\nProbablemente el puerto esté en uso o el firewall de su equipo o del servidor impidio su apertura.";
            JOptionPane.showMessageDialog(this, msg, "Error",
                    JOptionPane.ERROR_MESSAGE);
        }
    }

    // Se tiene el método para cerrar el socket previamente abierto.
    public void cerrarSocket() {
        String msg = null;

        try {
            leyendo = false;
            if (cliente != null) {
                //Con esto se cierra la conexión con el servidor
                cliente.close();
                cliente = null;
                habilitarControlesAperturaDeSocket(true);
            }
        } catch (Exception e) {
            //Si el usuario intenta cerrar un socket no disponible se captura el error y se le notifica al usuario.
            msg = "Error al intentar cerrar el socket.\n\n" +
                    "El sistema se cerrara después de este cuadro de dialogo.";
            JOptionPane.showMessageDialog(this, msg, "Error",
                    JOptionPane.ERROR_MESSAGE);
            e.printStackTrace();
        }
    }


    /* El siguiente es el método para en caso de entablar comunicación se habiliten los
    componentes gráficos o se deshabiliten según sea el estado de la conexión */
    public void habilitarControlesAperturaDeSocket(boolean value) {
        //Habilitamos los controles para la apertura del socket
        lblIp.setEnabled(value);
        txtIp.setEnabled(value);
        lblPuertoSocket.setEnabled(value);
        txtPuertoSocket.setEnabled(value);
        btnAbrirPuerto.setEnabled(value);

        //Deshabilitamos los controles de recepcion de datos y cierre
        btnCerrarPuerto.setEnabled(!value);
        txtDatos.setEnabled(!value);
        btnEnviarDatos.setEnabled(!value);
    }

    /*A continuación se presenta el método que envía datos, el cual primero los obtiene
    de txtDatos y después los envía mediante un DataOutputStream */
    public void enviarDatos() {
        try {
            escritor.writeUTF(txtDatos.getText());
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

}
