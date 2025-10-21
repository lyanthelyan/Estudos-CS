using ListsManipulation.Entities;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> nameSet = new HashSet<string>();
        nameSet.Add("Elyan");
        nameSet.Add("Marcos");
        nameSet.Add("Gustavo");
        foreach (var item in nameSet)
        {
            Console.WriteLine(item);
        }
        
        Linha();
        
        SortedSet<string> sortednameSet = new SortedSet<string>(nameSet);
        foreach (var item in sortednameSet) 
        {
            Console.WriteLine(item);
        }

        Linha();

        Dictionary<string, double> produtos = new Dictionary<string, double>();
        produtos.Add("Arroz", 20.5);
        produtos.Add("Feijão", 15.0);
        produtos.Add("Macarrão", 8.5);

        /*Console.Write("Quantos produtos você quer adicionar?: ");
        int n = int.Parse(Console.ReadLine());

        for ( int i = 0; i < n; i++)
        {
            Console.Write("Qual o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Qual o valor do produto: ");
            double valorProduto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            produtos.Add(nomeProduto, valorProduto);
            Console.WriteLine();
        }

        ListarProdutos(produtos);*/

        

        List<Produto> produtos1 = new List<Produto>()
        {
            new Produto("Arroz", 5.99),
            new Produto("Feijão", 15.0),
            new Produto("Macarrão", 6.0),
            new Produto("Azeite", 25.50)

        };

        var filtrarPorPreco = produtos1.Where(p => p.Preco > 10);

        var filtrarPorNome = produtos1.OrderBy(p => p.Nome);

        double mediaProdutos = produtos1.Average(p => p.Preco);

        foreach (var item in produtos1)
        {
            Console.WriteLine($"{item.Nome}\n{item.Preco}");
            Console.WriteLine();
        }

        Linha();
        Console.WriteLine("Maior que 10.00");
        foreach (var item in filtrarPorPreco)
        {
            
            Console.WriteLine($"{item.Nome}\n{item.Preco}");
            Console.WriteLine();
        }

        Linha();
        Console.WriteLine("Por nome");
        foreach (var item in filtrarPorNome)
        {
            Console.WriteLine($"{item.Nome}\n{item.Preco}");
            Console.WriteLine();
        }

        Linha();
        Console.WriteLine(mediaProdutos);

    }

    public static void ListarProdutos(Dictionary<string, double> produto)
    {
        foreach (var item in produto)
        {
          Console.WriteLine($"Produto: {item.Key}\nPreço: {item.Value}\n");
        }
    }

    public static void Linha()
    {
        Console.WriteLine("----------------------------------------");
    }
}