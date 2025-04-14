using System;
using System.Linq;

namespace OOP_zaklady;

public static class Program
{
    public static void Main()
    {
        Kostka kostka1 = new Kostka();
        Kostka kostka2 = new Kostka(9);

        //hod seestistenou kostkou
        Console.WriteLine("Hod sestistennou kostkou: ");
        for (int i = 0; i < 15; i++)
        {
            Console.Write(kostka1.Hod() + " ");
        }
        Console.WriteLine();
        //hod devitistenou kostkou
        Console.WriteLine("Hod devitistennou kostkou: ");
        for (int i = 0; i < 15; i++)
        {
            Console.Write(kostka2.Hod() + " ");
        }
        Console.ReadKey();

    }
}
