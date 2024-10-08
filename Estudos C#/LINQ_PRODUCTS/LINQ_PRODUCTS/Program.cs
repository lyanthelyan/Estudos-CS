using System.Linq;
using System.Globalization;
using System.Net.Sockets;
internal class Program
{
    private static void Main(string[] args)
    {
        string sourcePath = @"C:\Users\T-GAMER\source\repos\NewRepo\linqexercise.txt";
        List<Products> products = new List<Products>();
        try
        {
            using (StreamReader sr = File.OpenText(sourcePath))
            { 
                while (!sr.EndOfStream) 
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    double price = double.Parse(line[1],CultureInfo.InvariantCulture);
                    products.Add(new Products(name, price));
             
                }
                var average = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                foreach (var item in products)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Average: " + average.ToString("F2", CultureInfo.InvariantCulture));
                var inferiorPrice = products.Where(p => p.Price < average).OrderByDescending(p=>p.Name);
                foreach (var item in inferiorPrice)
                {
                    Console.WriteLine(item.Name);
                }

            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An Error has Ocurred: " +e.Message);
        }

    }

    class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products(){}
        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return "Name: "+Name +", "+"Price: "+Price;
        }
    }
}