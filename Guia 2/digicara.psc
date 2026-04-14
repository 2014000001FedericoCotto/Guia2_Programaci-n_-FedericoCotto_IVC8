Algoritmo digicara
	Definir x Como Caracter
    
    Escribir "Ingrese un carácter:"
    Leer x
    
    Si ( x >= "0" ) Entonces
        Escribir "Digito"
    Sino
        Segun Minusculas(x) Hacer
            "a","e","i","o","u":
                Escribir "vocal"
        FinSegun
    FinSi
	
FinAlgoritmo
