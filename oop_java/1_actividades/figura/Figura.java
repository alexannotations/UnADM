/* * * * * * * * * 
 * 
 * 
 * * * * * * * *  */
package figura;

public abstract class Figura{

	static final float CONSTANTE_PI = 3.14159265f;
    private String nombre;
    private float perimetro;
    private float area;
    
    public Figura(String nombre){
        this.nombre = nombre;
    }

    
    public abstract void calcularArea();
    public abstract void calcularPerimetro();
    

    public String getNombre(){        return this.nombre;    }

	public float getPerimetro() {		return perimetro;	}
	public void setPerimetro(float perimetro) {		this.perimetro = perimetro;	}

	public float getArea() {		return area;	}
	public void setArea(float area) {		this.area = area;	}
        
	
}
