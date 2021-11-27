package figura;

import java.util.Scanner;

public class UIMenu {
	
	private static String msgError = "Please select a correct answer. You typed an incorrect option, please type the number according";
	private float medida =0;
	private static Scanner inputKeyBoard = new Scanner(System.in);
	
	public static void showMenu() {
		
		UIMenu menu = new UIMenu();
        System.out.println("Welcome to Figures");
        System.out.println("Selecciona la opción deseada");
        
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
		Cuadrado ObjCuadrado = new Cuadrado("Cuadrado");
		System.out.print("Indique cuanto mide el lado: ");
		
		try {
			medida =Float.valueOf(inputKeyBoard.nextLine());
		} catch (Exception e) {
			System.out.println("Error: " +e);
		}
		
		ObjCuadrado.setLado(medida);
		ObjCuadrado.calcularPerimetro();
		ObjCuadrado.calcularArea();
		System.out.println("El lado del " + ObjCuadrado.getNombre() +" mide: " +ObjCuadrado.getLado());
		System.out.println("El perimetro  del " + ObjCuadrado.getNombre() +" mide: " +ObjCuadrado.getPerimetro());
		System.out.println("El area  del " + ObjCuadrado.getNombre() +" mide: " +ObjCuadrado.getArea());
		
	}
	
	
	void doRectangle() {
		
	}
	
	
	void doCircle() {
		
	}
	
	
	void doElipse() {
		
	}

}
