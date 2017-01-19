using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;

            Console.WriteLine("Anna vuosiluku niin kerron onko se karkausvuosi");
            string syote = Console.ReadLine();
            vuosi = int.Parse(syote);

            if (vuosi % 4 == 0 && vuosi % 100 != 0 || vuosi % 400 == 0)
            { 
                Console.WriteLine("KYLLÄ SE ON SE karkausvuosi!!");

            }

            else {
                Console.WriteLine("ei ole ");
            }
        


        }
    }
}
