Algoritmo Planillaprofesores
	//calcular planilla de profesore
	//definir variables
	definir NombreProf como cadena
	definir NHoras como real
	definir PagoHra como real
	definir PagoBruto,PagoGrati,pagobrutototal como real
	definir pagoaport como real
	definir netopagar Como Real
	definir pogoessalud Como Real
	
	//ingresar datos
	escribir "pago - planilla"
	escribir "**********"
	escribir "nombre profesor:"
	leer NombreProf
	escribir "numero de horas:"
	leer NHoras 
	//validar el numero de horas
	si(NHoras>=0) Entonces
		//ingresar el pago por horas 
		escribir "pago por hora <0-70]"
		Leer PagoHra
		//validar el pago por hora
		si((PagoHra>0) && (PagoHra<=70)) Entonces
			//calcular el pago bruto
			PagoBruto = NHoras * PagoHra
			//calcular la gratificacion adelantada
			PagoGrati = (PagoBruto/6 ) + (PagoBruto/6)*(9/100)
			//Calcular el Pago Bruto total
			PagoBrutoTotal = PagoBruto + PagoGrati
			//Calcular las aportaciones
			PagoAport = PagoBrutoTotal * (13/100)
			//Calcular el Neto a Pagar
			NetoPagar = PagoBruto + PagoGrati - PagoAport
			//Calcular el Pago de Essalud
			PagoEssalud = PagoBrutoTotal * (9/100)
			//Mostrar  resultados
			Escribir "nombre del profesor:", NombreProf
			escribir "pago bruto:",trunc(PagoBruto*100.0)/100.0
			Escribir "pago gratificaion:", trunc(PagoGrati*100.0)/100.0
			Escribir "pago bruto total:", trunc(PagoBrutoTotal*100.0)/100.0
			Escribir "pago aportaciones:", trunc(PagoAport*100.0)/100.0
			Escribir "neto a pagar:", trunc(NetoPagar*100.0)/100.0
			Escribir "pago por essalud:", trunc(PagoEssalud*100.0)/100.0
		SiNo
			Escribir "pago por hora mayor a cero hasta 70"
		FinSi
	SiNo
		Escribir "numero de horas mayor o igual a cero"
	FinSi
FinAlgoritmo
