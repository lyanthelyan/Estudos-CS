internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Quantas canetas para adicionar: ");
         int n = int.Parse(Console.ReadLine());
        Caneta[] canetas = new Caneta[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Caneta #" + (i+1));

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Console.Write("Cor: ");
            string cor = Console.ReadLine();
            Console.WriteLine();

            canetas[i] = new Caneta(modelo, cor);
        }

        foreach (var item in canetas)
        {
            Console.WriteLine($"Modelo: {item.Modelo}\nCor: {item.Cor}");
            Console.WriteLine();
        }

        Console.WriteLine(canetas[0].Modelo);


    }

    class Caneta
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }

        public Caneta(string modelo, string cor)
        {
            Modelo = modelo;
            Cor = cor;
        }
    }
}