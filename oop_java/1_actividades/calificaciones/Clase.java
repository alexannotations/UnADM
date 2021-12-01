package calificaciones;

public class Clase {
	
	private int aprobados;
	private int reprobados;
	
	public Clase() {
		this.setAprobados(0);
		this.setReprobados(0);
	}
	
	public void obtenerModa(){
		// TODO
	}
	
	
	public String calculatePerformance(int calificacion){
		if (calificacion >80 && calificacion <=100) {
			return "Muy bien";
		} else if(calificacion >60 && calificacion <=80) {
			return "Bien";
		}else if (calificacion >40 && calificacion <=60) {
			return "Regular";
		}else if (calificacion >20 && calificacion <=40) {
			return "Necesitas mejorar";
		} else if(calificacion >0 && calificacion <=20) {
			return "Insuficiente";
		}else {
			return "No presento";
		}
	}
	
	
	public void getPercentage() {
		int totalAlumnos = this.getAprobados() + this.getReprobados();
		double porcentajeAprobados = (double)this.getAprobados()/totalAlumnos*100;
		double porcentajeReprobados = (double)this.getReprobados()/totalAlumnos*100;
		System.out.println("\t% Aprobados: " + porcentajeAprobados +"\n\t% Reprobados: " + porcentajeReprobados);
	}
	
	
	public int getAprobados() {		return aprobados;	}
	public void setAprobados(int aprobados) {		this.aprobados = aprobados;	}
	public void oneAprobados() {		setAprobados(this.getAprobados()+1);	}
	
	
	public int getReprobados() {		return reprobados;	}
	public void setReprobados(int reprobados) {		this.reprobados = reprobados;	}
	public void oneReprobados() {		this.reprobados++;	}
	

}
