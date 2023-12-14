import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Ventana extends javax.swing.JFrame {

    private Hilo hilo1;
    private Hilo hilo2;

    JProgressBar barra1;
    public JProgressBar getBarra1(){
        return barra1;
    }
    JProgressBar barra2;
    public JProgressBar getBarra2(){
        return barra2;
    }

    JButton bInicio;
    JButton bMostrar;


    public Ventana(){
        initComponents();
    }

    public static void main(String[] args) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            @Override
            public void run() {
                new Ventana().setVisible(true);
            }
        });
    }





    public void initComponents(){
        setLayout(new BorderLayout());
        setBounds(550,300,500,120);
        setVisible(true);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        barra1 = new JProgressBar(0,40);
        barra2 = new JProgressBar(0,60);
        bInicio = new JButton("Inicio");
        bMostrar = new JButton("Mostrar");

        bInicio.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                hilo1 = new Hilo();
                hilo1.setBarra1(barra1);
                hilo1.start();
                hilo2 = new Hilo();
                hilo2.setBarra1(barra2);
                hilo2.start();
            }
        });

        barra1.setStringPainted(true);
        barra2.setStringPainted(true);

        add(barra1, BorderLayout.WEST);
        add(barra2, BorderLayout.EAST);
        add(bInicio, BorderLayout.NORTH);
        add(bMostrar, BorderLayout.SOUTH);
    }
}
