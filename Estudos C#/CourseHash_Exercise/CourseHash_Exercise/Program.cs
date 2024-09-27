using CourseHash_Exercise.Entitites;

internal class Program
{
    private static void Main(string[] args)
    {

        HashSet<Student> students = new HashSet<Student>();

        Console.Write("How many students for course A: ");
        int c1 = int.Parse(Console.ReadLine());
        for (int i = 0; i < c1; i++)
        {
            int codeA = int.Parse(Console.ReadLine());
            students.Add(new Student(codeA));
        }

        Console.Write("How many students for course B: ");
        int c2 = int.Parse(Console.ReadLine());
        for (int i = 0; i < c2; i++)
        {
            int codeB = int.Parse(Console.ReadLine());
            students.Add(new Student(codeB));
        }

        Console.Write("How many students for course C: ");
        int c3 = int.Parse(Console.ReadLine());
        for (int i = 0; i < c3; i++)
        {
            int codeC = int.Parse(Console.ReadLine());
            students.Add(new Student(codeC));
        }

        Console.WriteLine("Total students: " + students.Count());
    }
}