using GetHashCode_Equals;
internal class Program
{
    private static void Main(string[] args)
    {
        string a = "Alex";
        string b = "Maria";
        string c = "Matheus";
        string d = "Matheus";

        Console.WriteLine(a.ToUpper().Equals(b.ToUpper()));
        Line();
        Console.WriteLine(a.GetHashCode());
        Console.WriteLine(b.GetHashCode());
        Line();
        Console.WriteLine(c.GetHashCode());
        Console.WriteLine(d.GetHashCode());
        Line();

        Client client1 = new Client { Name = "Maria", Email = "maria@gmail.com"};
        Client client2 = new Client { Name = "Alex", Email = "alex@gmail.com" };

        Console.WriteLine(client1.Equals(client2));
        Console.WriteLine(client1 == client2); // Compara referencia de objetos
        Console.WriteLine(client1.GetHashCode());
        Console.WriteLine(client2.GetHashCode());

    }

    public static void Line()
    {
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    }
}