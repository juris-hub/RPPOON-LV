using System;
using System.Collections.Generic;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Zadatak 1
            DiceRoller kockicoVrtac = new DiceRoller();
            
            for(int i = 0; i < 20; i++)
            {
                Die kockica = new Die(6);
                kockicoVrtac.InsertDie(kockica);
            }
            kockicoVrtac.RollAllDice();
            IList<int> rezultat = kockicoVrtac.GetRollingResults();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(rezultat[i]);
            }
            */

            //Zadatak 2
            /*
            DiceRoller kockicoVrtac = new DiceRoller();

            for (int i = 0; i < 20; i++)
            {
                Die kockica = new Die(6, new Random());
                kockicoVrtac.InsertDie(kockica);
            }
            kockicoVrtac.RollAllDice();
            IList<int> rezultat = kockicoVrtac.GetRollingResults();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(rezultat[i]);
            }
            */
        }
    }
}
