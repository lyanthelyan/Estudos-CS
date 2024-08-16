using WorkerData.Entities.Enums;
using System.Globalization;
using WorkerData.Entities;
using System.Diagnostics.Contracts;
class Program
{
    private static void Main(string[] args)
    {
        //Worker Data
        Console.Write("Enter department's name: ");
        string deptName = Console.ReadLine();
        
        Console.WriteLine("Enter work data:");
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Level (Junior/MidLevel/Senior): ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

        Console.Write("Base Salary: ");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Department dept = new Department(deptName);
        Worker worker = new Worker(name, level, baseSalary, dept);

        Console.WriteLine("How many contracts to this worker?");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++) //Hour Contract
        {
            
            Console.WriteLine($"Enter {i} contract data:");
            Console.Write("Date(DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Value Per Hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Duration (Hours): ");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine();

            HourContract contract = new HourContract(date, valuePerHour, hours); 
            worker.AddContract(contract); // Adding the hour contract to the Worker
        }

        
    }
    
}