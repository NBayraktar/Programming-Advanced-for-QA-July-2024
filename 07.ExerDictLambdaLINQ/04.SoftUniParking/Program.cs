namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read n number of commands - integer
            int countComands = int.Parse(Console.ReadLine());

            Dictionary<string, string>parking = new Dictionary<string, string>();

            for (int i = 1; i <= countComands; i++) { 
                string command = Console.ReadLine();
                string registerUser = command.Split(" ")[0];
                
                if (registerUser == "register")
                {
                    string owner = command.Split(" ")[1];
                    string carPlateNumber = command.Split(" ")[2];
                    if (!parking.ContainsKey(owner))
                    {
                        parking.Add(owner, carPlateNumber);
                        Console.WriteLine($"{owner} registered {carPlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carPlateNumber}");
                    }
                }
                else
                {
                    string unregisterUser = command.Split(" ")[1];
                    if (!parking.ContainsKey(unregisterUser))
                    {
                        Console.WriteLine($"ERROR: user {unregisterUser} not found");
                    }
                    else
                    {
                        parking.Remove(unregisterUser);
                        Console.WriteLine($"{unregisterUser} unregistered successfully");
                    }
                }
            }
            foreach (KeyValuePair<string, string> pair in parking)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}
