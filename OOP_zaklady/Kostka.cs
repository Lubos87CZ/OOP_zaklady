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
    private int pocetSten;

    //definice konstruktoru, definujeme jako metodu bez navratoveho typu 
    public Kostka(int aPocetSten) //parametr v konsturktoru
    {
        pocetSten = aPocetSten;
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

}

