using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP_zaklady;

/// <summary>
///Trida reprezentuje hraci kostku
///</summary>

public class Kostka
{
    ///<summary>
    ///Generator nahodnych cisel
    ///</summary>
    private Random random;
    ///<summary>
    ///Pocet sten kostky
    ///</summary>
    private int pocetSten; //atribut pocetSten (NE PARAMETR)

    //definice konstruktoru, definujeme jako metodu bez navratoveho typu 
    public Kostka(int pocetSten) //parametr v konsturktoru
    {
        this.pocetSten = pocetSten;
        //ukazatel this nam rika, ze atribut pocetSten nalezi pouze jedne konkretni instanci
        //promenou pocetSten pak C# chape jako parametr konstruktoru
        random = new Random(); //vytvoreni instance generatoru nahod. cisel
    }
    public Kostka() //dalsi konstruktor, tentokrat bez parametru
    {
        pocetSten = 6;
        random = new Random(); //vytvoreni instance generatoru nahod. cisel
    }
    ///<summary>
    ///Vrati pocet sten hraci  kostky
    ///</summary>
    public int VratPocetSten()
    {
        return pocetSten;
    }

    ///<summary>
    ///Vykona hod kostkou
    ///</summary>
    public int Hod()
    {
        return random.Next(1, pocetSten + 1);
        //vrati nahodne cislo v rozsahu od jedne do poctu sten kostky navyseneho o jednicku
    }

    public override string ToString()
    {
        //prekryti (override) metody ToString() na tride Kostka 
        //slouzi k textove reprezentaci instance
        return String.Format("Tato kostka ma {0} sten.", pocetSten);
    }

}
