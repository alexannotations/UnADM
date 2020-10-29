/* **********************
 * Programa para mostrar el uso de
 * estructuras y funciones
 * con los estados de la Republica Mexicana
 * 
 * @author: Alejandro Ayala
 * Octubre 2020
 * 
 * Superficie en km2
 * 
 * 
 * **********************/
#include<stdio.h>

typedef struct Entidades 
	{
		int codigo_entidad;
		char nombre [33]; 
		int superficie; 
	} entidad;

entidad aux, estado[32] = 	 
	{
        1, "Aguascalientes", 5625,
        2, "Baja California", 71546,
        3, "Baja California Sur", 73943,
        4, "Campeche", 57727,
        5, "Chiapas", 73681,
        6, "Chihuahua", 247487,
        7, "Ciudad de México", 1479,
        8, "Coahuila de Zaragoza", 151571,
        9, "Colima", 5627,
        10, "Durango", 123367,
        11, "Guanajuato", 30621,
        12, "Guerrero", 63794,
        13, "Hidalgo", 20856,
        14, "Jalisco", 78630,
        15, "México", 22333,
        16, "Michoacán de Ocampo", 58667,
        17, "Morelos", 4892,
        18, "Nayarit", 27862,
        19, "Nuevo León", 64203,
        20, "Oaxaca", 93343,
        21, "Puebla", 34251,
        22, "Querétaro", 11658,
        23, "Quintana Roo", 42535,
        24, "San Luis Potosí", 61165,
        25, "Sinaloa", 57331,
        26, "Sonora", 184946,
        27, "Tabasco", 24747,
        28, "Tamaulipas", 80148,
        29, "Tlaxcala", 4016,
        30, "Veracruz de Ignacio de la Llave", 71856,
        31, "Yucatán", 39671,
        32, "Zacatecas", 75416
	};

void menu();
void unico();
void descendente();
void ascendente();

int main(int argc, char const *argv[])
{

    return 0;
}

void menu()
{
	printf( "\n\n---------------------------------\n");    
	printf( "\n Entidades federativas de M%cxico \n", 130 );    
	printf( "\n---------------------------------\n");    
	printf( "\n\n1) Ver una entidad \n" );    
	printf( "2) Listar en orden ascendente (superficie)  \n" );    
	printf( "3) Listar en orden descendente (superficie)  \n" );   
    printf( "4) Listar en orden ascendente (nombre)  \n" );    
	printf( "5) Listar en orden descendente (nombre)  \n" );   
	printf( "9) Salir \n\n" );    
	printf( "Elige una opci%cn:\n", 162 ); 
}


void unico()
{

}


void descendente()
{

}


void ascendente()
{

}
