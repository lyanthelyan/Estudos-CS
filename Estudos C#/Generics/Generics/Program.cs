using Generics.Entities;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("How many values: ");
        int n = int.Parse(Console.ReadLine());
        
        //Agora se eu quiser usar um programa que seja para string eu escolho o tipo
        PrintService<string> s = new PrintService<string>();

        for (int i = 0; i < n; i++)
        {
            string value =Console.ReadLine();
            s.AddValue(value);
        }

        s.Print();
        
        Console.WriteLine("First: "+s.First());
        Console.WriteLine("Last: " + s.Last());

    }
}