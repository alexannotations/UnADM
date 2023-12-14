import javax.swing.*;
import java.awt.*;

public class MenuMain extends JPanel {

    FormAltas formAltas;
    FormBuscar formBuscar;
    FormEliminar formEliminar;
    FormEliminarArchivo fEliminarArchivo;
    FormRenombrar formRenombrar;
    MenuEdificio menuEdificio;
    MenuPrincipal menuPrincipal;
    TablaArchivo tabla;


    public MenuMain(LayoutManager layout) {
        super(layout);
        setBackground(Color.WHITE);

        formAltas = new FormAltas();
        formBuscar = new FormBuscar();
        formEliminar = new FormEliminar();
        fEliminarArchivo = new FormEliminarArchivo();
        formRenombrar = new FormRenombrar();
        menuEdificio = new MenuEdificio();
        menuPrincipal = new MenuPrincipal(menuEdificio);
        tabla = new TablaArchivo();

        add(menuPrincipal,BorderLayout.NORTH);

    }
}
