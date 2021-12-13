package transporte;

public class Terrestre extends Vehiculo {
	String tipoTerreno;

	public Terrestre() {
		super.setTipoVehiculo("Terrestre");	// atributo heredado de la clase vehiculo
	}
	
	// metodo heredado
	public void mostrarInformacion() {
		super.mostrarInformacion();	// sin super provoca una Exception StackOverflowError
		System.out.println(" \tTipo de terreno ..: " + tipoTerreno);
	}

}
