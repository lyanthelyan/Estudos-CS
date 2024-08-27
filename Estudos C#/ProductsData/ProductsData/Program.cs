using ProductsData.Entities;
using System.ComponentModel;
using System.Globalization;
using System.Security.AccessControl;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of products: ");
        int numberOfProducts = int.Parse(Console.ReadLine());

        List<Product> products = new List<Product>();

        for (int i = 1; i < numberOfProducts+1; i++)
        {
            Console.WriteLine($"Product #{i} data");

            Console.Write("Common, used or imported (c/u/i)? ");
            char cui = char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            switch (cui)
            {
                case 'u':
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacturedDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
                    products.Add(new UsedProduct(name, price, manufacturedDate));
                    Console.WriteLine();
                    break;
                case 'i':
                    Console.Write("Customs fee: ");
                    double customsFee = Double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsFee));
                    Console.WriteLine();
                    break;
                default:
                    products.Add(new Product(name, price));
                    Console.WriteLine();
                    break;
            }

            
        }

        Console.WriteLine("PRICE TAGS:");

        foreach (Product product in products)
        {
            Console.WriteLine(product.PriceTag());
        }

    }
 
}