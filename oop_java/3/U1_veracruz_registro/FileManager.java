import java.io.*;
import javax.swing.JFileChooser;


public class FileManager {

    public void openDirectoryMenu(MenuPersonal menuPersonal)
    {
        JFileChooser abrirArchivo = new JFileChooser();
        // Unicamente puede abrir archivos
        abrirArchivo.setFileSelectionMode( JFileChooser.FILES_ONLY );

        int seleccion = abrirArchivo.showOpenDialog( menuPersonal );

        if (seleccion == JFileChooser.APPROVE_OPTION) {
            File selectedFile = abrirArchivo.getSelectedFile();
            String textRow = readTextFile(selectedFile);

            String[] item = textRow.split(",");

            menuPersonal.campoName.setText(item[0]);
            menuPersonal.campoCapacitacion.setText(item[1]);
            menuPersonal.campoPiso.setText(item[2]);
            menuPersonal.campoEdificio.setText(item[3]);
        }
    }

    public String readTextFile(File selectedFile)
    {
        StringBuilder infoRead = new StringBuilder();
        try (BufferedReader reader = new BufferedReader(new FileReader(selectedFile))) {
            String line;
            while ((line = reader.readLine()) != null) {
                infoRead.append(line + "\n");
            }

        } catch (IOException e) {
            e.printStackTrace();
            System.out.println("No se ha encontrado el archivo");
        }finally {
            System.out.println("Archivo Leido: " + infoRead);
            return infoRead.toString();
        }
    }

    public String saveFormText(MenuPersonal menuPersonal)
    {
        // Obtiene el texto y quita espacios en blanco del cuadro de texto
        String name = menuPersonal.campoName.getText().trim();
        String capacitacion = menuPersonal.campoCapacitacion.getText().trim();
        String piso = menuPersonal.campoPiso.getText().trim();
        String edificio = menuPersonal.campoEdificio.getText().trim();

        // Limpia los campos
        menuPersonal.campoName.setText("");
        menuPersonal.campoCapacitacion.setText("");
        menuPersonal.campoPiso.setText("");
        menuPersonal.campoEdificio.setText("");

        // Concatena y manda a guardar al archivo
        String text = name + "," + capacitacion + "," + piso + "," + edificio+"\n";
        return writeTextFile(text);
    }


    private String writeTextFile(String text)
    {
        try {
            // muestra un cuadro de diálogo para seleccionar la ubicación y el nombre del archivo
            JFileChooser fileChooser = new JFileChooser();
            int result = fileChooser.showSaveDialog(null);  // muestra el cuadro de diálogo “Guardar como”

            if (result == JFileChooser.APPROVE_OPTION) {
                // Si el usuario selecciona una ubicación y hace clic en “Guardar”, obtendra el archivo seleccionado
                File selectedFile = fileChooser.getSelectedFile();
                // Se obtiene la ruta completa
                String filePath = selectedFile.getAbsolutePath()+".txt";

                // Nuevo archivo
                FileWriter fileWriter = new FileWriter(filePath);

                for (int i = 0; i < text.length(); i++) {
                    fileWriter.write(text.charAt(i));
                }

                fileWriter.close();
                return filePath;
            }
        }
        catch (IOException e) {
            e.printStackTrace();
        }
        return null;
    }
}
