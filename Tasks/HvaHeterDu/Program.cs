using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvaHeterDu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, hva heter du?");
            string inputName = Console.ReadLine();
            Console.WriteLine($"Velkommen {inputName}");
            Console.ReadKey();
        }
    }
}
