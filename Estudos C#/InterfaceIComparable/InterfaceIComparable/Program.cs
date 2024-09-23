using InterfaceIComparable.Entities;
internal class Program

{
    private static void Main(string[] args)
    {
        string path = @"C:\Users\T-GAMER\source\repos\NewRepo\in.txt";

        try
        {
            using (StreamReader sr = File.OpenText(path)) 
            {
                List<Employee> list = new List<Employee>();
                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }
                
                list.Sort(); //Ordenou em Ordem Alfabetica
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp);
                }
            }
        }catch (IOException e)
        {
            Console.WriteLine("And error occurred");
            Console.WriteLine(e.Message);
        }
    }
}