import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class MenuPrincipal extends JPanel{

    JLabel title = new JLabel("Voladores Mexicanos");
    JTextArea infoArea;
    JButton iniciar;
    JButton mostrar;
    JProgressBar destino1Progreso;
    JProgressBar destino2Progreso;
    JProgressBar destino3Progreso;

    ActionListener ventasListener;

    Reservacion reservacion1, reservacion2, reservacion3;
    Thread t1,t2,t3 ;


    public MenuPrincipal(BorderLayout layout) {
        super(layout);
        setBackground(Color.WHITE);
        infoArea = new JTextArea();
        infoArea.setEditable(false);

        iniciar = new JButton("Iniciar");
        mostrar = new JButton("Mostrar resultados");

        destino1Progreso = new JProgressBar(0,100);
        destino1Progreso.setStringPainted(true);
        destino1Progreso.setValue(0);
        destino2Progreso = new JProgressBar(0,100);
        destino2Progreso.setStringPainted(true);
        destino2Progreso.setValue(0);
        destino3Progreso = new JProgressBar(0,100);
        destino3Progreso.setStringPainted(true);
        destino3Progreso.setValue(0);

        reservacion1 =new Reservacion(new Vuelo("Los ángeles",186,5500));
        reservacion2 =new Reservacion(new Vuelo("Bogotá",190,7600));
        reservacion3 = new Reservacion(new Vuelo("Madrid",144,11300));


         ventasListener = new ActionListener(){
             @Override
             public void actionPerformed(java.awt.event.ActionEvent e) {
                 System.out.println("Iniciar ventas");
                 t1 = new Thread(new Hilo(reservacion1,destino1Progreso));
                 t1.start();

                 t3 = new Thread(new Hilo(reservacion3,destino3Progreso));
                 t3.start();

                 t2 = new Thread(new Hilo(reservacion2,destino2Progreso));
                 t2.start();
             }
         };

        MostrarResultadoListener mostrarListener = new MostrarResultadoListener();
        iniciar.addActionListener(ventasListener);
        mostrar.addActionListener(mostrarListener);

        JPanel panelProgressBar = new JPanel();
        panelProgressBar.add(new JLabel("Los Ángeles"));
        panelProgressBar.add(destino1Progreso);
        panelProgressBar.add(new JLabel("Madrid"));
        panelProgressBar.add(destino2Progreso);
        panelProgressBar.add(new JLabel("Bogotá"));
        panelProgressBar.add(destino3Progreso);
        panelProgressBar.add(infoArea);

        add(title,BorderLayout.NORTH);
        add(panelProgressBar,BorderLayout.CENTER);
        add(iniciar,BorderLayout.WEST);
        add(mostrar,BorderLayout.EAST);

    }


    /** --------------------------- */
    class MostrarResultadoListener implements ActionListener{
        @Override
        public void actionPerformed(ActionEvent e) {
            System.out.println("Mostrar ventas");
            String infoGanador = Venta.mostrarInfoVentaFinal(Hilo.getGanador());
            String info1 = Venta.mostrarInfoVentaFinal(reservacion1);
            String info2 = Venta.mostrarInfoVentaFinal(reservacion2);
            String info3 = Venta.mostrarInfoVentaFinal(reservacion3);

            System.out.println(infoGanador);
            infoArea.setText(info1+info2+info3);
        }
    }
}
