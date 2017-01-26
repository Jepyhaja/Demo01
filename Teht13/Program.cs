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
                Console.WriteLine("Anna arvosana"); //pyydetään syöttämään arvosana
                string line = Console.ReadLine();
                luku = int.Parse(line);                 //parsitaan kokonaisluvuksi
                luvut[i] = luku;                        //sijoitetaan kokonaisluku luvut[i] lokeroon, i määrittyy loopissa.
            }

          

            Console.Write("total points are = " + (luvut.Sum() - luvut.Max() - luvut.Min()) + " ");


        }






    }
}
