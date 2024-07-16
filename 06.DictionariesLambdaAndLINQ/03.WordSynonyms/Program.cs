namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read n number from the console (the count of the words)
            int wordsCount = int.Parse(Console.ReadLine());

            // Creating empty Dictionary
            Dictionary<string, List<string>> wordSynonyms = new Dictionary<string, List<string>>();

            for (int i = 1; i <= wordsCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!wordSynonyms.ContainsKey(word))
                {
                    wordSynonyms.Add(word, new List<string>());
                    wordSynonyms[word].Add(synonym);
                }
                else
                {
                    wordSynonyms[word].Add(synonym);
                }
            }

            foreach (KeyValuePair<string, List<string>> entry in wordSynonyms) {
                Console.WriteLine($"{entry.Key} - {string.Join(", ", entry.Value)}");
            }
        }
    }
}
