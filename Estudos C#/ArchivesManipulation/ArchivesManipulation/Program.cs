using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string sourcePath = @"C:\Users\T-GAMER\source\repos\NewRepo\file1.txt";
        string targetPath = @"C:\Users\T-GAMER\source\repos\NewRepo\file2.txt";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }
        catch (IOException e)
        {
            Console.WriteLine("An Error Ocurred");
            Console.WriteLine(e.Message);
        }

    }
}