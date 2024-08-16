internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Type the sequence for Fibonacci: ");
        int sequence = int.Parse(Console.ReadLine());

        int firstNumber = 0; int secondNumber = 1; int nextNumber = 0;

        for (int i = 0; i < sequence; i++)
        {
            if (i <= 1)
            {
                nextNumber = i; // Enquanto i (0) menor igual ao 1, o proximo numero vai receber i
            }
            else
            {
                nextNumber = firstNumber + secondNumber; //Calculo para realizar a soma da sequencia
                firstNumber = secondNumber; // Calculo para os numeros calculaveis ir para frente da sequencia
                secondNumber = nextNumber;
            }
            Console.Write(nextNumber + " ");
        }

    }
}