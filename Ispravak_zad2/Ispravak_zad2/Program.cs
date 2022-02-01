/*(6 bodova) Napišite program koji će ispisati sve prijestupne godine u razdoblju od
(uključujući) 1900. do (uključujući) 2100. Prijestupne godine su one koje su djeljive sa
400 plus one koje su djeljive sa 4, ali ne i sa 100.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispravak_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prijestupna;

            for (int brojac = 1900; brojac <= 2100; brojac += 4)
            {


                prijestupna = brojac;
                Console.WriteLine(prijestupna + ". je prijestupna godina." + "\n");
            }

            Console.ReadKey();

        }
    }
}