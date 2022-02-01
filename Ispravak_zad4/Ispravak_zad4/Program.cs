/*(6 bodova) Definirajte klasu KlasaX sa sljedećim članicama:
a. privatna varijabla tipa int broj
b. svojstvo Broj koje će vraćati i definirati vrijednost varijable
Dodijelite vrijednost 10 varijabli broj, te ispišite njenu vrijednost.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispravak_zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaX ispis = new KlasaX();
            ispis.Broj = 10;

            Console.WriteLine(ispis.Broj);

            Console.ReadKey(); 

        }

        class KlasaX
        {
            private int broj;

            public int Broj { get => broj; set => broj = value; }
        }
    }
}
