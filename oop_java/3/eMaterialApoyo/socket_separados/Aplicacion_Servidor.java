import javax.swing.JOptionPane;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.ServerSocket;
import java.net.Socket;

/** Esta clase representa el programa servidor */
public class Aplicacion_Servidor extends javax.swing.JFrame {
    /** Creates new form AplicacionServidor */
    public  Aplicacion_Servidor(){
        initComponents();
    }   // end

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">

    private void initComponents(){
        /* En esta sección se tienen los elementos que compondrán la apariencia gráfica
        de la aplicación, declaraciones y acomodos en la pantalla */
        txtPuertoSocket = new javax.swing.JTextField();
        lblPuertoSocket = new javax.swing.JLabel();
        btnAbrirPuerto = new javax.swing.JButton();
        btnCerrarPuerto = new javax.swing.JButton();
        jPanel1 = new javax.swing.JPanel();
        jScrollPane1 = new javax.swing.JScrollPane();
        txtaDatosEntrantes = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Comunicacion con Sockets - Servidor");

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
        btnCerrarPuerto.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCerrarPuertoActionPerformed(evt);
            }
        });

        jPanel1.setBorder(javax.swing.BorderFactory.createTitledBorder("Datos Recibidos"));
        jPanel1.setEnabled(false);
        jPanel1.setLayout(new java.awt.BorderLayout());

        txtaDatosEntrantes.setColumns(20);
        txtaDatosEntrantes.setEditable(false);
        txtaDatosEntrantes.setRows(5);
        txtaDatosEntrantes.setEnabled(false);
        jScrollPane1.setViewportView(txtaDatosEntrantes);

        jPanel1.add(jScrollPane1, java.awt.BorderLayout.CENTER);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);

        layout.setHorizontalGroup(
                layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(layout.createSequentialGroup()
                                .addContainerGap()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addGroup(layout.createSequentialGroup()
                                                .addComponent(lblPuertoSocket,
                                                        javax.swing.GroupLayout.PREFERRED_SIZE, 74,
                                                        javax.swing.GroupLayout.PREFERRED_SIZE)
                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                .addComponent(txtPuertoSocket,
                                                javax.swing.GroupLayout.PREFERRED_SIZE, 111,
                                                javax.swing.GroupLayout.PREFERRED_SIZE)
                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                .addComponent(btnAbrirPuerto)
                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                .addComponent(btnCerrarPuerto)
                                                .addGap(0, 40, Short.MAX_VALUE))
                                        .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE,
                                                javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                                .addContainerGap())
        );

        layout.linkSize(javax.swing.SwingConstants.HORIZONTAL, new
                java.awt.Component[] {btnAbrirPuerto, btnCerrarPuerto});

        layout.setVerticalGroup(
                layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(layout.createSequentialGroup()
                                .addContainerGap()
                                .addGroup(layout.createParallelGroup(
                                                javax.swing.GroupLayout.Alignment.BASELINE)
                                        .addComponent(txtPuertoSocket,
                                                javax.swing.GroupLayout.PREFERRED_SIZE,
                                                javax.swing.GroupLayout.DEFAULT_SIZE,
                                                javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addComponent(lblPuertoSocket)
                                        .addComponent(btnAbrirPuerto)
                                        .addComponent(btnCerrarPuerto))
                                .addPreferredGap(
                                        javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, 162,
                                        Short.MAX_VALUE)
                                .addContainerGap())
        );

        java.awt.Dimension screenSize = java.awt.Toolkit.getDefaultToolkit().getScreenSize();
        setBounds((screenSize.width-403)/2, (screenSize.height-253)/2, 403, 253);
    }// </editor-fold>
    /* Aquí se termina la creación de la apariencia gráfica */


    /* El boton de Abrir Puerto será el que mande a llamar al método abrirSocket */
    private void btnAbrirPuertoActionPerformed(java.awt.event.ActionEvent evt) {
        // your handling code here:
        abrirSocket();
    }


    /* El boton Cerrar Puerto manda a llamar al método cerrarSocket */
    private void btnCerrarPuertoActionPerformed(java.awt.event.ActionEvent evt) {
        // your handling code here:
        cerrarSocket();
    }


    /** El método principal invoca a que se ejecute la aplicación del servidor */
    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Aplicacion_Servidor().setVisible(true);
            }
        });
    }

    /* A continuación se presenta el método de abrirSocket */
    public void abrirSocket()
    {
        String msg = null;
        int puerto = 0;

        try
        {
            //Establecemos el puerto a través del cual se abrirá el socket.
            puerto = Integer.valueOf(txtPuertoSocket.getText().trim());
            //Se asigna ese Puerto al socket creado
            serverSocket = new ServerSocket(puerto);

            //Habilitamos y deshabilitamos controles de la interfaz de usuario para evitar un funcionamiento indeseado.
            habilitarControlesAperturaDeSocket(false);

            //Notificamos al usuario que se ha creado un socket.
            msg ="Socket creado exitosamente en el puerto " + puerto + "." +
                    "\n\nEl programa quedará bloqueado hasta que se establezca alguna conexión con un cliente.";

            JOptionPane.showMessageDialog(this, msg, "Socket creado.",
                    JOptionPane.INFORMATION_MESSAGE);

            //Esperamos a que un cliente se conecte.
            cliente = serverSocket.accept();

            //Obtenemos los objetos para poder leer y escribir a través del socket
            entrada = cliente.getInputStream();
            salida = cliente.getOutputStream();
            lector = new DataInputStream(entrada);
            escritor = new DataOutputStream(salida);
            leerDatosDelCliente();
        }
        //Si el usuario captura un número de puerto incorrecto se captura el error y se le notifica al usuario.
        catch (NumberFormatException nfe)
        {
            msg = "El numero de puerto debe ser un numero entero mayor a 0 y menor a 65535.";
            JOptionPane.showMessageDialog(this, msg,
                    "Numero de puerto incorrecto",
                    JOptionPane.ERROR_MESSAGE);
            nfe.printStackTrace();
        }
        //Si el usuario intenta acceder a un numero de puerto no disponible se captura el error y se le notifica al usuario.
        catch (Exception e)
        {
            msg = "Error al intentar abrir socket en el puerto " + puerto +
                    "\n\nProbablemente el puerto esté en uso o el firewall de su equipo impidio su apertura.";
            JOptionPane.showMessageDialog(this, msg, "Error", JOptionPane.ERROR_MESSAGE);
        }
    } //Termina el método se abrirSocket


    // Inicia el método de cerrarSocket
    public void cerrarSocket()
    {
        String msg = null;

        try
        {
            leyendo = false;
            // Se está en espera de recibir comunicación por parte del cliente.
            if (cliente != null)
            {
                //Con esto se cierra la conexión con el cliente.
                cliente.close();
                //Con esto se cierra el socket servidor, ya no atendemos más conexiones.
                serverSocket.close();

                cliente = null;
                serverSocket = null;

                habilitarControlesAperturaDeSocket(true);
            }
        }
        /* En el caso de que no se pueda cerrar el socket se captura la excepción y se cierra el sistema */
        catch (Exception e)
        {
            msg = "Error al intentar cerrar el socket.\n\nEl sistema se cerrara después de este cuadro de dialogo.";
            JOptionPane.showMessageDialog(this, msg, "Error", JOptionPane.ERROR_MESSAGE);
            e.printStackTrace();
        }
    }


    /* El siguiente es el método para en caso de abrir el socket se habiliten los
   componentes gráficos o se deshabiliten según sea el estado del socket */
    public void habilitarControlesAperturaDeSocket(boolean value)
    {
        //Habilitamos los controles para la apertura del socket
        lblPuertoSocket.setEnabled(value);
        txtPuertoSocket.setEnabled(value);
        btnAbrirPuerto.setEnabled(value);
        //Deshabilitamos los controles de recepcion de datos y cierre
        btnCerrarPuerto.setEnabled(!value);
        txtaDatosEntrantes.setEnabled(!value);
        jPanel1.setEnabled(!value);
    }


    /* El siguiente método es para leer los datos que el cliente envía hacia el servidor */
    public void leerDatosDelCliente()
    {
        Thread t = null;

         /** Creamos un objeto para leer datos del cliente indefinidamente
         a través de un hilo. La interface Runnable solamente declara una función
        miembro denominada run, que han de definir las clases que implementen este interface
        */
        Runnable r = new Runnable()
        {
            /* Se declara entonces la función run, que implementa la interface Runnable */
            @Override
            public void run()
            {
                if (leyendo)
                    return;
                leyendo = true;

                while (leyendo)
                {
                /* Mientras se está leyendo se toman los datos que se están
                    introduciendo, en la caja de texto txtaDatosEntrantes*/
                    try
                    {
                        txtaDatosEntrantes.setText(txtaDatosEntrantes.getText() +
                                "\n" +
                                lector.readUTF());
                        if (txtaDatosEntrantes.getText().length() > 0)
                            txtaDatosEntrantes.setCaretPosition(
                                    txtaDatosEntrantes.getText().length() - 1);
                    }
                    catch (Exception e)
                    {
                        e.printStackTrace();
                    }
                }
            }
        };

        t = new Thread(r);

        //Se inicializa el hilo de lectura
        t.start();
    }


    // Variables declaration - do not modify
    private javax.swing.JButton btnAbrirPuerto;
    private javax.swing.JButton btnCerrarPuerto;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblPuertoSocket;
    private javax.swing.JTextField txtPuertoSocket;
    private javax.swing.JTextArea txtaDatosEntrantes;
    // End of variables declaration


    //Socket Servidor que aceptara conexiones de clientes
    ServerSocket serverSocket;
    //Objeto que se comunicará con los clientes para enviar y recibir datos.
    Socket cliente;
    //Objetos que permitiran leer y escribir flujos de bits través del socket.
    InputStream entrada;
    OutputStream salida;
    //Objetos que permitiran leer valores de algun tipo desde el socket.
    DataInputStream lector;
    DataOutputStream escritor;

    //Esta variable sirve para mantener o cerrar el ciclo de lectura de datos desde el cliente
    boolean leyendo;
}
