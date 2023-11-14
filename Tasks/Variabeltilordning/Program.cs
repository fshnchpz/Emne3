using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabeltilordning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Summen av 2+5: {Sum(2,5)}");

            Console.WriteLine("Neste, så skal vi kjøre en metode som returnerer ingenting");
            Console.WriteLine("Trykk en knapp for å kjøre getNothing();");
            Console.ReadKey();
            getNothing();
        }


        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static void getNothing()
        {
            Console.WriteLine("Denne metoden returnerer ingenting");

            return;
        }
    }
}
