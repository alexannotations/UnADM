import javax.swing.*;
import java.awt.*;


public class InfoBar extends JPanel {

    public InfoBar() {

        setBackground(Color.YELLOW);

        String text = "Introduzca la información solicitada";

        JLabel info = new JLabel();
        info.setText(text);
        add(info);
    }

}
