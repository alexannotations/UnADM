/* ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** **
 * Calculadora Grafica
 * PildorasInformaticas Java. Layouts III. Vídeo 83
 *
 * ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** ** */

import javax.swing.*;
import java.awt.*;


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
    }
}

/* *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** */
class LaminaCalculadora extends JPanel{

    private JPanel losBotones;  // Se declara objeto JPanel variable de ambito de clase

    public LaminaCalculadora() {
        int numerosarray = 10;
        setLayout(new BorderLayout());

        JButton pantalla = new JButton("0");
        pantalla.setEnabled(false);     // deshabilita el boton
        add(pantalla, BorderLayout.NORTH);

        losBotones = new JPanel();  // Se incia/construye el objeto JPanel
        losBotones.setLayout(new GridLayout(4,4));

        // Varias formas de agregar los botones
        JButton[] botonN = new JButton[numerosarray];   // Arreglo de objetos
        for (int i = 0; i < numerosarray; i++) {
            botonN[i] = new JButton(String.valueOf(i)); // Genera los objetos boton
            losBotones.add(botonN[i]);
        }

        JButton botonSuma = new JButton("+");
        losBotones.add(botonSuma);
        JButton botonResta = new JButton("-");
        losBotones.add(botonResta);
        JButton botonMultiplicacion = new JButton("x");
        losBotones.add(botonMultiplicacion);
        JButton botonDivision = new JButton("/");
        losBotones.add(botonDivision);
        ponerBotones("mod");
        ponerBotones("=");

        add(losBotones, BorderLayout.CENTER);

    }

    private void ponerBotones(String rotulo){
        JButton boton = new JButton(rotulo);
        losBotones.add(boton);
    }
}


/* *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** *** */
