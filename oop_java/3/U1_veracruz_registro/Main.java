/**
 * Alejandro Ayala Castro
 *
 * */
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
public class Main {

    public static void main(String[] args) {
        FramePrincipal framePrincipal = new FramePrincipal();
        framePrincipal.showMainBar();
        framePrincipal.showPanelPrincipal();
        framePrincipal.showInfoBar();
        framePrincipal.setVisible(true);
    }

}
