using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Utflyktsgeneratorn ==");

            Console.Write("Hur stor är din budget? ");
            int budget = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hur många ska följa med? ");
            int antal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vad kostar resan per person? ");
            int resan = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hur mycket kostar maten? ");
            int mat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hur stor rabatt har alla? ");
            int rabatt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vad är kostnad för entré? ");
            int entre = Convert.ToInt32(Console.ReadLine());

            // Räknar ut hur mycket maten och resan kostar för en person.
            int KostnadPerPerson = resan + mat + entre;

            // Gruppens totala kostnad
            int TotalKostnad = KostnadPerPerson * antal - rabatt;
            Console.WriteLine();

            Console.WriteLine("Kostnad per person: " + KostnadPerPerson + " kr");
            Console.WriteLine("Total kostnad: " + TotalKostnad + " kr");

            if (TotalKostnad > budget)
            {
                Console.WriteLine("Du har inte tillräkligt med pengar.");
            }
            else if (TotalKostnad <= budget )
            {
                Console.WriteLine("Du har tillräkligt med pengar.");
            }

        }
    }
}