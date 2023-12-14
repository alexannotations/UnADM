public class ActividadExtracurricular {
    private String nombre;
    private String matricula;
    private String semestre;
    private String carrera;
    private String deporte;
    private String cursoTaller;


    public String getNombre() {
        return nombre;
    }

    public String getMatricula() {
        return matricula;
    }

    public String getSemestre() {
        return semestre;
    }

    public String getCarrera() {
        return carrera;
    }

    public String getDeporte() {
        return deporte;
    }

    public String getCursoTaller() {
        return cursoTaller;
    }


    public ActividadExtracurricular(
            String nombre,
            String matricula,
            String semestre,
            String carrera,
            String deporte,
            String cursoTaller)
    {
        this.nombre = nombre;
        this.matricula = matricula;
        this.semestre = semestre;
        this.carrera = carrera;
        this.deporte = deporte;
        this.cursoTaller = cursoTaller;
    }


    @Override
    public String toString(){
        return
                getNombre() + "::" +
                getMatricula() + "::" +
                getSemestre() + "::" +
                getCarrera() + "::" +
                getDeporte() + "::" +
                getCursoTaller() + "::"
                ;
    }


}
