using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {

            int sekunnit,tunnit,minuutit;

            Console.Write("Anna sekuntimaara >");
            string syote = Console.ReadLine();
            sekunnit = int.Parse(syote);

            Console.WriteLine("Syotit " + sekunnit);

            tunnit = sekunnit / 3600; // tästä saadaan tunnit

            Console.WriteLine("Tunteja: " + tunnit);

            sekunnit = sekunnit - (tunnit * 3600);

            minuutit = sekunnit / 60; // minuutit

            Console.WriteLine("Minuutteja: " + minuutit);

            sekunnit = sekunnit - (minuutit * 60); // jäljelle jää sekunnit

            Console.WriteLine("Sekunteja: " + sekunnit);
        }
    }
}
