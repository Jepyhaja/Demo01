using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;

            Console.Write("Anna ikasi > ");
            string syote = Console.ReadLine(); // luetaan käyttäjän syöte
            ika = int.Parse(syote); //parsitaan syöttestä luku

            if (ika < 18) { Console.WriteLine("ALAIKAINEN!"); }
            if (ika >= 18 && ika <= 65) { Console.WriteLine("aikuinen!"); }
            if (ika > 65) { Console.WriteLine("seniori!"); }
        }
    }
}
