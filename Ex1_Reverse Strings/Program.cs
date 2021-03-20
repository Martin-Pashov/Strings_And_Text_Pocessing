using System;

namespace Ex1_Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string end = Console.ReadLine();

            while (end != "end")
            {
                if (end != "end")
                {
                    string reverse = "";

                    for (int i = end.Length - 1; i >= 0; i--)
                    {
                        reverse += end[i];
                    }
                    Console.WriteLine($"{end} = {reverse}");
                }
                end = Console.ReadLine();
            }
        }
    }
}