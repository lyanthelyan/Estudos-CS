using Enums.Entities;
using Enums.Entities.Enums;
class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Order order = new Order
        {
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment

        };

        Console.WriteLine(order);

        string txt = OrderStatus.PendingPayment.ToString();

        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        Console.WriteLine(os);


    }
}