namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an array of strings from the console
            string[] texts = Console.ReadLine()
                .Split(" ")
                .Where(t => t.Length % 2 == 0)
                .ToArray();

            // Print each word on a new line
            foreach (string text in texts) {
                Console.WriteLine(text);
            }
        }
    }
}
