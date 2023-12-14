public class Canino {
    private int id;
    private String nombre;
    private String raza;
    private int edad;
    private String personalAsignado;
    private String telefono;
    private String rutaFoto;    // ruta del archivo

    public Canino(int id, String nombre, String raza, int edad, String personalAsignado, String telefono, String rutaFoto) {
        this.id = id;
        this.nombre = nombre;
        this.raza = raza;
        this.edad = edad;
        this.personalAsignado = personalAsignado;
        this.telefono = telefono;
        this.rutaFoto = rutaFoto;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getRaza() {
        return raza;
    }

    public void setRaza(String raza) {
        this.raza = raza;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public String getPersonalAsignado() {
        return personalAsignado;
    }

    public void setPersonalAsignado(String personalAsignado) {
        this.personalAsignado = personalAsignado;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getFoto() {
        return rutaFoto;
    }

    public void setFoto(String rutaFoto) {
        this.rutaFoto = rutaFoto;
    }


}
