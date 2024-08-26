using EmployeesPayment.Entities;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of employees: ");
        int emp  = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();
        for (int i = 1; i < emp+1; i++)
        {
            Console.WriteLine($"Employee #{i} data:");
            Console.Write("Outsourced (y/n)?  ");
            string ots=Console.ReadLine().ToLower();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ots == "y")
            {
                Console.Write("Additional charge: ");
                double additionalCharge = double.Parse(Console.ReadLine());
                employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
            }
            else { employees.Add(new Employee(name, hours, valuePerHour)); }
            Console.WriteLine();
        }

        Console.WriteLine("PAYMENTS:");
        foreach (Employee item in employees)
        {
            Console.WriteLine($"{item.Name} - $ {item.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}