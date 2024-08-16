using System.Security.Cryptography.X509Certificates;
using static Program;

internal class Program
{
    private static Motor motor;  // Variável global para armazenar a instância do Motor
    private static Carro meuCarro;
    private static void Main(string[] args)
    {

        criarCarro();
        meuCarro.LigarCarro();
    }
        // Exemplo 1
        public class Motor
    {
        public int Cilindrada { get; set; }
        public string Tipo { get; set; }

        public Motor(int cilindrada, string tipo)
        {
            Cilindrada = cilindrada;
            Tipo = tipo;
        }

        public void Ligar()
        {
            Console.WriteLine($"Motor do tipo {Tipo} ligado.");
        }
    }

    public static void criarMotor()
    {
        Console.WriteLine("Crie um motor!");
        Console.Write("Cilindros: ");
        int cilindros = int.Parse(Console.ReadLine());
        Console.Write("Tipo: [Mono], [Diesel], [Flex]: ");
        string tipoMotor = Console.ReadLine();
        Motor motor = new Motor(cilindros, tipoMotor);
    }
    public static void criarCarro()
    {
        criarMotor();
        Console.WriteLine("Crie um carro!");
        Console.Write("Marca: ");
        string marca = Console.ReadLine();
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();
        Carro meuCarro = new Carro(marca, modelo, motor);
    }
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Motor Motor { get; set; }  // Composição: Carro tem um Motor

        public Carro(string marca, string modelo, Motor motor)
        {
            Marca = marca;
            Modelo = modelo;
            Motor = motor;
        }

        public void LigarCarro()
        {
            Console.WriteLine($"Carro {Marca} {Modelo} está ligando...");
            Motor.Ligar(); // Chama o método Ligar do Motor
        }
    }
}
