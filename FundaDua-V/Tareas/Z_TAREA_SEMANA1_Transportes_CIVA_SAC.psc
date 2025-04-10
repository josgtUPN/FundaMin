Algoritmo Transportes_CIVA_SAC
	//definimos las variables
	definir dia1 como entero
	definir dia2 Como entero
	definir dia3 Como entero
	definir dia4 Como entero
	definir dia5 como entero
	definir promedio_de_pasajeros Como Real
	definir varianza como real
	definir desviacion_estandar Como Real
	//ingresamos los datos de dia a dia
	escribir "===Promedio-Varianza-Desviacion_Estandar==="
	escribir "ingrese la cantidad de pasajeros dia tras dia:"
	escribir "dia 1:"
	leer dia1
	escribir "dia 2:"
	Leer dia2
	escribir "dia 3:"
	leer dia3
	escribir "dia 4:"
	leer dia4
	escribir "dia 5:"
	leer dia5
	escribir "------------------------------------------------"
	//sacamos el promedio de la cantidad de pasajeros
	promedio_de_pasajeros = ( dia1 + dia2 + dia3 + dia4 + dia5 )/5 
	//hallamos en parte el "x" subuno hastas el "x" subcinco (restamos el dia menos el promedio y luego se eleva al cuadrado)
	x1 = (dia1-promedio_de_pasajeros)^ 2
	x2 = (dia2-promedio_de_pasajeros)^ 2
	x3 = (dia3-promedio_de_pasajeros)^ 2
	x4 = (dia4-promedio_de_pasajeros)^ 2
	x5 = (dia5-promedio_de_pasajeros)^ 2
	//como ya teniendo los datos se suma los resultados y se dividen entre 5 
	varianza = (x1+x2+x3+x4+x5)/5
	//para hallara la deviacion estandar se saca la raiz cuadrada de la varianza
	desviacion_estandar = RAIZ((x1+x2+x3+x4+x5)/5)
	escribir "el promedio de pasajeros es:", promedio_de_pasajeros
	escribir "la varianza es:", varianza
	escribir "la deviacion estandar es: ", desviacion_estandar
	
	
FinAlgoritmo
