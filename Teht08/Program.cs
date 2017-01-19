using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku,luku1,luku2;
            Console.Write("Anna luku  ");
            string line = Console.ReadLine(); // luetaan käyttäjän syöte
            luku = int.Parse(line); //parsitaan syöttestä luku
            
            Console.Write("Anna luku  ");
            string line1 = Console.ReadLine();
            luku1 = int.Parse(line1);
          
            Console.Write("Anna luku  ");
            string line2 = Console.ReadLine(); 
            luku2 = int.Parse(line2); 
            // koska lukuja vain kolme käytetään if lausekkeita, muuten voisi käyttää for looppia
            if (luku > luku1 && luku > luku2) Console.WriteLine(luku); // luku suurempi kuin luku1 JA luku suurempi kuin luku2, käydään siis yksitellen kaikki vaihtoehdot läpi.
            if (luku1 > luku && luku1 > luku2) Console.WriteLine(luku1);
            if (luku2 > luku && luku2 > luku1) Console.WriteLine(luku2);

        }
    }
}
