package figura;
public class Rectangulo extends Figura{
    
	private float base;
	private float altura;

	public Rectangulo(String nombre){
        super(nombre);
        this.setBase(base);
		this.setAltura(altura);
    }
    
    
	public float getBase() {		return base;	}
	public void setBase(float base) {		this.base = base;	}

	public float getAltura() {		return altura;	}
	public void setAltura(float altura) {		this.altura = altura;	}

	@Override
	public void calcularArea() {		setArea(getBase()*getAltura());	}

	
	@Override
	public void calcularPerimetro() {		setPerimetro(2*getBase()+2*getAltura());	}




}
