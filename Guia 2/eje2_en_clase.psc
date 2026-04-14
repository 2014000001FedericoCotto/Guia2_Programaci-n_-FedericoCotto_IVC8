Algoritmo eje2_en_clase
	Definir num, nume2, operador, res Como Entero
	Escribir "Selecione una de las siguientes opciones: "
	Escribir "1 Suma"
	Escribir "2 Resta"
	Escribir "3 Multiplicación "
	Escribir "4 División"
	Leer operador
	
	Escribir Sin Saltar "Ingrese 2 valores de su preferencia"
	Leer num, nume2
	
	Segun operador Hacer
		1:
			res= num + nume2
			Escribir res
			
		2:
			res= num - nume2
			Escribir res
		3:
			res= num * nume2
			Escribir res
		4:
			res= num / nume2
			Escribir res
		De Otro Modo:
			Escribir "Ingrese un numero valido"
	Fin Segun
	
FinAlgoritmo
