internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Users\T-GAMER\source\repos\NewRepo\Estudos C#\Directory\myFolder";
        string path2 = @"C:\Users\T-GAMER\source\repos\NewRepo\Estudos C#\Directory\myFolder\file1.txt";

        try
        {
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // *.*  Qualquer nome de arquivo, ponto, qualquer tipo
            //Console.WriteLine("Folders: ");
            foreach (string s in folders)
            {
                //Console.WriteLine(s); //C:\Users\T-GAMER\source\repos\NewRepo\Estudos C#\Directory\myFolder\docs
                //C: \Users\T - GAMER\source\repos\NewRepo\Estudos C#\Directory\myFolder\notes
            }

            IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // *.*  Qualquer nome de arquivo, ponto, qualquer tipo
            //Console.WriteLine("Files: ");
            foreach (string s in files)
            {
                //Console.WriteLine(s); //C: \Users\T - GAMER\source\repos\NewRepo\Estudos C#\Directory\myFolder\file1.txt
                //C: \Users\T - GAMER\source\repos\NewRepo\Estudos C#\Directory\myFolder\file2.txt
            }

            //CRIAR PASTA

            //Directory.CreateDirectory(path + @"\newfolder");
            //Directory.Delete(path + @"\newfolder");


            //PATH
            Console.WriteLine("Get Directory name: " + Path.GetDirectoryName(path2));
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("File Name: " + Path.GetFileName(path2));
            Console.WriteLine("File Name Without Extension: " + Path.GetFileNameWithoutExtension(path2));
            Console.WriteLine("Get Extension: " + Path.GetExtension(path2));
            Console.WriteLine("Get Full Path: " + Path.GetFullPath(path2));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());

        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

    }
}