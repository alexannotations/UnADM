package figura;

import java.util.Scanner;

public class UIMenu {
	
	private static String msgError = "Please select a correct answer. You typed an incorrect option, please type the number according";
	private float medida =0;
	private static Scanner inputKeyBoard = new Scanner(System.in);
	
	public static void showMenu() {
		
		UIMenu menu = new UIMenu();
        System.out.println("Welcome to Figures");
        System.out.println("Selecciona la opci�n deseada");
        
        int selectedFigure = 0;
        do {
            System.out.println("1. Circulo");
            System.out.println("2. Cuadrado");
            System.out.println("3. Elipse");
            System.out.println("4. Rectangulo");
            System.out.println("\n0. Salir");
            
            try {
            	selectedFigure =Integer.valueOf(inputKeyBoard.nextLine());
			} catch (Exception e) {
				System.out.println("Error: " +e);
			}
			
            switch (selectedFigure) {
			case 1:
				System.out.println("Seleccionaste Circulo");
				menu.doCircle();
				break;
			
			case 2:
				System.out.println("Seleccionaste Cuadrado");
				menu.doSquare();
				break;
				
			case 3:
				System.out.println("Seleccionaste Elipse");
				menu.doElipse();
				break;
				
			case 4:
				System.out.println("Seleccionaste Rectangulo");
				menu.doRectangle();
				break;
				
            case 0:
                System.out.println("Thank you for you visit");
                break;

			default:
				System.out.println(msgError);
			}
            
		} while (selectedFigure != 0);
        inputKeyBoard.close();

	}
	
	void doSquare() {
		System.out.print("Indique cuanto mide el lado: ");
		
		try {
			medida =Float.valueOf(inputKeyBoard.nextLine());
		} catch (Exception e) { /* Throwable e */
			System.out.println("Error: " +e);
		}
		Cuadrado ObjCuadrado = new Cuadrado("Cuadrado", medida);
		ObjCuadrado.calcularPerimetro();
		ObjCuadrado.calcularArea();
		System.out.println("El lado del " + ObjCuadrado.getNombre() +" mide: " +ObjCuadrado.getLado());
		System.out.println("El perimetro  del " + ObjCuadrado.getNombre() +" mide: " +ObjCuadrado.getPerimetro());
		System.out.println("El area  del " + ObjCuadrado.getNombre() +" mide: " +ObjCuadrado.getArea());
	}
	
	
	void doRectangle() {
		float base, altura;
		try {
			System.out.print("Indique cuanto mide la base: ");
			base = Float.valueOf(inputKeyBoard.nextLine());
			System.out.print("Indique cuanto mide la altura: ");
			altura = Float.valueOf(inputKeyBoard.nextLine());
			Rectangulo ObjRectangulo = new Rectangulo("Rectangulo", base, altura);
			ObjRectangulo.calcularPerimetro();
			ObjRectangulo.calcularArea();
			System.out.println("El " + ObjRectangulo.getNombre() +" tiene de base: " +ObjRectangulo.getBase() +" y de altura: " +ObjRectangulo.getAltura());
			System.out.println("El perimetro  del " + ObjRectangulo.getNombre() +" mide: " +ObjRectangulo.getPerimetro());
			System.out.println("El area  del " + ObjRectangulo.getNombre() +" mide: " +ObjRectangulo.getArea());
		} catch (Exception e) {
			System.out.println("Error: " +e);
		}
	
	}
	
	
	void doCircle() {

		System.out.print("Indique cuanto mide el radio: ");
		
		try {
			medida =Float.valueOf(inputKeyBoard.nextLine());
		} catch (Exception e) {
			System.out.println("Error: " +e);
		}
		
		Circulo ObjCirculo = new Circulo("Circulo", medida);
		ObjCirculo.calcularPerimetro();
		ObjCirculo.calcularArea();
		System.out.println("El radio del " + ObjCirculo.getNombre() +" mide: " +ObjCirculo.getRadio());
		System.out.println("El perimetro  del " + ObjCirculo.getNombre() +" mide: " +ObjCirculo.getPerimetro());
		System.out.println("El area  del " + ObjCirculo.getNombre() +" mide: " +ObjCirculo.getArea());
	}
	
	
	void doElipse() {
		float sjMayor, sjMenor;
		try {
			System.out.print("Indique cuanto mide el semi eje mayor: ");
			sjMayor=Float.valueOf(inputKeyBoard.nextLine());
			System.out.print("Indique cuanto mide el semi eje menor: ");
			sjMenor=Float.valueOf(inputKeyBoard.nextLine());
			
			Elipse ObjElipse = new Elipse("Elipse", sjMayor, sjMenor);
			ObjElipse.calcularPerimetro();
			ObjElipse.calcularArea();
			System.out.println("La " + ObjElipse.getNombre() +" tiene de semieje mayor: " +ObjElipse.getSJMayor() +" y de semieje menor: " +ObjElipse.getSJMenor());
			System.out.println("El perimetro  del " + ObjElipse.getNombre() +" mide: " +ObjElipse.getPerimetro());
			System.out.println("El area  del " + ObjElipse.getNombre() +" mide: " +ObjElipse.getArea());
			
		} catch (Exception e) {
			System.out.println("Error: " +e);
		}
	}

}
