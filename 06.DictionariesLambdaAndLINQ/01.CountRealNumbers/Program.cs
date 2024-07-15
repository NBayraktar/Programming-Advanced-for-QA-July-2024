using System.Reflection;

namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a list of integers from the console
            double[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();
            // Print them in ascending order, along with their number of occurrences in the format:{ number} -> { occurances}
            SortedDictionary<double, int>countNums = new SortedDictionary<double, int>();
            foreach (double number in numbers) {
                if (countNums.ContainsKey(number)) { 
                    countNums[number]++;
                }
                else
                {
                    countNums.Add(number, 1);
                }
            }

            foreach (KeyValuePair<double, int> pair in countNums)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

        }
    }
}
