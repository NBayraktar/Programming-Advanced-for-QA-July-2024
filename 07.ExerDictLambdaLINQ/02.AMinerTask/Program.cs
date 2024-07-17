namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You will be given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper and so on) and every even - quantity. Your task is to collect the resources and print them each on a new line. Print the resources and their quantities in the following format: "{resource} –> {quantity}". The quantities will be in the range [1… 2 000000000].

            string resource = Console.ReadLine();

            Dictionary<string, int> resourceQuantity = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (resourceQuantity.ContainsKey(resource))
                {
                    resourceQuantity[resource] += quantity;
                }
                else
                {
                    resourceQuantity.Add(resource, quantity);
                }
                resource = Console.ReadLine();
            }
            foreach (KeyValuePair<string, int> kvp in resourceQuantity)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
