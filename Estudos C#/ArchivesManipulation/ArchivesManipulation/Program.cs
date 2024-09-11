using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string sourcePath = @"C:\Users\T-GAMER\source\repos\NewRepo\file1.txt";
        string targetPath = @"C:\Users\T-GAMER\source\repos\NewRepo\file2.txt";
        FileStream fs = null;
        StreamReader sr = null;
        try
        {

            /*FileInfo fileinfo = new FileInfo(sourcePath);
            fileinfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }*/

            //-------------------------------------------------------------------------------------------------------------
            // ABRING

            //  fs = new FileStream(sourcePath, FileMode.Open);
            // sr = File.OpenText(sourcePath); //RESUMIDA
            //sr = new StreamReader(fs); 
            /*Console.WriteLine(sr.ReadToEnd());*/
        }
        catch (IOException e)
        {
            Console.WriteLine("An Error Ocurred");
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (sr != null) sr.Close();
            if (fs != null) fs.Close();
        }
            //----------------------------------------------------------------------------------------------
            //USING FECHA AUTOMATICAMENTE O ARQUVIO

            //using (sr = File.OpenText(sourcePath))
            // {
            // Console.WriteLine(sr.ReadToEnd());
        //}
        
        // STREAM WRITER

        try
        {
            using (StreamWriter sw = File.AppendText(sourcePath))
            {
                sw.WriteLine("Good Night");
            }
            using (sr = File.OpenText(sourcePath))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        catch
        {

        }
    }
}