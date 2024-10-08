using LINQ_Exercises.Entities;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Category c1 = new Category { Id = 1, Name = "Tools", Tier = 2 };
        Category c2 = new Category { Id = 1, Name = "Computers", Tier = 1 };
        Category c3 = new Category { Id = 1, Name = "Eletronics", Tier = 1 };

        List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

        var ex1 = products.Where(x => x.Price > 100 && x.Category.Name == "Eletronics");
        Print(ex1);

        var ex3 = products.GroupBy(x => x.Category.Name);
        

    }

    static void Print<T>(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }
}