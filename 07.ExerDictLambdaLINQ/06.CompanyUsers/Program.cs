namespace _06.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read string from the console
            string input = Console.ReadLine();

            // Dictionary for company users
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string companyName = input.Split(" -> ")[0];
                string employeeId = input.Split(" -> ")[1];

                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers.Add(companyName, new List<string>());
                }

                List<string> employeesList = companyUsers[companyName];

                if (!employeesList.Contains(employeeId))
                {
                    employeesList.Add(employeeId);
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> entry in companyUsers)
            {
                Console.WriteLine($"{entry.Key}");
                entry.Value.ForEach(id => Console.WriteLine($"-- {id}"));
            }
        }
    }
}
