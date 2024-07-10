namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read array of strings from the console
            string[] texts = Console.ReadLine().Split(" ").ToArray();

            string result = "";
            foreach (string text in texts) { 
                int length = text.Length;
                for (int i = 0; i < length; i++) { 
                    result += text; 
                }
            }

            Console.WriteLine(result);
        }
    }
}
