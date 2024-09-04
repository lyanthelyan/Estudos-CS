using Exception.Entities;
using Exception.Entities.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        Account acc = null;

        while (acc == null)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine());

                Console.Write("WithDraw Limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine());

                acc = new Account(number, holder, balance, withDrawLimit);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Wrong Format. Please enter the data in the correct format.");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        while (true)
        {
            try
            {
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                acc.WithDraw(amount);
                Console.WriteLine($"New Balance: {acc.Balance}");
                break; // Encerra o loop quando o saque é bem-sucedido
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong Format. Please enter a valid amount.");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}