package transporte;

public class Aereo extends Vehiculo {
	
	int pesoMaximo;
	int cantidadCombustible;
	double alturaMaxima;
	String tipoCarga;

	
	public Aereo() {
		super.setTipoVehiculo("Aereo");
	}
	
	
	public boolean encenderMotor() {
		if (cantidadCombustible>1) {
			return true;
		}else {
			return false;
		}
	}
	
	
	public void desplegarTrenAterrizaje(){
		System.out.println("Desplegando el tren de aterrizaje.");
	}
	

}
