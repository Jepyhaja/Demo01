using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht10
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] luvut = { 1, 2, 33, 44, 55, 68, 77, 96, 100 }; //lukujen alustus
            for (int i = 0; i < 9; i++)                          // looppi, jolla käydään luvut läpi
            {
                if (luvut[i] % 2 == 0)                           //jos jakojäännös 2 = 0 on luku jaollinen 2:lla
                {
                    Console.WriteLine("YEEEEEAAAP!!! " + luvut[i]);     //tulostaa luvun joka on jaollinen 2:lla
                }

            }
        }
    }
}
