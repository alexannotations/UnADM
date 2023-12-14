import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;


public class FileTextListener implements ActionListener
{
    private MenuPersonal menuPersonal;
    private String path=null;

    public String getPath(){
        return path;
    }

    public FileTextListener(MenuPersonal menuPersonal) {
        this.menuPersonal = menuPersonal;
    }


    @Override
    public void actionPerformed(ActionEvent e)
    {
        FileManager fileManager = new FileManager();
        path = fileManager.saveFormText(menuPersonal);

        System.out.println("Archivo guardado en: " + path);
    }

}
