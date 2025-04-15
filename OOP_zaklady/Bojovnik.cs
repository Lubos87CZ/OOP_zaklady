using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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
    ///Promenna pro ukladani zprav
    ///</summary>
    private string zprava;
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
    ///Umoznuje branit se uderu
    ///</summary> 
    public void BranSe(int uder)
    {
        int zraneni = uder - (obrana + kostka.Hod()); //od uderu protivnika odecteme nasi obranu navysenu o hodnotu jez padne na kostce
        if (zraneni > 0)
        {
            zivot -= zraneni;
            zprava = String.Format("{0} utrpel zraneni {1} hp", jmeno, zraneni);
            if (zivot <= 0)
            {
                zivot = 0;   //dorovnani zivota na nulu, abychom nenavysovali zivot pri  odrazeni celeho utoku
            }
        }
        else
            zprava = String.Format("{0} odrazil cely utok", jmeno);
        NastavZpravu(zprava);
    }
    ///<summary>
    ///Metoda bere jako parametr instanci bojovnika na ktereho utocime a ptom na nem volame metodu BranSe()
    ///</summary>
    public void Utoc(Bojovnik souper)
    {
        int uder=utok+kostka.Hod();
        NastavZpravu(String.Format("{0} utoci s uderem {1} hp", jmeno, uder));
        souper.BranSe(uder);   //na instanci soupere zavola metodu BranSe a ten se bude branit nasemu utoku
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
    private void NastavZpravu(string zprava)
    {
        this.zprava = zprava; //nastavi zpravu predanou v parametru do privatni promenne
    }
    public string VratPosledniZpravu()
    {
        return zprava;    //vrati zpravu ulozenou v privatni promenne
    }
}
