import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class OpenFormAltasListener implements ActionListener {

    PanelPrincipal mp;

    public OpenFormAltasListener(PanelPrincipal mp) {
        this.mp = mp;
    }

    @Override
    public void actionPerformed(ActionEvent e)
    {
        System.out.println("Altas");
        mp.showPersonalAltas();

    }
}
