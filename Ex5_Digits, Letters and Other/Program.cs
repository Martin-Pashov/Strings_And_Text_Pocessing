using System;
using System.Linq;

namespace Ex5_Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(string.Join("", input.Where(x => Char.IsDigit(x))) + 
                Environment.NewLine + string.Join("", input.Where(x => Char.IsLetter(x))) + 
                Environment.NewLine + string.Join("", input.Where(x => !Char.IsLetterOrDigit(x))));
        }
    }
}
