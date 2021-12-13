package transporte;

class Auto extends Terrestre {
	protected String marca;
	protected String modelo;
	
	public Auto(String marca, String modelo) {
		this.marca = marca;
		this.modelo = modelo;
		tipoTerreno = "Asfalto";		// sobreescribe el valor asignado por terrestre el modificador de acceso es default, clase terrestre
		super.setTipoVehiculo("Auto Ciudad");	// Hay metodos get & set y modificador de acceso private clase Vehiculo
		//super.tipoVehiculo = "Auto Ciudad";		//genera error si se asigna directamente
	}
	
	public void mostrarInformacion() {
		super.mostrarInformacion();	// sin super provoca una Exception StackOverflowError
		System.out.println(" \tMarca ..: " + marca + " \tModelo ..: " + modelo);
	}
}
