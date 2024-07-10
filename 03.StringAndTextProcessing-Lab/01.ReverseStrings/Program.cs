namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a series of strings from the console, until you receive an (end) command
            string text = Console.ReadLine();

            while (text != "end")
            {
                string reversedText = "";
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reversedText += text[i];
                }
                Console.WriteLine($"{text} = {reversedText}");
                text = Console.ReadLine();
            }
        }
    }
}

