package transporte;

class Placas extends Auto {
	protected String no_placas;

	// El constructor hereda los atributos de la clase padre
	public Placas(String marca, String modelo, String no_placas) {
		super(marca, modelo);
		this.no_placas = no_placas;
	}

}
