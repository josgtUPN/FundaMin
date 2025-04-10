Algoritmo sin_titulo
	Algoritmo P01_Bienes_Raices
		//Algoritmo para calcular la cuota a pagar
		//por la compra de una casa
		//Definir Variables
		Definir IngresoComprador Como Real
		Definir Enganche Como Real
		Definir CostoCasa Como Real
		Definir CuotaCasa Como Real
		//Ingresar Datos
		Escribir "Bienes Raices - Compra Casa"
		Escribir "***************************"
		Escribir "Ingreso del Comprador > 0 : "
		Leer IngresoComprador
		//Validar el ingreso del comprador
		Si(IngresoComprador>0) Entonces
			Escribir "Costo Casa > 0 : "
			Leer CostoCasa
			//Validar el Costo de la Casa
			Si(CostoCasa>0) Entonces
				Si(IngresoComprador<8000) Entonces
					Enganche = CostoCasa * (15/100)
					CuotaCasa = (CostoCasa - Enganche) / (10 * 12)
				SiNo
					Enganche = CostoCasa * (30/100)
					CuotaCasa = (CostoCasa - Enganche) / (7 * 12)
				FinSi
				//Salida de Datos
				Escribir "Enganche : ", Enganche
				Escribir "Cuota Casa : ", CuotaCasa
				
			SiNo
				Escribir "Costo Casa > 0"
			FinSi
		SiNo
			Escribir "Ingreso del Comprador > 0"
		FinSi
FinAlgoritmo
FinAlgoritmo
