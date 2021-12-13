/***********
 * 
 * ********* */
package transporte;

abstract class Vehiculo {
	
	String nombre;
	private String tipoVehiculo;
	String fuenteEnergia = "Motor";
	Double velocidadMaxima;
	Double velocidadActual;
	Double relacionAceleracion;
	int cantidadTripulacion;
	
	public void mostrarInformacion() {
		System.out.println(" *** ** Información del vehiculo ** *** ");
		System.out.println(" \tNombre ...........: " + nombre);
		System.out.println(" \tTipo .............: " + tipoVehiculo);
		System.out.println(" \tFuente de energía : " + fuenteEnergia);
		System.out.println(" \tTripulación ......: " + cantidadTripulacion);
		System.out.println(" \tVelocidad Máxima .: " + velocidadMaxima);
		System.out.println(" \tVelocidad Actual .: " + velocidadActual);
	}
	
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	
	
	public String getTipoVehiculo() {
		return tipoVehiculo;
	}

	public void setTipoVehiculo(String tipoVehiculo) {
		this.tipoVehiculo = tipoVehiculo;
	}
	
}
