using Exercicio_HashSet_SortedSet_Professor.Entities;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Users\T-GAMER\source\repos\NewRepo\hash.txt";
        
        HashSet<LogRecord> records = new HashSet<LogRecord>(); // Por que nao usar o sortedset? porque a ordem do arquivo nao importa entao vamos usar o conjunto mais rapido
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    string username =  line[0];
                    DateTime instant = DateTime.Parse(line[1]);
                    records.Add(new LogRecord(username, instant)); // Se eu tentar adicionar um logrecord de um usuario repetido pq a gente implementou o equals e o hashcode baseado no username                   
                }
                foreach (LogRecord item in records)
                {
                    Console.WriteLine(item.Username + " " + item.Instant);
                }
                Console.WriteLine("Total user: " + records.Count());
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }


}