import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;

class CambiarNombreListener implements ActionListener {

    FormRenombrar formRename;
    public CambiarNombreListener(FormRenombrar formRename) {
        this.formRename = formRename;
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        // obtiene el directorio donde se almacena + nombreActualArchivo
        String nvo = formRename.file.getParent() + "\\" + formRename.nombreArchivoNuevo.getText();  // Falta agregar la extensión
        // crea un objeto tipo file con el nuevo nombre
        File f2 = new File(nvo);
        // se renombra el archivo
        if (formRename.file.renameTo(f2)==true)
            JOptionPane.showMessageDialog(null,"El renombrado ha sido correcto");
        else
            JOptionPane.showMessageDialog(null,"El renombrado NO se ha podido realizar");
    }
}   // END clase interna CambiarNombreListener