using System;

namespace Ex3_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeWord = Console.ReadLine().ToLower();
            string words = Console.ReadLine().ToLower();
            int index = words.IndexOf(removeWord);

            while (index != -1)
            {
                words = words.Remove(index, removeWord.Length);
                index = words.IndexOf(removeWord);
            }
            Console.WriteLine(words);
        }
    }
}