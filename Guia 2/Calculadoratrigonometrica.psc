Algoritmo CalculadoraTrigonometrica
	
	Definir ang, rad, desi Como Real


	Escribir "Calculadora Trigonometrica"
	Escribir "1 ? Seno"
	Escribir "2 ? Coseno"
	Escribir "3 ? Tangente"

	Escribir "Ingrese el ángulo: "
	Leer ang


	rad <- ang * PI / 180

	Escribir "Seleccione una opción:"
	Leer desi

	Segun desi Hacer
	1:
		Escribir "Seno", sen(rad)
	2:
		Escribir "Coseno", cos(rad)
	3:
		Escribir "Tangente", tan(rad)

	FinSegun
	
FinAlgoritmo
