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
void mostrarUnica(int);
void ordenarDescendente();
void ordenarAscendente();
int verificarInt();


int main(int argc, char const *argv[])
{
    int option, id_entidad;
    do
    {
        menu();
        scanf("%d",&option);
        switch (option)
        {
        case 1:
            id_entidad = verificarInt();
            mostrarUnica(id_entidad);
            break;

        case 2:
            /* code */
            break;

        case 3:
            /* code */
            break;

        case 4:
            /* code */
            break;

        case 5:
            /* code */
            break;

        case 9: printf("\n\tsee you\n");	break;
        default: printf( "La opci%cn no es valida\n", 162);
        }
    } while (option!=9);
    

    return 0;
}

void menu()
{
	printf( "\n\n\t==================================================\n");    
	printf( "\n\t\t Entidades federativas de M%cxico \n", 130 );    
	printf( "\n\t==================================================\n");    
	printf( "\n\t1) Ver una entidad \n\t" );    
	printf( "2) Listar en orden ascendente (superficie)  \n\t" );    
	printf( "3) Listar en orden descendente (superficie)  \n\t" );   
    printf( "4) Listar en orden ascendente (nombre)  \n\t" );    
	printf( "5) Listar en orden descendente (nombre)  \n\t" );   
	printf( "9) Salir \n\n" );    
	printf( "\t\tElige una opci%cn: ", 162 ); 
}


void mostrarUnica(int n)
{
    printf( "\n\t--------------------------------------------------\n");
    printf("\tID\tSuperficie en Km2\tNombre del estado\n");
	printf("\t%i.-\t %i\t\t\t %s",estado[n].codigo_entidad, estado[n].superficie, estado[n].nombre);
    printf( "\n\t--------------------------------------------------\n\t");
    system("pause");
}


void ordenarDescendente()
{

}


void ordenarAscendente()
{

}

int verificarInt()
{
    printf( "\t\t Ingrese un n%cmero entre 1 y 32: ", 163);
    int id;
    do
    {
        scanf("%i",&id);
        if (id<=0 || id>32)
        {
            printf("\t\t %cN%cmero invalido!!\n", 173, 163);
		    printf("\t\t Vuelva a introducir un n%cmero: ", 163);
        }
    } while (id<=0 || id>32);
    id--;
    return id;
}
