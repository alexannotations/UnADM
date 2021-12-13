package transporte;

public class Acuatico extends Vehiculo{

	String tipoNavegacion;
	
	public Acuatico() {
		super.setTipoVehiculo("Marino");	// con this genera
	}
	
	// metodo heredado
	public void mostrarInformacion() {
		super.mostrarInformacion();	// sin super provoca una Exception StackOverflowError
		System.out.println(" \tTipo de Navegacion: " + tipoNavegacion);
	}

}
