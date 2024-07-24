namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read first string from the line of the console, read second string from the second line of the console
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            // Remove all of the occurrences of the first string in the second string and print the remaining string to the console
            while (text.IndexOf(wordToRemove) != -1) {
                int wordPosition = text.IndexOf(wordToRemove);
                text = text.Remove(wordPosition, wordToRemove.Length);
            }
            Console.WriteLine(text);

        }
    }
}
