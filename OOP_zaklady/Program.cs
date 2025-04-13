using System;
using System.Linq;

namespace OOP_zaklady;

public static class Program
{
    public static void Main()
    {
        Kostka kostka=new Kostka();
        Console.WriteLine("OOP Zaklady \n");
        Console.WriteLine("Pocet sten kostky: {0}", kostka.VratPocetSten());
        Console.ReadKey();

    }
}
