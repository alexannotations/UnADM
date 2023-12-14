import javax.swing.*;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Hilo extends Thread{

    private Ventana ventana;
    private JProgressBar barra1;
    private JProgressBar barra2;
    private int valor1;
    private int valor2;

    @Override
    public void run(){
        while (!(valor1==44 || valor2 ==60)){
            valor1+=(int)(Math.random()*3);
            System.out.println("Valor1 "+valor1);
            valor2+=(int)(Math.random()*3);
            System.out.println("Valor1 "+valor2);
            barra1.setValue(valor1);
            try {
                sleep(100);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }

    public void setBarra1(JProgressBar barra){
        this.barra1 = barra;
    }

    // se sobreescribe el metodo run()

}
