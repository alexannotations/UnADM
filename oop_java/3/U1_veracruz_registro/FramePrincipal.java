import javax.swing.*;
import java.awt.*;

public class FramePrincipal extends JFrame
{
    public FramePrincipal()
    {
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setTitle("Capacitación Protección Civil Edo. Veracruz");
        this.setLocation(300,300);
        this.setSize(600,220);
    }


    public void showMainBar()
    {
        MenuSuperior mPrincipal =  new MenuSuperior();
        this.getContentPane().add(mPrincipal, BorderLayout.NORTH);
    }

    public void showPanelPrincipal()
    {
        PanelPrincipal pPrincipal = new PanelPrincipal();
        getContentPane().add(pPrincipal, BorderLayout.CENTER);
        pPrincipal.setVisible(true);
    }

    public void showPersonalMenu()
    {
        MenuPersonal mPersonal = new MenuPersonal();
        getContentPane().add(mPersonal, BorderLayout.CENTER);
        mPersonal.setVisible(false);
    }

    public void showInfoBar()
    {
        getContentPane().add(new InfoBar(),BorderLayout.SOUTH);
    }

}
