using System;
using System.Text;

namespace Ex2_Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Console.WriteLine(RepeatStrings(words));
        }

        private static string RepeatStrings(string[] words)
        {
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                foreach (char _ in word)
                {
                    result.Append(word);
                }
            }
            return result.ToString();
        }
    }
}
