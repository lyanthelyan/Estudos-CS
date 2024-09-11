using NoInterfaceStudy.Entities;
using NoInterfaceStudy.Sevices;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter rental data");
        Console.Write("Car model: ");
        string model = Console.ReadLine();

        Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.Write("Return (dd/MM/yyyy HH:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        
        Console.WriteLine("Enter price per hour: ");
        double hour = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter price per day: ");
        double day = double.Parse(Console.ReadLine());


        CarRental carRental = new CarRental(start, finish, new Vehicle(model));

        RentalSevice rentalSevice = new RentalSevice(hour, day, new BrazilTaxSevice());

        rentalSevice.ProcessInvoice(carRental);

        Console.WriteLine("Invoice:");
        Console.WriteLine(carRental.Invoice);

    }
}