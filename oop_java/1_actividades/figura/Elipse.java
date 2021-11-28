package figura;

public class Elipse extends Figura{

    private float sjMayor;
	private float sjMenor;

	public Elipse(String nombre, float sjMayor, float sjMenor){
        super(nombre);
        this.setSJMayor(sjMayor);
		this.setSJMenor(sjMenor);
    }
    
    
	public float getSJMayor() {		return sjMayor;	}
	public void setSJMayor(float sjMayor) {		this.sjMayor = sjMayor;	}

	public float getSJMenor() {		return sjMenor;	}
	public void setSJMenor(float sjMenor) {		this.sjMenor = sjMenor;	}

	@Override
	public void calcularArea() {
        setArea(CONSTANTE_PI*sjMayor*sjMenor);	
    }

	
	@Override
	public void calcularPerimetro() {
        // Formula de Ramanujan primer aproximación
        // https://www.universoformulas.com/matematicas/geometria/perimetro-elipse/
        setPerimetro(CONSTANTE_PI*(3*(sjMayor+sjMenor)-(float)Math.sqrt((3*sjMayor+sjMenor)*(sjMayor+3*sjMenor))));
    }


}
