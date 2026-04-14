using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un caracter: ");
        char c = Convert.ToChar(Console.ReadLine());

        if (char.IsDigit(c))
        {
            Console.WriteLine("digito");
        }
        else
        {
            char letra = char.ToUpper(c);
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                Console.WriteLine("vocal");
           
        }
    }
}