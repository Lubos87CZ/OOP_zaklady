using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP_zaklady;

public class Bojovnik
{
    //UVAHA: bojovnik ma jmeno a HP(HealthPoint).
    // U kazdeho bojovnika bude jiny jeho maxim. zivot a jiny souc. zivot
    //Bojovnik ma urcity utok a obranu, oboji vyjdreno v HP
    //Bojovnik bude mit referenci na instanci tridy Kostka, kdy pri utoku ci obrane
    //vzdy hodi kostkou a padle cislo si pricte nebo odecte. 
    //(Lze mit i pro kazdeho bojovnika zvlast kostku.)
    //Bojovnici budou podavat zpravy o tom co se deje.

    ///<summary>
    ///Jmeno bojovnika
    ///</summary>
    private string jmeno;
    ///<summary>
    ///Zivot v HP
    ///</summary>
    private int zivot;
    ///<summary>
    ///Maxim. zivot
    ///</summary>
    private int maxZivot;
    ///<summary>
    ///Utok v HP
    ///</summary>
    private int utok;
    ///<summary>
    ///Obrana v HP
    ///</summary>
    private int obrana;
    ///<summary>
    ///Instance hraci kostky
    ///</summary>
    private Kostka kostka;

    public Bojovnik(string jmeno, int zivot, int utok, int obrana, Kostka kostka)
    {
        this.jmeno = jmeno;
        this.zivot = zivot;
        this.maxZivot = zivot;
        this.utok = utok;
        this.obrana = obrana;
        this.kostka = kostka;
    }

    public override string ToString()
    {
        return jmeno;    //vrati jmeno bojovnika
    }

    ///<summary>
    ///Vraci zda je bojovnik na zivu
    ///</summary>
    public bool Nazivu()
    {
        return (zivot > 0); //muzeme rovnou vratit logickou hodnotu vyrazu
    }

    ///<summary>
    ///Vykresleni ukazatele graf. zivotaa
    ///</summary>
    public string GrafickyZivot()
    {
        string s = "["; //uvodni znak
        int celkem = 20; //celkovva delka ukazatele
        double pocet = Math.Round(((double)zivot / maxZivot) * celkem);
        //pretypovanim operandu zivot na double docilime necelociselneho deleni
        if ((pocet == 0) && (Nazivu()))
            pocet = 1; //pro pripad ze vyjde zivot 0, ale bojovnik neni mrtvy
        for (int i = 0; i < pocet; i++)
            s += "#";
        s = s.PadRight(celkem + 1); //doplneni retezce na delku celkem+1, 
        //kde znak navic je uvodni znak
        s += "]";
        return s;
    }
}
