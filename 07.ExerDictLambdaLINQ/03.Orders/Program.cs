namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read string text from the console
            string product = Console.ReadLine();

            // Dictionary for product price
            Dictionary<string, double> productPrice = new Dictionary<string, double>();

            // Dictionary for product quantity
            Dictionary<string, int> productQuantity = new Dictionary<string, int>();

            while (product != "buy")
            {
                string[] productData = product.Split(" ");
                string name = productData[0];
                double price = double.Parse(productData[1]);
                int quantity = int.Parse(productData[2]);

                // Checking and adding product into Dictionaries
                if (!productPrice.ContainsKey(name) && !productQuantity.ContainsKey(name))
                {
                    productPrice.Add(name, price);
                    productQuantity.Add(name, quantity);
                }
                else
                {
                    productPrice[name] = price;
                    productQuantity[name] += quantity;
                }

                product = Console.ReadLine();

            }


        }
    }
}
