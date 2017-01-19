using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Anna oppilaan pistemaara > ");
            string line = Console.ReadLine(); // luetaan käyttäjän syöte
            luku = int.Parse(line); //parsitaan syöttestä luku
            

            //katotaan mikä luku on kyseessä ja toimitaan sen mukaan
            if (luku == 0 || luku == 1) { Console.WriteLine("Arvosana 0"); };

            if (luku == 2 || luku == 3) { Console.WriteLine("Arvosana 1"); };

            if (luku == 4 || luku == 5) { Console.WriteLine("Arvosana 2"); };

            if (luku == 6 || luku == 7) { Console.WriteLine("Arvosana 3"); };

            if (luku == 8 || luku == 9) { Console.WriteLine("Arvosana 4"); };

            if (luku >= 10 && luku <= 12) { Console.WriteLine("Arvosana 5"); };

            if (luku < 0 || luku > 12) { Console.WriteLine("Pistemaarassa on jotain pielessa."); } // siltä varalta että syötetään virheellinen pistemäärä.

        }
    }
}
