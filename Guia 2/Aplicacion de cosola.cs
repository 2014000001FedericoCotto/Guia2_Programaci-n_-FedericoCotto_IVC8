// Susing System;

class Program
{
    static void Main()
    {
        int s, c;
        double precio = 0, t;

        Console.WriteLine("Seleccione sector:");
        Console.WriteLine("1 Palco Q300");
        Console.WriteLine("2 Tribuna Q100 - Q125");
        Console.WriteLine("3 Preferencia Q50 - Q75");
        Console.WriteLine("4 Generales Q30 - Q50");
        s = int.Parse(Console.ReadLine());

        Console.Write("Numero de entradas que desea: ");
        c = int.Parse(Console.ReadLine());

        switch (s)
        {
            case 1:
                precio = 300;
                break;
            case 2:
                precio = 112.5; 
                break;
            case 3:
                precio = 62.5;
                break;
            case 4:
                precio = 40; 
                break;
          

        t = precio * c;
        Console.WriteLine("Total a pagar: Q" + t);
    }
}