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
        Console.WriteLine();
        
   

        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string monthAndYear = Console.ReadLine();
        int month = int.Parse(monthAndYear.Substring(0, 2));
        int year = int.Parse(monthAndYear.Substring(3));

        for (int i = 0; i < worker.Contracts.Count; i++)
        {
            Console.WriteLine($"Contract {i + 1}: {worker.Contracts[i].Date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
        }
        // Loop para remover contratos
        for (int i = 0; i < worker.Contracts.Count; i++)
        {
            Console.Write("Enter the number of the contract to remove: ");
            int choose = int.Parse(Console.ReadLine()) - 1; // Se o usuario escolher a posição 2, ela irá para a 1 usando a poisção certa da lista

            // Verificar se o índice está dentro dos limites válidos
            if (choose >= 0 && choose < worker.Contracts.Count)
            {
                worker.RemoveContract(worker.Contracts[choose]);
                Console.WriteLine("Contract removed successfully.");
                Console.WriteLine();
                // Opcional: Exibir contratos restantes
                Console.WriteLine("Remaining contracts:");
                for (int j = 1; j < worker.Contracts.Count; j++)
                {
                    Console.WriteLine($"Contract {j + 1}: {worker.Contracts[j].Date}");
                }
            }
            else
            {
                Console.WriteLine("Invalid contract number.");
            }
        }
        Console.WriteLine();

        Console.WriteLine($" Name: {worker.Name}\n Department: {worker.Department.Name}\n Income for {monthAndYear}: {worker.Income(year,month).ToString("F2", CultureInfo.InvariantCulture)} ");

    }
    
}