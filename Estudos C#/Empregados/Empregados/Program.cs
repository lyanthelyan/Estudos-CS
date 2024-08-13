namespace Empregados;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("How many employees will be registered: ");
        int registeredEmployees = int.Parse(Console.ReadLine());
        List<Employee> Employees = new List<Employee>();

        for (int i = 0; i < registeredEmployees; i++)
        {
            Console.WriteLine($"Employee #{i + 1}");

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Employees.Add(new Employee(id, name, salary));
        }

        Console.Write("Enter the employee id that will have salary increase: ");
        int searchId = int.Parse(Console.ReadLine());
        //! Verificar se existe um empregado com o ID especificado
        Employee emp = Employees.Find(x => x.Id == searchId);

        if (emp != null)
        {
            Console.Write("Enter the percentage: ");
            double percentageIncrease = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp.increaseSalary(percentageIncrease);
        }
        else
        {
            Console.WriteLine("Id not found");
        }


        foreach (var item in Employees)
        {
            Console.WriteLine($"Id: {item.Id}\n Name: {item.Name}\n Salary: {item.Salary.ToString("F2", CultureInfo.InvariantCulture)}$");
        }



    }
}
