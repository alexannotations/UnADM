package calificaciones;

public class Estadistica {
	
	private int totalLista;
	private int listaAgrupados;
	private int moda;

	// Constructor
	public Estadistica(int size) {
		this.setTotalLista(size);
		this.setListaAgrupados(0);
	}
	
	// Getters & Setters
	private int getTotalLista() {		return totalLista;	}
	private void setTotalLista(int totalLista) {		this.totalLista = totalLista;	}
	private int getListaAgrupados() {		return listaAgrupados;	}
	private void setListaAgrupados(int listaAgrupados) {		this.listaAgrupados = listaAgrupados;	}
	public int getModa() {		return moda;	}
	private void setModa(int moda) {		this.moda = moda;	}

	
	public void calcularModa(int[] valores) {
		// Mostrar los valores de la lista
/*		for (int i = 0; i < getTotalLista(); i++) {
			System.out.println("Val: " +valores[i]);
		}
*/
		// Genera la matriz para los valores agrupados
		int [][] tablaControl = new int[2][getTotalLista()];
		for (int i = 0; i < getTotalLista(); i++) {
			tablaControl[0][i] = -1;	// Valor
			tablaControl[1][i] = 0;		// Contador
		}
			
		// Agrupa los valores en la tabla
		int ubicacion=1;
		for (int i = 0; i < getTotalLista(); i++) {
			for (int j = 0; j < ubicacion; j++) {
				if (tablaControl[0][j]==valores[i]) {
					tablaControl[1][j]++;
					break;	// Acumula 1
				}
				if (tablaControl[0][j]==-1) {
					tablaControl[0][j]=valores[i];
					tablaControl[1][j]++;
					this.setListaAgrupados(getListaAgrupados()+1);
					break;	// Registra y acumula 1
				}
			}
			ubicacion++;	
		}

		// Mostrar tabla de frecuencias
		for (int i = 0; i < getListaAgrupados(); i++) {
			System.out.println("   cal" +i +":  " +tablaControl[0][i] +"\t->  " +tablaControl[1][i]);
		}

		// Seleccionar el valor más frecuente, Solo uno
			if (getListaAgrupados()>1) {
				int contadorMayor=0;
				for (int i = 0; i < getListaAgrupados(); i++) {
					if (tablaControl[1][i]>contadorMayor) {
						contadorMayor = tablaControl[1][i];
						moda=tablaControl[0][i];
					}
				}
			}else {
				this.setModa(tablaControl[0][0]);
			}
		
		//System.out.println(" La moda es: " + this.getModa());
	}	// End calcularModa()


}
