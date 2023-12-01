/* 
 * Este programa en Java muestra los ficheros (archivos o directorios) 
 * de un determinado directorio que se cargan en un array de elementos tipo File
 * utilizando el método list().
 */

import java.io.File;

public class UD1_Actividad1_1_Parte1 {
	
	// Método principal que se ejecuta al iniciar el programa
	public static void main(String[] args) {	
		// Se indica una ruta por medio de una cadena de texto y se guarda en la variable "dir"
		// En este caso, "." significa "path actual", es decir, el directorio "UD1_Actividad1_1_Parte1"
		String dir = ".";
		
		// Se crea un objeto "f" de la clase "File" al que se le pasa "dir" como parámetro
		// El objeto "f" apuntará al path especificado en la variable "dir"
		File f = new File(dir);
		
		// El método .listFiles() lista todos los archivos incluidos dentro del path especificado en "dir"
		// Se utiliza el método "listFiles()" del objeto "f" para almacenar en un array los nombres de los archivos contenidos en el path
		File[] listaFicheros = f.listFiles();		
		
		// Se muestra por consola el número de ficheros, que es igual a la longitud del array generado
		System.out.printf("Ficheros en el directorio actual: %d %n", listaFicheros.length);
		
		// Se recorre "listaFicheros" mediante un bucle for
		// En cada iteración del bucle se selecciona uno de los ficheros
		// Se obtiene la siguiente información de cada fichero: su nombre, si es un fichero o si es un directorio 
		// Esta información se muestra por consola
		for (int i = 0; i < listaFicheros.length; i++) {
			File f2 = listaFicheros[i];
			System.out.printf("Nombre: %s, es fichero?: %b, es directorio?: %b %n", 
					f2.getName(), f2.isFile(), f2.isDirectory());
		}
	}
}
