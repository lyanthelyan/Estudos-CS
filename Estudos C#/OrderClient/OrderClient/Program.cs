using OrderClient.Entities;
using OrderClient.Entities.Enums;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Client Data:");
        Console.WriteLine();
        Console.Write("Name: ");
        
        string name = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Birth Date (DD/MM/YYYY): ");
        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Client client = new Client(name, email, birthDate);

        Console.WriteLine();
        Console.WriteLine("Enter Order Data:");
        Console.WriteLine($"Status(PendingPayment/Processing/Shipped/Delivered): ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
        
        Order order = new Order(DateTime.Now, status, client);

        Console.WriteLine("How many items to this order? ");
        int items = int.Parse(Console.ReadLine());

        for (int i = 1; i < items+1; i++)
        {
            Console.WriteLine($"Enter #{i} item data: ");
            Console.Write("Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Product Price: ");
            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(productName, productPrice);
            OrderItem OrderItems = new OrderItem(quantity, productPrice, product);
            
            order.AddItem(OrderItems);
            
            Console.WriteLine();
        }
        Console.WriteLine("ORDER SUMMARY:");
        Console.WriteLine(order.ToString());

    }
}