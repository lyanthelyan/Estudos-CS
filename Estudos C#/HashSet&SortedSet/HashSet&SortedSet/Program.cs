internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();

        set.Add("TV");
        set.Add("Notebook");
        set.Add("Tablet");

        Console.WriteLine(set.Contains("Notebook"));

        foreach (var item in set)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        SortedSet<int> set2 = new SortedSet<int>() { 10, 2, 4, 5, 6, 8 };
        SortedSet<int> set3 = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

        PrintCollection(set2);

        //UNIÃO DE DOIS CONJUNTOS

        SortedSet<int> set4 = new SortedSet<int>(set2); //NÃO ACEITA REPETIÇÃO
        set4.UnionWith(set3);
        PrintCollection(set4);
        

        //INTERCEÇÃO
        SortedSet<int> set5 = new SortedSet<int>(set2);
        set5.IntersectWith(set3); //AQUELES ELEMENTOS QUE EXISTEM NOS DOIS CONJUNTOS, USANDO LISTA IRIA DAR UM TRABALHO, PQ TERIA QUE FICAR COMPARANDO
        PrintCollection(set5); 

        //DIFERENÇA
        SortedSet<int> set6 = new SortedSet<int>(set2);
        set6.ExceptWith(set3); //MOSTRA A DIFERENÇA ENTRE OS DOIS CONJUNTOS
        PrintCollection(set6);
    }

    static void PrintCollection<T>(IEnumerable<T> collection) //IEnumerable é uma interface que pega o enumerator, retorna um enumerator para que possa pecorrer a coleção
    {
        foreach (T item in collection)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}