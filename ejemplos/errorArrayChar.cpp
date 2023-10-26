/******************************************************************************

Curiosidad en los tipos de datos
Un arreglo de char[n] siempre podra contener n-1 caracteres, 
debido a que el caracter final es '\0' que significa "fin de cadena".
Cada elemento char ocupa un byte.

*******************************************************************************/

#include <iostream>

using namespace std;

int main()
{
    //string respuesta = "yes"; // con esta declaracion true en if
    char respuesta[4]="yes";    // con esta declaracion false en if
                                // si el arreglo se declara de tamaño 3, error en compilacion

    cout<<"¿Eres un programador?"<<endl;

    //cin>>respuesta;           // Para introducir la respuesta por teclado

    if(respuesta == "yes"){
        cout<<"Bien";
    }
    else{
        cout<<"Mentiroso";
    }

    cout<<"\n Respondiste: \""<<respuesta<<"\""<<endl;
    // Se muestra en consola:
    // Mentiroso
    // Respondiste: "yes"
    
    return 0;
}
