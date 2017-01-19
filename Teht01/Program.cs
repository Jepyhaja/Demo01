using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask a number
            int number;
            Console.Write("Give a number!! >");
            string line = Console.ReadLine(); // "1"
            number = int.Parse(line); // "1" --> 1
            
            //which number?

            switch(number)
            {
                case 1: Console.WriteLine("yksi"); break;
                case 2: Console.WriteLine("Kaksi"); break;
                case 3: Console.WriteLine("Kolme"); break;
                default: Console.WriteLine("Joku muu luku!"); break;
            }

        }
    }
}
