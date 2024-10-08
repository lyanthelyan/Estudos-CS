using LINQ.Entities;
using System.Linq;
using System.Runtime.InteropServices;
internal class Program
{
    private static void Main(string[] args)
    {

        // Specify the data source
        int[] myArray = { 1, 2, 3, 4, 5, 6 };

        // Define the query expression
        // Func<int, bool> t = Even;
        var result = myArray.Where(x => x % 2 == 0).Select(x => x * 10); // Where filtrou os elementos pares, no select escolheu cada um e multiplicou por 10

        //Execution
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        //========================================================================================================

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


        // var result1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
        // Alternative Sintaxe SQL
        var result1 =
            from p in products
            where p.Category.Tier == 1 && p.Price < 900
            select p;

        Print("Tier 1 and Price<900", result1);

        var result2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
        Print("Category Tools / Only Names", result2);

        //var result3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});
        //Sintaxe SQL
        var result3 =
            from p in products
            where p.Name[0] == 'C'
            select new
            {
                p.Name,
                p.Price,
                CategoryName = p.Category.Name
            };
        //Objeto anonimo, tive que colocar o CategoryName pq criou ambiguidade, o p.Name ja tem Name, ent'ao criei um apelido
        Print("Products with initial C / Name, Price, Category Name", result3);



        //var result4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);//Ordenando por preço e Nome
        //SINTAXE SQL
        var result4 =
            from p in products
            where p.Category.Tier == 1
            orderby p.Price, p.Name
            select p;


        Print("Order by Price and Name", result4);

        var result5 = result4.Skip(2).Take(4);
        Print("Tier 1 Order By Price then By Name Skip 2 elements and take 4 elements", result5);

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=" + "First Tests" + "=-=-=-=-=-=-=-=-=-=");

        var result6 = products.First();
        Console.WriteLine("First test1: ");
        Console.WriteLine(result6);
        Console.WriteLine();

        var result7 = products.Where(p => p.Price < 500);
        Console.WriteLine("First minor:");
        Console.WriteLine(result7.First());
        Console.WriteLine();

        var result8 = products.Where(p => p.Price > 5300);
        Console.WriteLine("First Or Default test2: ");
        Console.WriteLine(result7.FirstOrDefault()); // O Primeiro ou o default, se nao tiver vai retornar nulo 

        var result9 = products.Where(p => p.Id == 3).SingleOrDefault(); // Apenas um single elemento
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=" + "SingleOrDefault" + "=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(result9);

        var result10 = products.Where(p => p.Id == 30).SingleOrDefault();
        Console.WriteLine(result10); // Vai retornar nulo

        var result11 = products.Max(p => p.Price); // Filtrar o maior pelo preço
        Console.WriteLine("Max price: " + result11);
        var result12 = products.Min(p => p.Price); // Filtrar o minmo pelo preço
        Console.WriteLine("Min price: " + result12);

        var result13 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
        Console.WriteLine("Category 1 sum prices: " + result13);

        var result14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // Se foir deafult ou a lista sem nada, vai retornar 0
        Console.WriteLine("Category 1 average price:  " + result14);

        var result15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y); // Criei a propia função usando select e agregate'
        Console.WriteLine("Categort 1 agregate sum: " + result15);

        var result16 = products.GroupBy(p => p.Category);
        foreach (var item in result16)
        {
            Console.WriteLine(" Category " + item.Key.Name + ": ");
            foreach (var item1 in item)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine();
        }
    }

    static void Print<T>(string message, IEnumerable<T> colleciton)
    {
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=" + message + "=-=-=-=-=-=-=-=-=-=");
        foreach (var item in colleciton)
        {
            Console.WriteLine(item);
            Console.WriteLine();
        }
    }

    /*static bool Even(int x)
    {
        return x % 2 == 0;
    }*/


}