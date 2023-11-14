using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Program
    {

        static Random rand = new Random();
        private static int rng;

        static void Main(string[] args)
        {
            GuessGame();
        }

        static void GuessGame()
        {
            rng = rand.Next(1, 100);
            Console.WriteLine("Gjett tallet riktig! Hvilke tall gjetter du?");
            var guessInput = Console.ReadLine();
            GuessNumber(Convert.ToInt32(guessInput));
        }
        static void GuessNumber(int input)
        {
            if (rng > input)
            {
                Console.WriteLine("Du må gjette høyere!");
                GuessNumber(Convert.ToInt32(Console.ReadLine()));
            }
            else if (rng < input)
            {
                Console.WriteLine("Du må gjette lavere!");
                GuessNumber(Convert.ToInt32(Console.ReadLine()));
            }
            else
            {
                Console.WriteLine("Du gjettet riktig! Vil du prøve igjen? Y/N");
                char key = Console.ReadKey().KeyChar;
                if (key == 'y')
                {
                    Console.WriteLine();
                    GuessGame();
                }
                else
                {
                    Console.WriteLine();
                    return;
                }
            }
        }
    }
}
