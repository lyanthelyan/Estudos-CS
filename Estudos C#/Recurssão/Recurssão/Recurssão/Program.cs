using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Sources;

internal class Program
{
    private static void Main(string[] args)
    {
        
        
        Console.WriteLine("----------------------");
        Console.WriteLine(Somar(5));
        Console.WriteLine("----------------------");
        Console.WriteLine(Subtrair(5));

    }

    public static int Somar(int n)
    {
        if (n == 0) return 0;
        Console.WriteLine(n);
        return n + Somar(n - 1);
    }

    public static int Subtrair(int n)
    {
        if (n == 0) return 0;
        Console.WriteLine(n);
        return n - Subtrair(n - 1);
    }
    


    
}