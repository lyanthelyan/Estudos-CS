using DelegPredicActionFunc.Entities;
internal class Program
{
    delegate void L();
    private static void Main(string[] args)
    {
        L lin = Linha;
        lin();

        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Predicate<int> maiorQueDois = n => n > 2;
        //Filtrar a lista
        List<int> maiorQueDoisLista = numbers.FindAll(maiorQueDois);
        
        Console.WriteLine("Lista");
        foreach (var item in numbers) { Console.Write(item+" "); }
        Console.WriteLine();
        Console.WriteLine("Lista maior que 2");
        foreach (var item in maiorQueDoisLista) { Console.Write(item+" "); }
        Console.WriteLine();

        lin();
        
        List<Produto> produtos = new List<Produto>
        {
            new Produto("Arroz", 20.5),
            new Produto("Feijão", 15.0),
            new Produto("Macarrão", 8.5),
            new Produto("Azeite", 25.0)
        };

        Predicate<Produto> predicateProdutosFiltrados = p => p.Preco > 10;
        List<Produto> produtosFiltrados = produtos.FindAll(predicateProdutosFiltrados);

        foreach (var item in produtosFiltrados)
        {
            Console.WriteLine($"Nome: {item.Nome} Preço: {item.Preco}");
        }
        lin();
        Action<Produto> imprimirProduto = p => Console.WriteLine($"Nome: {p.Nome} Preço: {p.Preco}");
        produtosFiltrados.ForEach(imprimirProduto);

        lin();
        Action<Produto> aplicarDesconto = p => Console.WriteLine($"Nome: {p.Nome} Preço {p.Preco -= p.Preco * 0.1}");
        produtosFiltrados.ForEach(aplicarDesconto);
        lin();

        Func<Produto, double> precoComDesconto = p => p.Preco * 1;
        
        foreach (var item in produtosFiltrados)
        {
            double precoDescontado = precoComDesconto(item);
            Console.WriteLine($"Nome: {item.Nome}, Preço com desconto: {precoDescontado}");
        }

        lin();

        List<Produto> meusProdutos = new List<Produto>()
        {
            new Produto("Tv", 530.00),
            new Produto("Lapis", 2.00),
            new Produto("Sofá", 1349.50),
            new Produto("Mesa", 250.99)
        };

        Predicate<Produto> meusProdutosAcimaDe300 = p => p.Preco > 300;
        List<Produto> meusProdutosFiltradoAcimaDe300 = meusProdutos.FindAll(meusProdutosAcimaDe300);

        Action<Produto> imprimirMeusProdutosFiltradosAcimaDe300 = p => Console.WriteLine($"Nome: {p.Nome}\nPreço: {p.Preco}\n");
        meusProdutosFiltradoAcimaDe300.ForEach(imprimirMeusProdutosFiltradosAcimaDe300);

        Func<Produto, double> descontoMeusProdutos = p => p.Preco -= p.Preco * 0.1;

        foreach (var item in meusProdutosFiltradoAcimaDe300)
        {
            double meusProdutosDescontando = descontoMeusProdutos(item);
            Console.WriteLine("Preço com desconto: "+meusProdutosDescontando);
        }



    }

    static void Linha()
    {
        Console.WriteLine("-----------------------------");
    }
}