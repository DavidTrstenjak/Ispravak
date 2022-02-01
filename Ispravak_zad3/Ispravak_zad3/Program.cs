/*(26 bodova) Definirajte klasu Neboder sa sljedećim članicama:
a. privatne varijable:
i. visina,
ii. brojKatova
b. svojstva:
i. Visina koje će vraćati i definirati visinu nebodera.
ii. BrojKatova koje će vraćati i definirati broj katova.
Definirajte objekt Tower tipa Neboder s visinom od 200 m, postavite vrijednost broja
katova na 100, povećajte visinu za 10 m, povećajte broj katova za 1, te pomoću
ToString() metode ispišite podatke o neboderu te prosječnu visinu kata.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispravak_zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Neboder Tower = new Neboder();
            Tower.Visina = 200;
            Tower.BrojKatova = 100;

            Tower.novaVisina = Tower.Visina + 10;
            Tower.novaBrojKatova = Tower.BrojKatova + 1;

            Tower.prosjecnaVisina = Tower.novaVisina / Tower.novaBrojKatova;

            Console.WriteLine("Neboder Tower je visok " + Convert.ToString(Tower.novaVisina) + " metara." + "\n");
            Console.WriteLine("Neboder Tower ima " + Convert.ToString(Tower.novaBrojKatova) + " kat." + "\n");
            Console.WriteLine("Prosjecna visina svakog kata je " + Convert.ToString(Tower.prosjecnaVisina) + " metara." + "\n");


            Console.ReadKey();

        }

        class Neboder
        {
            private float visina;
            private float brojKatova;
            public float novaVisina;
            public float novaBrojKatova;
            public float prosjecnaVisina;

            public float Visina { get => visina; set => visina = value; }
            public float BrojKatova { get => brojKatova; set => brojKatova = value; }
        }


    }
}