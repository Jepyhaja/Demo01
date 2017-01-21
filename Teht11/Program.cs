using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht11
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int luku;

            Console.WriteLine("Anna luku > ");
            string line = Console.ReadLine();
            luku = int.Parse(line);

            for (int i = 0; i < luku; i++)  // Luku määrittää kierrosten määrän. Lopuksi lisätään i muuttujaan yksi. i muuttujalla määrätään rivi.
            {
                for (int j = 0; j <= i; j++)  //  looppi kiertää tasan i muuttujan arvon verran. j muutujalla määrätään merkkien määrä.
                {

                    Console.Write('*'); //Write tulostaa peräkkäisiä * merkkejä.

                }
                Console.WriteLine(' '); //kun tähdet on tulostettu i loopin loppuun vielä rivin vaihto.
            }

        }
    }
}
