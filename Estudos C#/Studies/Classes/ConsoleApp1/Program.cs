using ConsoleApp1.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno = new Aluno("Elyan", 23, 10);

        Console.WriteLine(aluno);
        Console.WriteLine();
        Pessoa pessoa = new Pessoa("Macaco", 23);
        Console.WriteLine(pessoa);

        ContaBancaria contaBancaria = new ContaBancaria("Elyan", 245.40);
        Console.WriteLine(contaBancaria);
        Console.WriteLine();

        contaBancaria.Depositar(100);
        Console.WriteLine(contaBancaria);
        Console.WriteLine();
        contaBancaria.Sacar(50);
        Console.WriteLine(contaBancaria);
        Console.WriteLine(new string('=', 20));
        Produto produto = new Produto();

        produto.Nome = "Tv";
        produto.Preco = 500;
        produto.Quantidade = 10;
        Console.WriteLine(produto);
        Console.WriteLine(new string('=', 20));
        produto.AdicionarProdutos(100);
        Console.WriteLine(produto);
        Console.WriteLine(produto.ValorTotalEmEstoque());

        List<Animal> animais =  new List<Animal>();

        animais.Add(new Cachorro());
        animais.Add(new Gato());

        foreach (var item in animais)
        {
            Console.WriteLine(item.EmitirSom());
        }

        Animal animal = new Cachorro();
        Console.WriteLine(animal.EmitirSom());
        Console.WriteLine(new string('=', 20));
        Pessoa alun = new Aluno(10);
        Pessoa prof = new Professor("Leandro", 23);
        
        List<Pessoa> pessoas  = new List<Pessoa>{alun, prof};

        foreach (var p in pessoas)
        {
            if (p is Aluno a)
            {
                Console.WriteLine(a.Nota);
            }

            if (p is Professor pro)
            {
                Console.WriteLine(pro.Name + ", " +pro.Idade);
            }
        }

        alun.DefinirNota(7);

        foreach (var item in pessoas)
        {
            if (item is Aluno a1)
            {
                Console.WriteLine(a1.Nota);
            }

        }





    }
}