using ConsoleApp1.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno = new Aluno("Elyan", 23, 10);

        Console.WriteLine(aluno);
        Console.WriteLine();
        /*Pessoa pessoa = new Pessoa("Macaco", 23);*/
        /*Console.WriteLine(pessoa);*/

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
        Pessoa prof = new Professor("Leandro", 23, 1);
        
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

        foreach (var item in pessoas)
        {
            item.CalcularBonus();
        }


        Repositorio<Aluno> alunos2 = new Repositorio<Aluno>();
        Repositorio<Professor> professores2 = new Repositorio<Professor>();

        Aluno aluno3 = new Aluno("Elyan", 18, 8);
        Aluno aluno4 = new Aluno("Marcos", 20, 4.5);

        alunos2.Adicionar(aluno3);
        alunos2.Adicionar(aluno4);
        alunos2.ListarTodos();
        

        Professor professor1 = new Professor("Geovana", 22, 1500);
        Professor professor2 = new Professor("Gustavo", 23, 1300);

        professores2.Adicionar(professor1);
        professores2.Adicionar(professor2);
        professores2.ListarTodos();

        Console.WriteLine("*=**=**=**=**=**=**=**=**=**=*");

        List<IBonificavel> bonificaveis = new List<IBonificavel>();

        bonificaveis.Add(aluno4);
        bonificaveis.Add(professor1);

        foreach (var b in bonificaveis)
        {
            b.CalcularBonusInterface();
        }

        Console.WriteLine(aluno4);
        Console.WriteLine(professor1);

        Console.WriteLine("-----------------");

        Repositorio<IBonificavel> bonificavels =  new Repositorio<IBonificavel>();
        bonificavels.Adicionar(aluno3);
        bonificavels.Adicionar(professor2);

        foreach (var b in bonificavels.ListarTodos())
        {
            /*b.CalcularBonusInterface();*/
            Console.WriteLine(b);
        }

        Console.WriteLine("-----------------");
        
        bonificavels.AplicarBonusEmTodos();
        foreach (var item in bonificavels.ListarTodos())
        {
            Console.WriteLine(item);
        }



    }
}