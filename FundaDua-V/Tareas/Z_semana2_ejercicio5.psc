Algoritmo fabrica_de_camisetas
	definir costmo, costotalmo como real
	definir precami, costototal como real
	definir cosfipla, ingresos, utilidades como real
	definir unidades como entero
	Escribir "ingrese costo de mano de obra: "
	leer costmo
	si (costmo >= 0) Entonces
		escribir "ingrese precio de camiseta: "
		leer precami
		si (precami >= 0) Entonces
			escribir "costo fijo planta: "
			leer cosfipla
			si (cosfipla >= 0) Entonces
				escribir "cuantas unidades fabricaras: "
				leer unidades
				SI (unidades >= 0) entonces
					costotalmo = costmo * unidades
					costototal = costotalmo + cosfipla
					ingresos = precami * unidades
					utilidades = ingresos - costototal
					escribir "con ", unidades, " unidades tendrias un costo total de mano de obra de $", costotalmo,"," 
					escribir "un costo fijo de $", cosfipla, ", un costo total de $", costototal, ", ingresos de $", ingresos 
					escribir "y una utilidad de $", utilidades, ". Por ende los resultados son:"
					Si (utilidades = 0) Entonces
						Escribir "=No hay perdida ni ganancia."
					sino
						si (utilidades > 0) Entonces
							Escribir "=Hay Ganancia"
						sino
							Escribir "=No Hay Ganancia"
						FinSi
					FinSi
				SiNo
					Escribir "escribe un monto mayor igual a 0"
				FinSi
			sino 
				Escribir "ingresa monto mayor igual a 0"
			FinSi
		SiNo
			escribir "ingresa un precio mayor igual a 0"
		FinSi
	sino 
		Escribir "ingrese monto mayor igual a 0"
	FinSi
	

	
FinAlgoritmo
