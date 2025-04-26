using System;

namespace OOP_zaklady;

public class Arena
{
    ///<summary>
    /// Prvni boojovnik v arene
    /// </summary>
    private Bojovnik bojovnik1;
    ///<summary>
    /// Druhy boojovnik v arene
    /// </summary>
    private Bojovnik bojovnik2;
    ///<summary>
    ///Hraci kostka pro arenu
    /// </summary>
    private Kostka kostka;

    public Arena(Bojovnik bojovnik1,Bojovnik bojovnik2,Kostka kostka)
    {
            this.bojovnik1=bojovnik1;
            this.bojovnik2=bojovnik2;
            this.kostka=kostka;
    }

    private void Vykresli()
    {
        Console.Clear();
        Console.WriteLine("-----------------Arena-----------------\n");
        Console.WriteLine("Zdraví bojovníků: \n");
        Console.WriteLine("{0} {1}", bojovnik1, bojovnik1.GrafickyZivot());
        Console.WriteLine("{0} {1}", bojovnik2, bojovnik2.GrafickyZivot());
    }

    private void VypisZpravu(string zprava)
    {
        System.Console.WriteLine(zprava);
        Thread.Sleep(1300); //uspani vlakna na 500ms
    }

    public void Zapas()
    {
        //puvodni poradi
        Bojovnik b1=bojovnik1;
        Bojovnik b2=bojovnik2;
        Console.WriteLine("Vitejte v dnesnim zapase. \n Utkaji se: {0} proti {1}\n)",bojovnik1,bojovnik2);
        bool zacinaBojovnik2=(kostka.Hod()<=(kostka.VratPocetSten()/2));
        //prohozene poradi
        if(zacinaBojovnik2)
        {
            b1=bojovnik2;
            b2=bojovnik1;
        }
        Console.WriteLine("Zapas zacne bojovnik {0}...\n",b1);
        Console.ReadKey();
        while(b1.Nazivu() && b2.Nazivu())
        {
            b1.Utoc(b2);
            Vykresli();
            VypisZpravu(b1.VratPosledniZpravu()); //zprava oo utoku
            VypisZpravu(b2.VratPosledniZpravu()); //zprava o obrane
            if(b2.Nazivu()) //pokracuje pouze dokud je bojovnik2 nazivu
            {
                b2.Utoc(b1);
                Vykresli();
                VypisZpravu(b1.VratPosledniZpravu()); //zprava oo utoku
                VypisZpravu(b2.VratPosledniZpravu()); //zprava o obrane
            }
            Console.WriteLine();
        }
    }

}
