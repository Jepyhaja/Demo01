using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht12
{
    class Program
    {
        static void Main(string[] args)
        {

            int luku;
            int[] luvut = new int[5];

            for (int i=0; i<=4; i++) // laitetaan lukujen kyselylle looppi pyörii 5 kertaa.
            {
                Console.WriteLine("Anna kokonaisluku"); //haetaan luvut
                string line = Console.ReadLine();      
                luku = int.Parse(line);                 //parsitaan kokonaisluvuksi
                luvut[i] = luku;                        //sijoitetaan kokonaisluku luvut[i] lokeroon, i määrittyy loopissa.
                
            }
            for (int j = 4; j >= 0; j--)                //käänteinen looppi tulostukseen
            {

                Console.Write(luvut[j]);                // luvut[j] tulostus j määräytyy loopissa
            }
        }
    }
}
