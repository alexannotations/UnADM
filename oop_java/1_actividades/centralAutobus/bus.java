package centralAutobus;

public class bus {
	
	int autobus = 3;
	int[] asientos = new int[50];
	
	public bus() {
		for (int i : asientos) {
			asientos[i] = 0;
		}
	}

	public int[] getAsientos() {
		return asientos;
	}

	public void setAsientos(int[] asientos) {
		this.asientos = asientos;
	}
	
}
