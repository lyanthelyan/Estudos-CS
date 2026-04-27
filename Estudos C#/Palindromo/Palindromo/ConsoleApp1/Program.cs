

using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPalindromo("A r a r a"));
        }

        new static bool isPalindromo(string input)
        {
            input = input.ToLower().Replace(" ", "");
            string inverse = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                inverse += input[i];
            }

            return inverse == input;

        }

    }
}
