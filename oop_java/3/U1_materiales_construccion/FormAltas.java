import javax.swing.*;
import java.awt.*;

public class FormAltas extends JPanel {

    JLabel encargadoLabel = new JLabel("Encargado");
    JLabel obraLabel = new JLabel("Obra");
    JLabel zonaLabel = new JLabel("Zona");
    JLabel metrosLabel = new JLabel("Metros");
    JLabel departamentoLabel = new JLabel("Departamento");
    JLabel fechaEntregaLabel = new JLabel("Fecha de entrega");

    JTextField encargado=new JTextField(15);
    JTextField obra=new JTextField(15);
    JTextField zona=new JTextField(15);
    JTextField metros=new JTextField(15);
    JTextField departamento=new JTextField(15);
    JTextField fechaEntrega=new JTextField(15);
    JCheckBox append = new JCheckBox("Agregar", false);
    JLabel appendLabel = new JLabel("Información en el mismo archivo");

    public FormAltas() {

        setLayout(new GridLayout(7,2));
        add(this.encargadoLabel);
        add(encargado);
        add(this.obraLabel);
        add(obra);
        add(this.zonaLabel);
        add(zona);
        add(this.metrosLabel);
        add(metros);
        add(this.departamentoLabel);
        add(departamento);
        add(this.fechaEntregaLabel);
        add(fechaEntrega);
        add(append);
        add(appendLabel);

    }
}
