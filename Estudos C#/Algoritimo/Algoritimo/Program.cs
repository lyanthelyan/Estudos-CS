using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Algoritimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Two Sum
            //Dado um array de inteiros e um número alvo, encontre dois índices cujos valores somam o alvo.
            //Exemplo:

            //nums = [2, 7, 11, 15]
            //target = 9
            //saída: [0, 1]

            int[] num = { 2, 7, 11, 15 };

            int target = 13;
            
            //int target = int.Parse(Console.ReadLine());
            Dictionary<int,int> dicionario = new Dictionary<int,int>();

            for (int i = 0; i < num.Length; i++)
            {
                int falta = target - num[i];
                if (dicionario.ContainsKey(falta))
                {
                    int indiceAntigo = dicionario[falta];
                    Console.WriteLine(indiceAntigo + " " + i);

                }
                else
                {
                    dicionario.Add(num[i], i);
                }
                
            }

        }
    }
}
