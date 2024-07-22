namespace _05.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read count of students and student name and grade from the console
            int studentsCount = int.Parse(Console.ReadLine());

            // Dictionary for student grades
            Dictionary<string, List<double>> studentsGrade = new Dictionary<string, List<double>>();

            for (int i = 1; i <= studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentsGrade.ContainsKey(studentName))
                {
                    studentsGrade.Add(studentName, new List<double>());
                    studentsGrade[studentName].Add(studentGrade);
                }
                else
                {
                    studentsGrade[studentName].Add(studentGrade);
                }
            }

            // Printing the students and their average grade to the console
            foreach (KeyValuePair<string, List<double>> entry in studentsGrade)
            {
                double averageGrade = entry.Value.Average();
                if (averageGrade >= 4.5)
                {
                    Console.WriteLine($"{entry.Key} -> {averageGrade:F2}");
                }
            }
        }
    }
}
