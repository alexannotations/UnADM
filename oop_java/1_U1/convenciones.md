# Convenciones de la programación

- **Paquetes (Packages):** El nombre de los paquetes deben ser sustantivos escritos con minúsculas. 
```package shipping.object```

- **Clases (Classes):** Los nombres de las clases deben ser sustantivos, mezclando palabras, con la primera letra de cada palabra en mayúscula (capitalizada). ```class AccountBook```

- **Interfaces (Interfaces):** El nombre de la interfaz debe ser capitalizado como los nombres de las clases. ```interface Account```

- **Métodos (Methods):** Los métodos deben ser nombrados con verbos, mezclando palabras, con la primera letra en minúscula. Dentro del nombre del método, la primera letra de cada palabra capitalizada. ```balanceAccount()```

- **Variables (Variables):** Todas las variables deben ser combinaciones de palabras, con la primera letra en minúscula. Las palabras son separadas por las letras capitales. Moderar el uso de los guiones bajos, y no usar el signo de dólares ($) porque tiene un significado especial dentro de las clases. ```currentCustomer```. Las variables deben tener significados transparentes para exponer explícitamente su uso al lector casual. Evitar usar simples caracteres (```i```,```j```,```k```) como variables excepto para casos temporales como ciclos.

- **Constantes (Constants):** Las constantes deben nombrarse totalmente en mayúsculas, separando las palabras con guiones bajos. Las constantes tipo objeto pueden usar una mezcla de letras en mayúsculas y minúsculas. ```HEAD_COUNT MAXIMUN_SIZE```

- **Estructuras de Control (Control Structures):** Usar Llaves (```{ }```) alrededor de las sentencias, aun cuando sean sentencias sencillas, son parte de una estructura de control, tales como un ```if-else``` o un ciclo ```for```. 
```java
            if ( condición ){
            Sentencia1;
            }
            else
            {
            Sentencia2;
            }
```
- **Espaciado (Spacing):** Colocar una sentencia por línea, y usar de dos a cuatros líneas vacías entre sentencias para hacer el código legible. El número de espacios puede depender mucho del estándar que se use.

- **Comentarios (Comments):** Utilizar comentarios para explicar los segmentos de código que no son obvios. Utilizar ```//``` para comentar una sola línea; para comentar extensiones más grandes de información encerrar entre los símbolos delimitadores ```/* */```. Utilizar los símbolos ```/** */``` para documentar los comentarios para proveer una entrada al javadoc y 
generar un HTML con el código:
```java
                //Un comentario de una sola línea

                /*Comentarios que pueden abarcas más de
                    una línea*/

                /**Un cometario para propósitos de documentación 
                *   @see otra clase para más información
                */
```
*Nota:* la etiqueta ```@see``` es especial para javadoc para darle un efecto de *“también ver”* a un link que referencia una clase o un método.


### Estructura de una clase Java

```java
            package javaapplication1;
            import javax.swing.*;

            public class JavaApplication1 {

                public JavaApplication1(){
                    // Constructor
                }
                public static void main(String[] args) {
                    // Instrucciones del metodo principal
                }
            }
```
