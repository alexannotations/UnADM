package figura;

public class Cuadrado extends Figura{
	
	private float lado;

    public Cuadrado(String nombre){
        super(nombre);
        this.setLado(lado);
    }
    
    
	public float getLado() {		return lado;	}
	public void setLado(float lado) {		this.lado = lado;	}


	@Override
	public void calcularArea() {		setArea(getLado()*getLado());	}

	
	@Override
	public void calcularPerimetro() {		setPerimetro(getLado()*4);	}


}
