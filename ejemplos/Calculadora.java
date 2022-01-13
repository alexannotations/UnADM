/* ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** **
 * Calculadora Grafica
 * PildorasInformaticas Java. Layouts III. Vídeo 83
 *
 * ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** */

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;


public class Calculadora {
    public static void main(String[] args) {
        MarcoCalculadora myFrame = new MarcoCalculadora();
        myFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        myFrame.setVisible(true);
    }
}


/* *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** */
class MarcoCalculadora extends JFrame{
    public MarcoCalculadora() throws HeadlessException {
        setTitle("Calculadora");
        setBounds(500,300,450,300);

        LaminaCalculadora miLamina = new LaminaCalculadora();
        add(miLamina);
        //pack(); // Despues de agregar el Panel o Frame principal, indicamos que el contenedor
                // se tiene que adaptar al tamaño por defecto de lo que contiene en su interior. class Window
    }
}

/* *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** */
class LaminaCalculadora extends JPanel{

    private JPanel losBotones;  // Se declara objeto JPanel variable de ambito de clase
    private JButton pantalla;
    private boolean principio;// Para quitar el cero del principio, se incia en false

    public LaminaCalculadora() {
        principio = true;   // Para borrar el cero inicial
        int numerosarray = 10;
        setLayout(new BorderLayout());

        pantalla = new JButton("0");
        pantalla.setEnabled(false);     // deshabilita el boton
        add(pantalla, BorderLayout.NORTH);

        losBotones = new JPanel();  // Se incia/construye el objeto JPanel
        losBotones.setLayout(new GridLayout(4,4));

        // Varias formas de agregar los botones
        JButton[] botonN = new JButton[numerosarray];   // Arreglo de objetos
        ActionListener listenerInsertar = new InsertaNumero();  // Objeto tipo Evento ActionListener, creado con
                                                         // la clase que implementa la Interface ActionListener
        for (int i = 0; i < numerosarray; i++) {
            botonN[i] = new JButton(String.valueOf(i)); // Genera los objetos boton
            botonN[i].addActionListener(listenerInsertar);
            losBotones.add(botonN[i]);
        }

        JButton botonSuma = new JButton("+");
        //botonSuma.addActionListener(listenerInsertar);
        losBotones.add(botonSuma);
        JButton botonResta = new JButton("-");
        //botonResta.addActionListener(listenerInsertar);
        losBotones.add(botonResta);
        //ponerBotones("/");
        //ponerBotones("x");
        //ponerBotones("mod");
        //ponerBotones("=");

        add(losBotones, BorderLayout.CENTER);

    }

    private void ponerBotones(String rotulo, ActionListener oyente){
        JButton boton = new JButton(rotulo);
        boton.addActionListener(oyente);    // Los simbolos matematicos no llevan esta instancia para que no escriban en pantalla
        losBotones.add(boton);
    }

    private class InsertaNumero implements ActionListener{
        @Override
        public void actionPerformed(ActionEvent e) {
            // Capturar el texto asociado al evento
            String entrada = e.getActionCommand();

            if (principio){                pantalla.setText("");   /* Borra la pantalla solo la primera vez*/               principio = false;            }

            // Para que agrupe los numeros al hacer clic, recibe lo que haya anteriormente + el nuevo clic
            pantalla.setText(pantalla.getText() + entrada);
        }
    }
} // ends LaminaCalculadora -> JPanel


/* *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** */

/*
Otra forma de evitar el 0 al inicio y sin necesidad de una variable boolean:
if (pantalla.getText() == "0") {
        pantalla.setText(entrada);
} else {
        pantalla.setText(display.getText() + entrada);
}
*/
