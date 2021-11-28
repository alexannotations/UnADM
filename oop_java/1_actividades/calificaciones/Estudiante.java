package calificaciones;

public class Estudiante {
	
	private String nombre;
	private int calificacion;

	
	public Estudiante() {
	}
	
	public Estudiante(String nombre, int calificacion) {
		this.setNombre(nombre);
		this.setCalificacion(calificacion);
	}
	
	
	public String getNombre() {		return nombre;	}
	public void setNombre(String nombre) {		this.nombre = nombre;	}
	
	
	public int getCalificacion() {		return calificacion;	}
	public void setCalificacion(int calificacion) {		this.calificacion = calificacion;	}
	
	
}
