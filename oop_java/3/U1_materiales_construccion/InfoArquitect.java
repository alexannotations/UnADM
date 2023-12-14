import javax.swing.JFileChooser;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class InfoArquitect {

    String encargado, obra, zona, metros, departamento, fechaEntrega;
    Boolean append = false;

    public InfoArquitect() {
    }

    public void recoverAndClean(FormAltas fa){
        recoverInfoForm(fa);
        clearForm(fa);

        // Concatena y manda a guardar al archivo
        String text = encargado + "," + obra + "," + zona + "," +
                metros + "," + departamento + "," + fechaEntrega + "\n";
        String filePath = openSaveDialog();
        saveFile(filePath,text);
    }

    /**
     * Crea una ventana de dialogo para indicar donde guardar el archivo
     *
     * */
    private String openSaveDialog(){
        // muestra un cuadro de diálogo para seleccionar la ubicación y el nombre del archivo
        JFileChooser fileChooser = new JFileChooser();
        int result = fileChooser.showSaveDialog(null);  // muestra el cuadro de diálogo “Guardar como”

        if (result == JFileChooser.APPROVE_OPTION) {
            // Si el usuario selecciona una ubicación y hace clic en “Guardar”, obtendra el archivo seleccionado
            File selectedFile = fileChooser.getSelectedFile();
            // Se obtiene la ruta completa
            String filePath = selectedFile.getAbsolutePath();   // Falta agregar la extensión
            return filePath;
        }else {
            return null;
        }
    }

    /**
     * Guarda la información en el archivo con la ruta especificada
     * */
    private void saveFile(String filePathName, String info){
        try {
            FileWriter fileWriter;  // Nuevo archivo
            if (this.append){
                fileWriter = new FileWriter(filePathName,true);   // agregar al mismo archivo
            }else {
                fileWriter = new FileWriter(filePathName);   // sobreescribir archivo
            }

            // Usa un flujo de caracteres para guardar el archivo
            for (int i = 0; i < info.length(); i++) {
                fileWriter.write(info.charAt(i));
            }

            fileWriter.close();
        }
        catch (IOException e) {
            e.printStackTrace();
        }
    }


    /**
     * Recupera la informacion capturada en el formulario de menu edificio
     * */
    private void recoverInfoForm(FormAltas fa){
        this.encargado = fa.encargado.getText().trim();
        this.obra = fa.obra.getText().trim();
        this.zona = fa.zona.getText().trim();
        this.metros = fa.metros.getText().trim();
        this.departamento = fa.departamento.getText().trim();
        this.fechaEntrega = fa.fechaEntrega.getText().trim();
        this.append = fa.append.isSelected();
    }

    /**
     * Limpia los campos del formulario
     * */
    private void clearForm(FormAltas fa){
        fa.encargado.setText("");
        fa.obra.setText("");
        fa.zona.setText("");
        fa.metros.setText("");
        fa.departamento.setText("");
        fa.fechaEntrega.setText("");
        // no se limpia el checkbox
    }

}
