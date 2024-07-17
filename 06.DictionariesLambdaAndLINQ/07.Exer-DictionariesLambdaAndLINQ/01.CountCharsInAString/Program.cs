namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read string from the console
            string text = Console.ReadLine();

            // Count all characters in a string, expect for space (' '), print the occurrences in the following format: {char} -> {occurrences}
            Dictionary<char, int> countChar = new Dictionary<char, int>();
            foreach (char symbol in text)
            {
                if (symbol == ' ')
                {
                    continue;
                }

                if (!countChar.ContainsKey(symbol))
                {
                    countChar.Add(symbol, 1);
                }
                else
                {
                    countChar[symbol]++;
                }
            }
            foreach (KeyValuePair<char, int> pair in countChar)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
