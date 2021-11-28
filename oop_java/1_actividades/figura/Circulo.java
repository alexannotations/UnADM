package figura;

public class Circulo extends Figura{

	private float radio;

    public Circulo(String nombre){
        super(nombre);
        this.setRadio(radio);
    }
    
    
	public float getRadio() {		return radio;	}
	public void setRadio(float radio) {		this.radio = radio;	}


	@Override
	public void calcularArea() {		setArea(getRadio()*getRadio()*CONSTANTE_PI);	}

	
	@Override
	public void calcularPerimetro() {		setPerimetro(2*CONSTANTE_PI*getRadio());	}



}
