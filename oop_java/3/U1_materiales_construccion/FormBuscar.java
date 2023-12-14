/**
 * agregar un formulario donde solicite: encargado y obra para visualizar la
 * información en un componente gráfico
 * */
import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class FormBuscar extends JPanel {
    JLabel encargadoLabel;
    JLabel obraLabel;

    JTextField encargadoField;
    JTextField obraField;
    JButton buscarBtn;

    String encargado;
    String obra;
    String findData;

    public FormBuscar() {
        setLayout(new BoxLayout(this,BoxLayout.Y_AXIS ));

        encargadoLabel = new JLabel("Encargado");
        obraLabel = new JLabel("Obra");
        encargadoField = new JTextField(15);
        obraField = new JTextField(15);
        buscarBtn = new JButton("Buscar");

        buscarBtn.addActionListener(new BtnBuscarListener());

        JButton regresar = new JButton("Regresar");
        regresar.addActionListener(new BtnRegresarListener());

        add(new JLabel("Buscar encargado de obra", SwingConstants.CENTER));
        add(encargadoLabel);
        add(encargadoField);
        add(obraLabel);
        add(obraField);
        add(buscarBtn);
        add(regresar);

    }

    private void recoverAndCleanData(){
        this.encargado = this.encargadoField.getText().trim();
        this.obra = this.obraField.getText().trim();
        this.encargadoField.setText("");
        this.obraField.setText("");

        this.findData = encargado+","+obra;
    }

    // ******* ******* ******* LISTENER_BTN-BUSCAR ******* ******* ******* //
    class BtnBuscarListener implements ActionListener{
        @Override
        public void actionPerformed(ActionEvent e){
            recoverAndCleanData();
            System.out.println("Boton buscar: " + findData);
        }
    }

    // ******* ******* ******* LISTENER_REGRESAR ******* ******* ******* //
    class BtnRegresarListener implements ActionListener {

        public BtnRegresarListener() {
        }

        @Override
        public void actionPerformed(ActionEvent e) {
            removeAll();
            add(new MenuEdificio());
            System.out.println("Regresando al menu edificio");
            revalidate();
        }
    } // END inner class BtnRegresarListener
}
