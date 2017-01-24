using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku, sija;
            int[] luvut = new int[5];

            for (int i = 0; i <= 4; i++) // laitetaan lukujen kyselylle looppi pyörii 5 kertaa.
            {
                Console.WriteLine("Anna kokonaisluku"); //haetaan luvut
                string line = Console.ReadLine();
                luku = int.Parse(line);                 //parsitaan kokonaisluvuksi
                luvut[i] = luku;                        //sijoitetaan kokonaisluku luvut[i] lokeroon, i määrittyy loopissa.
            }

            // järjestetään luvut suuruus järjestykseen

            for(int j=1; j<=4;j++) // aloitetaan taulukon alusta
            {
                if (luvut[j] > luvut[j++]) // jos [0] on suurempi kuin [1] vaihda paikkoja
                {
                    sija = luvut[j++];
                    luvut[j++] = luvut[j];
                    luvut[j] = sija;
                }

                
            }
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(luvut[i]);
            }
        }
    }
}
