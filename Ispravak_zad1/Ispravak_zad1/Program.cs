/*(6 bodova) Napišite program koji će provjeriti jesu li vrijednosti sadržane u int
varijablama x, y i z stranice pravokutnog trokuta. U program uključite i provjeru da
vrijednosti varijabli za ovakav primjer imaju smislene vrijednosti (iznosi moraju biti
veći od 0).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispravak_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Unesi stranice pravokutnog trokuta : ");
            Console.WriteLine("Stranice moraju biti veće od 0.");
            Console.WriteLine("Stranica x (Prva kateta) : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Stranica y (Druga kateta) : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Stranica z (Hipotenuza) : ");
            z = Convert.ToInt32(Console.ReadLine());

            while (x==0 || y==0 || z == 0)
            {
                Console.WriteLine("Unesi stranice pravokutnog trokuta : ");
                Console.WriteLine("Stranice moraju biti veće od 0.");
                Console.WriteLine("Stranica x (Prva kateta) : ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Stranica y (Druga kateta) : ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Stranica z (Hipotenuza) : ");
                z = Convert.ToInt32(Console.ReadLine());
            }
            
                
            

            if ((x*x) + (y*y) == (z * z))
            {
                Console.WriteLine("Unijeli ste stranice pravokutnog trokuta.");
            }
            else
            {
                Console.WriteLine("Stranice koje ste unijeli ne odgovaraju pravokutnom trokutu.");
            }

            Console.ReadKey();
        }
    }
}
