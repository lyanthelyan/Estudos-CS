
using Extension_Methods.Extensions;
internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dt = new DateTime(2024, 9, 30, 11, 10, 45);

        Console.WriteLine(dt.ElapsedTime());

        string s1 = "Good monring dear students!";
        Console.WriteLine(s1.Cut(10));

        s1.All;
    }


}