using ContributorsData.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of tax payer: ");
        int taxPayers = int.Parse(Console.ReadLine());

        List<Contributors> list = new List<Contributors>();

        for (int i = 1; i < taxPayers+1; i++)
        {
            Console.WriteLine($"Tax payer #{i} data:");
            Console.Write("Individual or company (i/c)? ");
            char ic = char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Anual Income: ");
            double anualIncome = double.Parse(Console.ReadLine());

            if (ic == 'i')
            {
                Console.Write("Health expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine());
                list.Add(new Individual(name, anualIncome, healthExpenditures));
            } else if(ic == 'c')
            {
                Console.Write("Number of Employees: ");
                int numberOfEmployees = int.Parse(Console.ReadLine());
                list.Add(new Company(name, anualIncome, numberOfEmployees));
            }
            Console.WriteLine();
        }

        Console.WriteLine("TAXES PAID:");
        foreach (Contributors item in list)
        {
            Console.WriteLine($"{item.Name} $ {item.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
        }
        Console.WriteLine();
        double sum = 0;
        foreach (Contributors item in list)
        {
            sum += item.Tax();
            
        }
        Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}