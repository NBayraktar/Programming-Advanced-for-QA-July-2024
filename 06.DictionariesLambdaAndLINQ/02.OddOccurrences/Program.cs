using System.Reflection;

namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read words (strings) from the console space separated
            string[] words = Console.ReadLine()
                .Split(" ")
                .ToArray();

            // Extract all elements from a given sequence of words that are present in it an odd number of times (case-insensitive), print the result elements in lowercase, in their order of appearance.

            Dictionary <string, int> wordsCount = new Dictionary<string, int>();

            foreach (string word in words) { 
                string loweredWord = word.ToLower();
                if (!wordsCount.ContainsKey(loweredWord)) { 
                    wordsCount.Add(loweredWord, 1);
                }
                else
                {
                    wordsCount[loweredWord]++;
                }
            }

            foreach (KeyValuePair<string, int> pair in wordsCount)
            {
                int number = pair.Value;
                if (number % 2 != 0)
                {
                    Console.Write($"{pair.Key} ");
                }
            }
        }
    }
}
