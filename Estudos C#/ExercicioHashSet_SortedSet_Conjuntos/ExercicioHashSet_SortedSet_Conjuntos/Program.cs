internal class Program
{
    private static void Main(string[] args)
    {
        string sourcePath = @"C:\Users\T-GAMER\source\repos\NewRepo\hash.txt";

        HashSet<Log> logSet = new HashSet<Log>();
        HashSet<string> strings = new HashSet<string>();


       
        try
        {
            using (StreamReader sr = File.OpenText(sourcePath))
            {
                while (!sr.EndOfStream) // ! usando para enquanto não estiver no final do arquivo ele continuar lendo as linhas 
                {
                    string line = sr.ReadLine(); // Dividi por linhas
                    string[] parts = line.Split(' '); // Cada linha dei split usando o espaço como parametro
                    string name = parts[0]; //O primeiro espaço virou o name
                    DateTime date = DateTime.Parse(parts[1]); // O segundo depois do espaço virou a data
                    Log log = new Log(name, date); // Taquei na minha classe
                    logSet.Add(log); // Guardei em um conjunto hash os names e dates
                    
                    if (!strings.Contains(name)) //Se em strings não conter o mesmo nome ( usando o ! por isso reverte), ele vai adicionar, se conter já o mesmo nome ele não irá adicionar, evitando repetição
                    {
                        strings.Add(name);         // Guardei apenas os names nesse conjunto              
                    }
                }
                foreach (var logi in logSet)
                {
                    Console.WriteLine($"Name: {logi.Name}, Date: {logi.Date}");
                }
                Console.WriteLine("Total user: " + strings.Count()); // usei o count para mostrar quantos tem nessa lista hash
            }
            } catch (IOException e)
        {
            Console.WriteLine(" An error occurred: " + e.Message);
        }
    }

    class Log
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Log(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Date.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Log)) { return false; }
            Log other = obj as Log;
            return Name.Equals(other.Name) && Date.Equals(other.Date);
        }
    }
}