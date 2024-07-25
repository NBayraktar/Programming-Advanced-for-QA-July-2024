using System.Text;
namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a single string from the console
            string strText = Console.ReadLine();

            // Creating String Builder for digits, letters and others
            StringBuilder sbDigits = new StringBuilder();
            StringBuilder sbLetters = new StringBuilder();  
            StringBuilder sbOthers = new StringBuilder();

            foreach (char symbol in strText)
            {
                if (char.IsDigit(symbol))
                {
                    sbDigits.Append(symbol);
                }
                else if (char.IsLetter(symbol))
                {
                    sbLetters.Append(symbol);
                }
                else
                {
                    sbOthers.Append(symbol);
                }
            }
            Console.WriteLine(sbDigits);
            Console.WriteLine(sbLetters);
            Console.WriteLine(sbOthers);
        }
    }
}
