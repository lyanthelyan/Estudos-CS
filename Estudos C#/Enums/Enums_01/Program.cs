using Enums_01.Enums;
class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Choose a number from 0 to 6 to choose a day of week: ");
        int number  = int.Parse(Console.ReadLine());

        DayOfWeek day = (DayOfWeek)number;

        Console.WriteLine("You chose: "+day);

    }
}