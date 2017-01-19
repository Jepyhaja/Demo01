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
            double kmhinta, perkm = 7.02 / 100;


            Console.WriteLine("How many kilometers did you drive you scum!?");
            string syote = Console.ReadLine();
            kilometrit = int.Parse(syote);
            //kulutus 7.02 per 100km
            //bensan hinta 1.595
            kmhinta = (perkm * kilometrit * 1.595);
            Console.WriteLine("Your scummy ways costed you" + " " + kmhinta + " " + "worth of money!");

        }
    }
}
