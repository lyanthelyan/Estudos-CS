internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\Users\T-GAMER\source\repos\NewRepo\candidates.txt";
        Dictionary<string, int> dic = new Dictionary<string, int>();
        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] parts = line.Split(", ");
                    string name = parts[0];
                    int votes = int.Parse(parts[1]);

                    if (dic.ContainsKey(name))
                    {
                        dic[name] += votes; // se o nome ja existir ele vai pegar os votos atuais e vai somar com a entrada de novos votos
                    }
                    else
                    {
                        dic[name] = votes; // name é a chave e votes é o valor então o name alex recebe o valor de 72 votos
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        foreach (var item in dic)
        {
            Console.WriteLine(item);
        }
    }
}