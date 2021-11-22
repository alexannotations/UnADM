/*
 * Se recomienda separar el codigo fuente de las pruebas unitarias
 * Puede crearse un nuevo paquete de pruebas
 */
package Unit_test;

import static org.junit.Assert.*;
import org.junit.Test;
import figuras.Rectangulo;

public class RectanguloTest {

	// Pruebo si puedo crear rectangulos
	@Test
	public void test() {
		//fail("Not yet implemented");
		Rectangulo rectangulo = new Rectangulo("Rectangulo1", 2, 2);
		assertNotNull(rectangulo);
	}
	
	// Prueba el calculo del area
	@Test
	public void testAreaRectangulo() {
		Rectangulo rectangulo = new Rectangulo("Rectangulo1", 2, 2);
		
		double valorEsperado = 4.0;
		double valorObtenido = rectangulo.calcularArea();
		
		// con error esperado
		assertEquals(valorEsperado, valorObtenido, 0.0);
	}

}
