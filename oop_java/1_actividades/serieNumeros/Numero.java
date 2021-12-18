package serieNumeros;

public class Numero {
	String numerosError = "\nIntroduzca nuevamente el rango de valores.";
	
	private int rangoSuperior;
	private int rangoInferior;
	private int[] serieNumerica;

	
	public boolean setRango(int rangoSuperior, int rangoInferior) {
		if (rangoSuperior<rangoInferior) {
			System.out.println("El rango superior debe ser mayor al inferior." +numerosError);
			return false;
		}
		if (rangoSuperior>50) {
			System.out.println("El limite superior debe ser menor a 50." +numerosError);
			return false;
		}else {
			this.setRangoSuperior(rangoSuperior);
		}
		if (rangoSuperior-rangoInferior<10) {
			System.out.println("El rango debe tener una diferencia de almenos 10 unidades." +numerosError);
			return false;
		}else {
			this.setRangoInferior(rangoInferior);
		}
		System.out.println("OK");
		return true;
	}
	
	
	private void setRangoSuperior(int rangoSuperior) {
		this.rangoSuperior = rangoSuperior;
	}
	private void setRangoInferior(int rangoInferior) {
		this.rangoInferior = rangoInferior;
	}
	public int getRangoSuperior() {
		return rangoSuperior;
	}
	public int getRangoInferior() {
		return rangoInferior;
	}
	public int[] getSerieNumerica() {
		return serieNumerica;
	}

	public void setSerieNumerica(int[] serieNumerica) {
		
		this.serieNumerica = serieNumerica;
	}

	void generaSerieNumerica() {

		int inicio = this.getRangoInferior();
		int fin = this.getRangoSuperior();
		int rango = (fin-inicio)+1;
		int serieNumerica[] = new int[rango];
		for (int i = 0; i < rango; i++) {
			serieNumerica[i]=inicio++;
		}
		this.setSerieNumerica(serieNumerica);
	}

}
