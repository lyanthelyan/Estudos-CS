using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();

        set.Add("TV");
        set.Add("Notebook");
        set.Add("Tablet");

        Console.WriteLine(set.Contains("Notebook"));

        foreach (var item in set)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        SortedSet<int> set2 = new SortedSet<int>() { 10, 2, 4, 5, 6, 8 };
        SortedSet<int> set3 = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

        PrintCollection(set2);

        //UNIÃO DE DOIS CONJUNTOS

        SortedSet<int> set4 = new SortedSet<int>(set2); //NÃO ACEITA REPETIÇÃO
        set4.UnionWith(set3);
        PrintCollection(set4);


        //INTERCEÇÃO
        SortedSet<int> set5 = new SortedSet<int>(set2);
        set5.IntersectWith(set3); //AQUELES ELEMENTOS QUE EXISTEM NOS DOIS CONJUNTOS, USANDO LISTA IRIA DAR UM TRABALHO, PQ TERIA QUE FICAR COMPARANDO
        PrintCollection(set5);

        //DIFERENÇA
        SortedSet<int> set6 = new SortedSet<int>(set2);
        set6.ExceptWith(set3); //MOSTRA A DIFERENÇA ENTRE OS DOIS CONJUNTOS
        PrintCollection(set6);

        Console.WriteLine();
        Console.WriteLine("=-=-=-=-HASHSET NOVA AULA -=-=-=-=");
        Console.WriteLine();

        HashSet<string> set7 = new HashSet<string> { "Macaco", "Gustavo" };
        //Como as coleções Hash testam igualdade?'
        //Se GetHashCode e Equals estiverem implementados:
        Console.WriteLine(set7.Contains("Macaco")); // ELe vai usar o procedimento de testar se o HashCode do Macaco estiver dentro da lista hashset, ele vai usar o equals
                                                    //Para ver se o elemento estar la dentro
                                                    //A classe string ja tem uma implementação ja tem GetHashCode e Equals

        //Se GetHashCode e Equals NÃO ESTIVEREM IMPLEMENTADOS:
        // Vai acontecer uma comparação referencia ou tipo valor

        HashSet<Product> a = new HashSet<Product>();

        a.Add(new Product("TV", 900.0));
        a.Add(new Product("Notebook", 1200.0));

        HashSet<Point> b = new HashSet<Point>();

        b.Add(new Point(3, 4));
        b.Add(new Point(5, 10));

        Product prod = new Product("Notebook", 1200.0);
        //Deu falso, ele comparou as referencias, mas quando deu um new product pro, ele criou outra referencia de memoria, mesmo que A e Prod tenha os mesmos produtos
        //A referencia é diferente
        //Console.WriteLine(a.Contains(prod)); // Deu falso
        //Agora vamos implemetnar um gethashcode e equals na calsse product
        Console.WriteLine(a.Contains(prod)); //Deu verdadeiro pq mudamos a regra do equals e hashcode para comparar os produtos 
        //Mesmo sendo uma referencia diferente, o conteudo é igual

        Point p = new Point(5, 10);
        Console.WriteLine(b.Contains(p)); // Mesmo não tendo implementado o getshashcode e equals ele deu true por que o tipo valor ja tem implementado dentro da classe
        //E como struct é tipo valor e não referencia, a comparação foi para o conteudo e nao para a referencia dos objetos

    }

    class Product 
    {
        public string Name { get; set; }
        public double Price {get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        //Implementando Equals e GetHashCode depois da comparação Console.WriteLine(a.Contains(prod)); Ter dado falso
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode(); //Ao somar os dois valores, você gera um código de hash combinado que tenta representar as duas propriedades.
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product)){ return false; }
            Product other = obj as Product;//Neste caso, a verificação anterior garante que obj é um Log, então não precisamos nos preocupar com null aqui.
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }

    struct Point // Stuct é tipo valor
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    static void PrintCollection<T>(IEnumerable<T> collection) //IEnumerable é uma interface que pega o enumerator, retorna um enumerator para que possa pecorrer a coleção
    {
        foreach (T item in collection)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
