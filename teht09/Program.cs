using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
        {

            int luku, yht=0;

            do
            {
                Console.Write("Anna luku  ");
                string line = Console.ReadLine(); // luetaan käyttäjän syöte
                luku = int.Parse(line); //parsitaan syöttestä luku

                yht = luku + yht; // laksetaan kaikki annetut luvut yhteen

            } while (luku != 0); // looppi jatkuu jos luku ei ole nolla
            Console.WriteLine("Lukujesi summa " + yht );
        }
    }
}
