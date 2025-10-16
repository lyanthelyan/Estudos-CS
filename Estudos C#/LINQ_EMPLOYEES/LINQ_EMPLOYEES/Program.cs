using System.Globalization;
using System.Linq;
using LINQ_EMPLOYEES.Entitites;
internal class Program
{
    private static void Main(string[] args)
    {
        string sourcePath = @"C:\Users\T-GAMER\source\repos\NewRepo\linqemployee.txt";
        Console.Write("Enter Salary: ");
        double entrySalary = double.Parse(Console.ReadLine());

        List<Employee> employees = new List<Employee>();
        try
        {
            using (StreamReader sr = File.OpenText(sourcePath))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    string email = line[1];
                    double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
                Console.WriteLine($"Email of people whose salary is more than {entrySalary}: ");
                var emailSalary = employees.Where(e=>e.Salary > entrySalary).OrderBy(p=> p.Name);
                foreach (var item in emailSalary)
                {
                    Console.WriteLine(item.Email);
                }
                Console.Write("Sum of salary of people whose name starts with: ");
                char c = char.Parse(Console.ReadLine().ToUpper());
                var salarySum = employees.Where(e => e.Name.StartsWith(c)).Sum(e=>e.Salary);
                Console.WriteLine(salarySum);

            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message);}
       
    }
}