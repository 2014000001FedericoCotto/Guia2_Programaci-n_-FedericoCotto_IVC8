using System;

class Program
{
    static void Main()
    {
        int opc;
        double val;

        Console.WriteLine("Seleccione una unidad de medida:");
        Console.WriteLine("1 Metros");
        Console.WriteLine("2 Pies");
        Console.WriteLine("3 Centimetros");
        Console.WriteLine("4 Pulgadas");
        opc = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor: ");
        val = double.Parse(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("Pies: " + (val * 3.28084));
                Console.WriteLine("Centimetros: " + (val * 100));
                Console.WriteLine("Pulgadas: " + (val * 39.3701));
                break;
            case 2:
                Console.WriteLine("Metros: " + (val / 3.28084));
                Console.WriteLine("Centimetros: " + (val * 30.48));
                Console.WriteLine("Pulgadas: " + (val * 12));
                break;
            case 3:
                Console.WriteLine("Metros: " + (val / 100));
                Console.WriteLine("Pies: " + (val / 30.48));
                Console.WriteLine("Pulgadas: " + (val / 2.54));
                break;
            case 4:
                Console.WriteLine("Metros: " + (val / 39.3701));
                Console.WriteLine("Pies: " + (val / 12));
                Console.WriteLine("Centimetros: " + (val * 2.54));
                break;
           
        }
    }
}