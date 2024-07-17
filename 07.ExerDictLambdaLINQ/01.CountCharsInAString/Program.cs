namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program that counts all characters in a string, except for space (' '). Print all the occurrences in the following format "{char} -> {occurrences}"
            string text = Console.ReadLine();  // reads string from the console

            Dictionary<char, int> countChars = new Dictionary<char, int>(); // Empty Dictionary for storing chars and occurances

            foreach (char symbol in text)
            {
                if (symbol == ' ')
                {
                    continue;
                }

                if (!countChars.ContainsKey(symbol))
                {
                    countChars.Add(symbol, 1);
                }
                else
                {
                    countChars[symbol]++;
                }
            }

            foreach (KeyValuePair<char, int> pair in countChars)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
