
using Node.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        LinkedLists<int> linkedLists = new LinkedLists<int>();
        linkedLists.AdicionarNoFim(10);
        linkedLists.AdicionarNoFim(5);
        linkedLists.AdicionarNoFim(20);

        linkedLists.Exibir();

        Console.WriteLine("------------------------------");
        linkedLists.Remover(5);

        linkedLists.Exibir();


    }
}