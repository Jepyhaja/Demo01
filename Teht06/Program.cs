using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometrit;
            double kulutus, kmhinta, perkm = 7.02 / 100;


            Console.WriteLine("How many kilometers did you drive");
            string syote = Console.ReadLine();
            kilometrit = int.Parse(syote);
            kmhinta = (perkm * kilometrit * 1.595);
            kulutus = perkm * kilometrit;
            Console.WriteLine("You used " + kulutus + "liters and it cost you " + kmhinta + "!" );

        }
    }
}
