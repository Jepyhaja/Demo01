using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3, summa, keskiarvo;
            
            Console.Write("Anna ensimmainen luku > ");
            string line = Console.ReadLine(); // luetaan käyttäjän syöte
            luku1 = int.Parse(line); //parsitaan syöttestä luku

            Console.Write("Anna toinen luku > ");
            line = Console.ReadLine(); // luetaan käyttäjän syöte
            luku2 = int.Parse(line); //parsitaan syöttestä luku

            Console.Write("Anna kolmas luku > ");
            line = Console.ReadLine(); // luetaan käyttäjän syöte
            luku3 = int.Parse(line); //parsitaan syöttestä luku

            summa = (luku1 + luku2 + luku3);
            keskiarvo = (summa / 3);
            Console.WriteLine("Summa: " + summa + "\nKeskiarvo: " + keskiarvo);
        }
    }
}
