Algoritmo semana3_ejercicio1
	//definirmos las variables
	definir dona, medicina, ginecologia, pediatria, traumatologia Como Real
	Escribir "======= Donacion ======="
	escribir "________________________"
	//damos a nuestra unica variable que recibira un valor de la persona
	escribir "Ingrese monto de la donacion en soles:"
	leer dona
	si dona>0 Entonces
		//calculamos
		medicina = 0.5 * dona
		ginecologia = 0.3 * dona
		pediatria = 0.03 * medicina
		traumatologia = 0.20 * dona
		//mostramos los resultados
		Escribir "Las donaciones se repartiran de esta forma:"
		Escribir "-Medicina general recibira s/.", medicina
		Escribir "-Ginecologia recibira s/.", ginecologia
		Escribir "-Pediatria recibira s/.", pediatria, ", del monto total de lo que recibira medicina general"
		Escribir "-Traumatologia recibira s/.", traumatologia
	SiNo
		escribir "ERROR. Vuelva a ingresar el monto de la donacion."
	FinSi
	
	
FinAlgoritmo
