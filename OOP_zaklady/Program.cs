using System;
using System.Linq;

namespace OOP_zaklady;

public static class Program
{
    public static void Main()
    {
        Kostka kostka1 = new Kostka();
        Kostka kostka2 = new Kostka(9);
        Bojovnik bojovnik = new Bojovnik("Zalgoren", 100, 20, 10, kostka1);

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

        Console.WriteLine("Bojovnik: {0}", bojovnik); //test ToString()
        Console.WriteLine("Nazivu: {0}", bojovnik.Nazivu());
        Console.WriteLine("Zivot: {0}", bojovnik.GrafickyZivot());

        Console.ReadKey();

    }
}
