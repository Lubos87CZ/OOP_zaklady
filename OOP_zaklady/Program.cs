using System;
using System.Linq;

namespace OOP_zaklady;

public static class Program
{
    public static void Main()
    {
        Kostka kostka1 = new Kostka();
        Kostka kostka2 = new Kostka(9);
        Bojovnik bojovnik = new Bojovnik("Zalgoren", 100, 20, 40, kostka1);
        Bojovnik souper = new Bojovnik("Pepa z Jelcan", 100,60, 10, kostka1);
        Arena arena=new Arena(bojovnik,souper,kostka1);

        //hod sestistenou kostkou
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

       /*  Console.WriteLine("Bojovnik: {0}", bojovnik); //test ToString()
        Console.WriteLine("Nazivu: {0}", bojovnik.Nazivu());
        Console.WriteLine("Zivot: {0}", bojovnik.GrafickyZivot());

        souper.Utoc(bojovnik); //test utoku soupere na naseho hrace
        Console.WriteLine(souper.VratPosledniZpravu());
        Console.WriteLine(bojovnik.VratPosledniZpravu());
        Console.WriteLine("Zivot po utoku: {0}", bojovnik.GrafickyZivot()); */
        arena.Zapas();


        Console.ReadKey();

    }
}
