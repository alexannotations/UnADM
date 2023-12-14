import java.io.*;
import javax.swing.JFileChooser;


public class FileManager {

    private String rutaImagen;
    public String getArchivoImagen() {
        return rutaImagen;
    }

    public void openDirectoryMenu(FormularioCanino formulario) throws IOException {
        JFileChooser abrirArchivo = new JFileChooser();
        // Unicamente puede abrir archivos
        abrirArchivo.setFileSelectionMode( JFileChooser.FILES_ONLY );

        int seleccion = abrirArchivo.showOpenDialog( formulario );

        if (seleccion == JFileChooser.APPROVE_OPTION) {
            // Leer el archivo de imagen
            File selectedFile = abrirArchivo.getSelectedFile();
            rutaImagen = selectedFile.getAbsolutePath();
            System.out.println(rutaImagen);
        }
    }   // END openDirectoryMenu

}
