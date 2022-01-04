package centralAutobus;

public class bus {
	
	private int unidades = 3;
	private int asientos = 50;
	private int[][] flotaBuses = new int[unidades][asientos];
	
	public bus() {
		// El autobus no tiene ninguna plaza reservada
		for (int i = 0; i < unidades; i++) {
			for (int j = 0; j < asientos; j++) {
				flotaBuses[i][j] = 0;
			}
		}
	} // end constructor
	
	
	void reservarAsiento(int bus, int seat) {
		if (this.validarBus(bus) && this.validarSeat(seat) && this.validarOcupacion(bus, seat)) {
			flotaBuses[bus][seat] = 1;
			System.out.println("| Bus: " + (bus+1) +" | Asiento: " + (seat+1) +" -> Lugar Reservado |");
		}else {
			System.out.println("No fue posible hacer la reservación.");
		}
	}
	
	
	void cancelarAsiento(int bus, int seat) {
		if (this.validarBus(bus) && this.validarSeat(seat) && !(this.validarOcupacion(bus, seat))) {
			flotaBuses[bus][seat] = 0;
			System.out.println("| Bus: " + (bus+1) +" | Asiento: " + (seat+1) +" -> Reserva Cancelada |");
		}else {
			System.out.println("No fue posible hacer la Cancelación.");
		}
	}
	
	
	boolean validarOcupacion(int bus, int seat) {
		if (flotaBuses[bus][seat] == 0) {
			//System.out.println("Lugar disponible. NO se puede cancelar.");
			return true;
		}else {
			//System.out.println("El asiento se encuentra ocupado. No es posible reservarlo.");
			return false;
		}
	}
	
	
	public void showFlotaBuses() {
		for (int i = 0; i < unidades; i++) {
			System.out.println("\nBus: " + (i+1));
			for (int j = 0; j < asientos; j++) {
				System.out.print("| " + (j+1) +" > " +flotaBuses[i][j] +" ");
			}
			System.out.println("|");
		}
	}
	
	
	public void showBus(int bus) {
		// TODO: distribucion de asientos de 4 x 13
		System.out.println("\nBus: " + bus);
		bus--;
		if (this.validarBus(bus)) {
			for (int j = 0; j < asientos; j++) {
				System.out.print("| " + (j+1) +" > " +flotaBuses[bus][j] +" ");
			}
			System.out.println("|");
		}
	}
	
	
	public void showBusSeat(int bus, int seat) {
		String estado = "Sin Información";
		if (this.validarBus(bus) && this.validarSeat(seat)) {
			if (flotaBuses[bus][seat] == 0) {
				estado = "Disponible";
			} else {
				estado = "Reservado";
			}
			System.out.println("| Bus: " + (bus+1) +" | Asiento: " + (seat+1) +" -> " +estado +" |");
		}
	}
	
	
	boolean validarBus(int bus) {
		if (bus >=0 && bus < unidades) {
			return true;
		}
		System.out.println("El autobus NO Existe");
		return false;
	}
	
	
	boolean validarSeat(int seat) {
		if (seat >=0 && seat < asientos) {
			return true;
		}
		System.out.println("El asiento NO Existe");
		return false;
	}
	
	
}
