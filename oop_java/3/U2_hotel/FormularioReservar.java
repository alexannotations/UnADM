import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.util.concurrent.*;

public class FormularioReservar
        extends JPanel
        implements ActionListener {

    private static final int TIEMPO_RESERVA = 24; // El tiempo en segundos que dura la reserva por cada noche
    private static final Semaphore SEMAFORO = new Semaphore(5); // El semáforo que controla el acceso a las 5 habitaciones

    private JLabel title = new JLabel("Formulario de reservación");
    private JLabel labelClave;
    private JLabel labelNombre;
    private JLabel labelFecha;
    private JLabel labelHabitacion;
    private JLabel labelNoche;
    private JTextField textClave;
    private JTextField textNombre;
    private JTextField textFecha;
    private JComboBox comboHabitacion;
    private JComboBox comboNoche;
    private JButton buttonGuardar;

    public FormularioReservar(){
        setLayout(new BoxLayout(this, BoxLayout.PAGE_AXIS));
        labelClave = new JLabel("Clave cliente:");
        labelNombre = new JLabel("Nombre del cliente:");
        labelFecha = new JLabel("Fecha de reservación:");
        labelHabitacion = new JLabel("Número de habitación:");
        labelNoche = new JLabel("Tiempo de reservación (Noches de estancia):");
        textClave = new JTextField();
        textNombre = new JTextField();
        textFecha = new JTextField();
        comboHabitacion = new JComboBox(new String[] {"1", "2", "3", "4", "5"});
        comboNoche = new JComboBox(new String[] {"1", "2", "3", "4", "5", "6", "7"});
        buttonGuardar = new JButton("Guardar");

        add(labelClave);
        add(textClave);
        add(labelNombre);
        add(textNombre);
        add(labelFecha);
        add(textFecha);
        add(labelHabitacion);
        add(comboHabitacion);
        add(labelNoche);
        add(comboNoche);
        add(new JLabel());
        add(buttonGuardar);

        buttonGuardar.addActionListener(this);

    }

    public void hacerReservacion(){
        String habitacion = comboHabitacion.getSelectedItem().toString();
        String noches = comboNoche.getSelectedItem().toString();
        // Crear una instancia de la clase Reservacion con el número de habitación y el número de noches
        Reservacion reservacion = new Reservacion(Integer.parseInt(habitacion), Integer.parseInt(noches));
        // Crear un hilo que ejecute la reservacion y lo iniciar
        Thread hilo = new Thread(reservacion);
        hilo.start();
    }

    /** ActionListener */
    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == buttonGuardar) {
            // Guardar la información en un archivo TXT
            try {
                FileWriter fileWriter = new FileWriter("reservacion.txt", true);
                PrintWriter printWriter = new PrintWriter(fileWriter);
                this.hacerReservacion();
                printWriter.print(
                        textClave.getText() + "::"
                        + textNombre.getText() + "::"
                        + textFecha.getText() + "::"
                        + comboHabitacion.getSelectedItem() + "::"
                        + comboNoche.getSelectedItem()
                );
                printWriter.println();
                printWriter.close();
                fileWriter.close();
                JOptionPane.showMessageDialog(this, "La información se ha guardado correctamente.");
            } catch (IOException ex) {
                JOptionPane.showMessageDialog(this, "Ha ocurrido un error al guardar la información.");
            }
        }
    }   // end


}
