using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {/*
        List<int> numeros = new List<int>();
        Console.Write("Quantos números serão citados: ");
        int nums = int.Parse(Console.ReadLine());
        
        
        for (int i = 0; i < nums; i++)
        {
            Console.Write($"{i+1}: ");
            int num = int.Parse(Console.ReadLine());
            numeros.Add(num);
            
        }

        Console.WriteLine(string.Join(", ", numeros));
        Console.WriteLine();

        Console.WriteLine($"Maior número da lista: {numeros.Max()}");

        int maior = numeros[0];
        int menor = numeros[0];
        int indiceMaior = 0;
        int indiceMenor = 0;
        for (int i = 0;i < numeros.Count; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
                indiceMaior = i; // guarda a posição
            }

            if (numeros[i] < menor)
            {
                menor = numeros[i];
                indiceMenor = i; // guarda a posição
            }
        }
        Console.WriteLine(maior+", "+menor);
        
        Console.WriteLine($"Menor número da lista: {numeros.Min()}");
        double sum = 0;
        foreach (var item in numeros)
        {
            sum += item;
        }
        Console.WriteLine($"Média de números da lista: {sum / numeros.Count}");*/



        /*Console.Write("Peça um número para saber se ele é primo: ");
        double num = double.Parse(Console.ReadLine());

        bool EhPrimo = true;

        if (num < 1)
        {
            EhPrimo = false;
        }
        else
        {
            for (int i = 2; i < num; i++) 
            {
                if (num % i == 0)
                {
                    EhPrimo = false;
                    break;
                }
            }

        }
        if (EhPrimo)
        {
            Console.WriteLine($"{num} é primo!");
        }
        else
        {
            Console.WriteLine($"{num} não é primo!");
        }
*/
        /* Console.WriteLine("Escreva um texto");
         string txt = Console.ReadLine();
         List<char> vogais = new List<char> { 'a', 'e', 'i', 'o', 'u' };

         List<char> consoantes = new List<char>
         {
             'b', 'c', 'd', 'f', 'g', 'j', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z'
         };

         int cons = 0;
         int vog = 0;

         Console.WriteLine(txt);

         foreach (var item in txt.ToLower())
         {
             if (vogais.Contains(item)) 
             vog++;

         }

         foreach (var item in txt.ToLower())
         {
             if (consoantes.Contains(item)) 
             cons++;
         }

         *//*int vog = txt.Count(c => "aeiou".Contains(char.ToLower(c)));
         int cons = txt.Count(c => char.IsLetter(c) && !"aeiou".Contains(char.ToLower(c)));
 *//*
        Console.WriteLine("O texto tem " + vog + " vogais");
        Console.WriteLine("O texto tem " + cons + " consoantes");
*/

        Console.Write("Quantos números da sequência de Fibonacci você quer ver? ");
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        Console.WriteLine("Sequência de Fibonacci:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " "); // mostra o número atual
            int proximo = a + b;    // calcula o próximo
            a = b;                  // atualiza a
            b = proximo;            // atualiza b
        }
    }
}