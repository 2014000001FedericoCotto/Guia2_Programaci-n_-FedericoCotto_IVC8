Algoritmo entradas
	Definir s, c Como Entero
    Definir p, total Como Real
	Leer s
    
    Escribir "Seleccione un sector:"
    Escribir "1  Palco (Q300)"
    Escribir "2  Tribuna (Q100 - Q125)"
    Escribir "3  Preferencia (Q50 - Q75)"
    Escribir "4  Generales (Q30 - Q50)"
    Leer s
    
    Escribir "Cantidad de entradas:"
    Leer c
    
    Segun s Hacer
        1:
            precio <- 300
        2:
            precio <- 112.5   
        3:
            precio <- 62.5    
        4:
            precio <- 40      
        De Otro Modo:
            Escribir "Sector invalido"

	FinSegun

	total <- p * c

	Escribir "Total a pagar: Q", total
	
FinAlgoritmo
