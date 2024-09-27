internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> cookies = new Dictionary<string, string>();
        cookies["User"] = "Maria";
        cookies["Email"] = "maria@gmail.com";
        cookies["Phone"] = "9991827374";
        cookies["Phone"] = "2231213456";

        Console.WriteLine(cookies["User"]);

        foreach (var item in cookies)
        {
            Console.WriteLine(item);
        }

        foreach (KeyValuePair<string,string> item in cookies)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}