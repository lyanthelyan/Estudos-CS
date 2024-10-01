using Delegates.Entities;
using Delegates.Services;

internal class Program
{
    delegate void Print(string a);
    delegate double BinaryNumericOperation(double n1);
    delegate void BiNumericOperation(double n1, double n2);

    private static void Main(string[] args)
    {
        double a = 10;
        double b = 12;

        BinaryNumericOperation op = CalculationServices.Square; // TRATAR METODO COMO VARIVAL

        BiNumericOperation opn = CalculationServices.ShowSum;
        opn += CalculationServices.ShowMax;    // Agora meu delegate guarda a variavel referencial para duas funções '

        double result = CalculationServices.Max(a, b);
        //invoke invoca o metodo delegate, ele dispara o evento
        opn.Invoke(a, b); // Aqui o output foi 22,12 pq ele mostrou a soma primeiro e depois o max, ja que meu opn tem dois metodos guardados, ele executou os dois

        Console.WriteLine(op(a));

        //---------------------------------------------------------------------------------PREDICATE---------------------------------------------------------------------------------
        Print bb = PrintLine;
        bb.Invoke("PREDICATE");
        // Fazer um programa que, a partir de uma lista de produtos, remova da lista somente aqueles cujo preço mínimo seja 100.
        //Exemplo com RemoveAll
        List<Product> products = new List<Product>();

        products.Add(new Product("Tv", 900.00));
        products.Add(new Product("Mouse", 50.00));
        products.Add(new Product("Tablet", 350.50));
        products.Add(new Product("HD Case", 80.90));

        products.RemoveAll(ProductTest); //RemoveAll tem como argumento um Predicate
        // Usando lambda
        // products.RemoveAll(p = p.Price >= 100.0);


        foreach (var item in products)
        {
            Console.WriteLine(item);
        }

        //---------------------------------------------------------------------------------ACTION---------------------------------------------------------------------------------
        bb.Invoke("ACTION");
        //Exemplo com ForEach
        //Fazer um programa que, a partir de uma lista de produtos, aumente o pre;o dos produtos em 10%

        List<Product> products2 = new List<Product>();

        products2.Add(new Product("Tv", 900.00));
        products2.Add(new Product("Mouse", 50.00));
        products2.Add(new Product("Tablet", 350.50));
        products2.Add(new Product("HD Case", 80.90));

        // products2.ForEach(UpdatePrice);   //ForEach recebe um action, esse ForEach é um metodo de lista
        Action<Product> actionProduct = UpdatePrice;
        products2.ForEach(actionProduct);

        //Lambda
        Action<Product> actionProductLambda = p => { p.Price += p.Price * 0.1; };
        foreach (var item in products2)
        {
            // item.Price += item.Price * 0.10;
            Console.WriteLine(item);
        }

        //---------------------------------------------------------------------------------FUNC---------------------------------------------------------------------------------
        bb.Invoke("FUNC");

        // Fazer um programa que, a patir de uma lista de produtos, gere uma nova lista contendo os nomes dos produtos em caixa alta
        List<Product> products3 =
        [
            new Product("Tv", 900.00),
            new Product("Mouse", 50.00),
            new Product("Tablet", 350.50),
            new Product("HD Case", 80.90),
        ];

        Func<Product, string> myFunc = UpdateName;
        //lambda
        //Func<Product, string> myFunc = p => p.Name.ToUpper();

        List<string> res = products3.Select(myFunc).ToList(); // So fiz a conversao to list pq Select utiliza um conjunto IEnumerable
                                                               //UpdateName
                                                               //p=> p.Name.ToUpper(); Se eu colocar chaves como no action eu teria que colocar o return, pq a expressão iria esperar o comando
        foreach (var item in res)
        {
            Console.WriteLine(item);
        }


    }

    public static string UpdateName(Product p)
    {
        return p.Name.ToUpper();
    }

    public static void UpdatePrice(Product p)
    {
        p.Price += p.Price * 0.1;
    }

    public static void PrintLine(string value)
    {
        Console.WriteLine("-=-=-=-=-=-=-=-" + value + "-=-=-=-=-=-=-=-");
    }

    public static bool ProductTest(Product p)
    {
        return p.Price >= 100.0;
    }
}