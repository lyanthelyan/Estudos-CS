using System.Reflection.Metadata.Ecma335;

internal class Program
{
    delegate double Comparador(double n1, double n2);
    delegate void Print(string value);


    private static void Main(string[] args)
    {
        Print print = Printar;
        print.Invoke("EXERCICIO 1");
        Console.WriteLine("Crie um delegate que recebe dois números inteiros e retorna o maior deles.//Depois, use esse delegate para comparar dois números em diferentes cenários.");
        Console.WriteLine();

        Comparador comp = Max;
        Console.WriteLine(comp(3, 10));

        //-----------------------------------------------------------------------------------------------------------------------------------------------
        print.Invoke("EXERCICIO 2");
        Console.WriteLine("Crie uma lista de números inteiros e use o Predicate para filtrar apenas os números pares.");
        Console.WriteLine();

        List<int> list = new List<int>
        {
            1,3,4,5,6,7,8,9,10,11,12
        };


        Predicate<int> evenNumber = ev => ev % 2 == 0;
        List<int> even = list.FindAll(evenNumber);
                                                    //EvenNumber Metodo que eu criei também funciona


        foreach (var item in even)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
        Console.WriteLine();

        //-----------------------------------------------------------------------------------------------------------------------------------------------
        print.Invoke("EXERCICIO 3");
        Console.WriteLine("Use o Action para realizar operações matemáticas (como soma, subtração, multiplicação) em dois números.");
        Console.WriteLine();

        Action<int, int> SomaLambda = (n1, n2) => { Console.WriteLine(n1 + n2); };
        Console.Write("Soma: ");
        Action<int, int> action;
        action = Sum;
        action(10, 5);

        Action<int, int> DivisaoLambda = (n1, n2) => { Console.WriteLine(n1 / n2); };
        Console.Write("Divisão: ");
        action = Div;
        action(10, 5);

        Action <int, int> MultiplicacaoLambda = (n1,n2) => { Console.WriteLine(n1 * n2); };
        Console.Write("Multiplicação: ");
        action = Multi;
        action(10, 5);
        Console.WriteLine();
        //---------------------------------------------------------------------------------------------------------------------------------------------------
        print.Invoke("EXERCICIO 4");
        Console.WriteLine("Crie funções usando Func para calcular a área de um círculo e um retângulo.");

        Func<double, double> myFunc = AreaCirculo;
        Func<double, double> myFuncLambdaCirculo = raio => Math.PI * raio * raio;
        
        Console.WriteLine("Area Circulo: "+myFunc(5).ToString("F2"));

        Func<double, double, double> myFuncLambda = (largura, altura) => largura * altura;
        Func<double, double, double> myFunc2 = AreaRetangulo;
        Console.WriteLine("Area Retangulo: "+myFunc2(5,10));


    }

    public static void Printar(string value)
    {
        Console.WriteLine($"-=-=-=-=-=-=-=-={value}-=-=-=-=-=-=-=-=");
    }

    public static double Max(double n1, double n2)
    {
        return (n1 > n2) ? n1 : n2;
    }

    public static bool EvenNumber(int n)
    {
        return n % 2 == 0;
    }
    public static void Sum(int n1, int n2) { Console.WriteLine(n1 + n2); }
    public static void Div(int n1, int n2){ Console.WriteLine(n1 / n2); }
    public static void Multi(int n1, int n2) { Console.WriteLine(n1 * n2); }

    public static double AreaRetangulo(double value1, double value2)
    {
        return value1 * value2;
    }

    public static double AreaCirculo( double value2)
    {
        return Math.PI * Math.Pow(value2, 2);
    }
}
