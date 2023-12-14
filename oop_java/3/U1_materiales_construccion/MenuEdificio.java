import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class MenuEdificio extends JPanel {

    FormAltas altas;
    Botonera botonera;
    InfoArquitect infoA;


    public MenuEdificio() {
        // ilustra un submenu Altas

        this.setLayout(new BorderLayout());
        altas = new FormAltas();
        botonera = new Botonera();
        infoA = new InfoArquitect();


        add(new JLabel("Menú Edificio", SwingConstants.CENTER),BorderLayout.NORTH);
        add(altas,BorderLayout.CENTER);
        add(botonera,BorderLayout.SOUTH);

        botonera.guardar.addActionListener(new BtnGuardarListener());
        botonera.buscar.addActionListener(new BtnBuscarListener(botonera,altas));
        botonera.eliminar.addActionListener(new BtnEliminarListener(botonera,altas));
        botonera.renombrar.addActionListener(new BtnRenombrarListener(botonera,altas));
        botonera.salir.addActionListener(new BtnRegresarMenu(this));

    }

    // ******* ******* ******* BOTONERA ******* ******* ******* //
    class Botonera extends JPanel{
        JButton guardar;
        JButton buscar;
        JButton eliminar;
        JButton renombrar;
        JButton salir;

        public Botonera() {
            setLayout(new FlowLayout());
            guardar = new JButton("Guardar");
            buscar = new JButton("Buscar");
            eliminar = new JButton("Eliminar");
            renombrar = new JButton("Renombrar");
            salir = new JButton("Salir");

            add(guardar);
            add(buscar);
            add(eliminar);
            add(renombrar);
            add(salir);
        }
    } // END clase interna Botonera

    // ******* ******* ******* LISTENER_GUARDAR ******* ******* ******* //
    class BtnGuardarListener implements ActionListener{

        @Override
        public void actionPerformed(ActionEvent e) {
            infoA.recoverAndClean(altas);
            System.out.println("Recuperar datos del formulario");
        }
    }   // END inner class


    // ******* ******* ******* LISTENER_BUSCAR ******* ******* ******* //
    class BtnBuscarListener implements ActionListener{

        Botonera buttons;
        FormAltas altas;
        public BtnBuscarListener(Botonera buttons, FormAltas altas) {
            this.buttons = buttons;
            this.altas = altas;
        }

        @Override
        public void actionPerformed(ActionEvent e) {
            remove(buttons);
            remove(altas);
            FormBuscar formBuscar = new FormBuscar();
            add(formBuscar);
            System.out.println("Ingresando al menu renombrar");
            revalidate();
        }
    }



    // ******* ******* ******* LISTENER_ELIMINAR ******* ******* ******* //
    class BtnEliminarListener implements ActionListener{

        Botonera buttons;
        FormAltas altas;
        public BtnEliminarListener(Botonera buttons, FormAltas altas) {
            this.buttons = buttons;
            this.altas = altas;
        }

        @Override
        public void actionPerformed(ActionEvent e) {
            remove(buttons);
            remove(altas);
            FormEliminarArchivo formEliminar = new FormEliminarArchivo();
            add(formEliminar);
            System.out.println("Ingresando al menu renombrar");
            revalidate();
        }
    }




    // ******* ******* ******* LISTENER_RENOMBRAR ******* ******* ******* //
class BtnRenombrarListener implements ActionListener{

        Botonera buttons;
        FormAltas altas;
        public BtnRenombrarListener(Botonera buttons, FormAltas altas) {
            this.buttons = buttons;
            this.altas = altas;
        }

        @Override
        public void actionPerformed(ActionEvent e) {
            remove(buttons);
            remove(altas);
            FormRenombrar formRenombrar = new FormRenombrar();
            add(formRenombrar);
            System.out.println("Ingresando al menu renombrar");
            revalidate();
        }
    }

    // ******* ******* ******* LISTENER_REGRESAR ******* ******* ******* //
    class BtnRegresarMenu implements ActionListener{
        MenuEdificio mEdificio;

        public BtnRegresarMenu(MenuEdificio mEdificio) {
            this.mEdificio = mEdificio;
        }

        @Override
        public void actionPerformed(ActionEvent e) {
            System.out.println("Regresar a menu principal");
            MenuPrincipal mp = new MenuPrincipal(this.mEdificio);
            mEdificio.removeAll();
            mp.initComponents();    // NO esta mostrando los componentes
        }
    } // END inner class BtnRegresarMenu
}
