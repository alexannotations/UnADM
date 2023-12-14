import javax.swing.*;
import javax.swing.table.*;
import java.awt.*;
import java.io.*;

public class FormularioHistorial
        extends JPanel {

    private JLabel title = new JLabel("Historial de reservaciones");
    private JTable table;
    private DefaultTableModel model;
    private JScrollPane scrollPane;

    public FormularioHistorial() {
        setLayout(new BorderLayout());

        model = new DefaultTableModel();
        model.addColumn("Clave cliente");
        model.addColumn("Nombre del cliente");
        model.addColumn("Fecha de reservación");
        model.addColumn("Número de habitación");
        model.addColumn("Noches de reservación");

        table = new JTable(model);
        scrollPane = new JScrollPane(table);

        add(scrollPane, BorderLayout.CENTER);

        cargarDatos();
    }

    public void cargarDatos() {
        // Leer el archivo TXT y cargar los datos en la tabla
        try {
            FileReader fileReader = new FileReader("reservacion.txt");
            BufferedReader bufferedReader = new BufferedReader(fileReader);
            String renglon = bufferedReader.readLine();
            while (renglon != null) {
                String[] datos = renglon.split("::");
                model.addRow(datos);
                //System.out.println(renglon);
                renglon = bufferedReader.readLine();
            }
            bufferedReader.close();
            fileReader.close();
        } catch (IOException ex) {
            JOptionPane.showMessageDialog(this, "Ha ocurrido un error al cargar los datos.");
        }
    }
}
