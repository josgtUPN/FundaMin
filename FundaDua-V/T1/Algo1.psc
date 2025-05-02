Algoritmo Empresa_APCI
	Definir salario1, salario2, salario3 como real
	Definir SM, PROM COMO REAL
	DEFINIR PORCEN1, PORCEN2, PORCEN3 COMO REAL
	Definir p1,p2,p3 Como Entero
	
	ESCRIBIR "ingresa el primer salario:"
	leer salario1
	
	Repetir 
		si salario1<0 Entonces
			Escribir "ERROR. El monto debe ser mayor igual a cero."
			Escribir "ingresa nuevamente el primer salario: "
			leer salario1
		FinSi
	Hasta Que salario1>=0
	
	escribir "ingrese el segundo salario:"
	leer salario2
	Repetir
		si salario2<0 Entonces
			Escribir "ERROR. El monto debe ser mayor igual a cero."
			escribir "ingrese nuevamente el segundo sueldo:"
			leer salario2
		FinSi
	Hasta Que salario2>=0
	
	Escribir "ingrese el tercer salario:"
	leer salario3
	Repetir
		si salario3<0 entonces
			Escribir "ERROR.el monto debe ser mayor igual a cero"
			Escribir "ingrese nuevamente el tercer sueldo"
			leer salario3
		FinSi
	Hasta Que salario3>=0
	
	Escribir "ingrese el peso del primer salario:"
	leer p1
	Repetir
		si p1<0 entonces
			Escribir "ERROR.el monto debe ser mayor a cero"
			Escribir "ingrese nuevamente el tercer sueldo"
			leer p1
		FinSi
	Hasta Que p1>=0
	
	Escribir "ingrese el peso del segundo salario:"
	leer p2
	Repetir
		si p2<0 entonces
			Escribir "ERROR.el monto debe ser mayor a cero"
			Escribir "ingrese nuevamente el tercer sueldo"
			leer p2
		FinSi
	Hasta Que p2>=0
	
	Escribir "ingrese el peso del tercer salario:"
	leer p3
	Repetir
		si p3<0 entonces
			Escribir "ERROR.el monto debe ser mayor a cero"
			Escribir "ingrese nuevamente el tercer sueldo"
			leer p3
		FinSi
	Hasta Que p3>=0
	
	SM = salario1+salario2+salario3
	PROM = SM/3
	PORCEN1 = salario1/SM*100
	PORCEN2 = salario2/SM*100
	PORCEN3 = salario3/SM*100
	medPON = (p1*salario1+p2*salario2+p3*salario3)/(p1+p2+p3)
	MULTI = (salario1*salario2*salario3)
	mediageo = MULTI^(1/3)
	MEDAR = 3/(1/Salario1 + 1/Salario2 + 1/Salario3) 
	Escribir "la suma de los tres salarios es      : s/.", SM
	Escribir "El promedio de los tres salarios es  : ", PROM
	escribir "el porcentaje del primer salario es  : ", PORCEN1,"%"
	escribir "el porcentaje del segundo salario es : ", PORCEN2,"%"
	escribir "el porcentaje del tercer salario es  : ", PORCEN3,"%"
	Escribir "la media ponderada de los salarios es: S/.", medPON
	ESCRIBIR "la medai geometria de los salarios es: S/.", mediageo 
	Escribir "la media armonica de los salarios es : S/.", MEDAR
FinAlgoritmo