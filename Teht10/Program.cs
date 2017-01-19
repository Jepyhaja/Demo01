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

            int[] luvut = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i = 0; i < 9; i++)
            {
                if (luvut[i] % 2 == 0)
                {
                    Console.WriteLine("YEEEEEAAAP!!! " + luvut[i]);
                }

            }
        }
    }
}
