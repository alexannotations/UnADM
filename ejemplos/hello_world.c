/* **********************
 * Hello world con la API de Windows
 * 
 * AAC Octubre 2020
 * Charles Petzold
 * **********************/

#include<windows.h>

int WINAPI WinMain (HINSTANCE hInstance, HINSTANCE hPrevInstance,
					PSTR szCmdLine, int iCmdShow)
{
	MessageBox (NULL, TEXT ("Hello Windows"), TEXT ("Message in title bar"), 0) ;
	return 0;
}
