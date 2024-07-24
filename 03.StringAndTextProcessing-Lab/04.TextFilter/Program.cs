namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read string of banned words and text (string) from the console;
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            // All words included in the ban list should be replaced with a string of asterisks '*', whose length must be equal to the word's length.
            foreach (string word in bannedWords) {
                string replacementWord = "";
                for (int i = 1; i <= word.Length; i++) {
                    replacementWord += "*";
                }
                text = text.Replace(word, replacementWord);
            }
            Console.WriteLine(text);
        }
    }
}
