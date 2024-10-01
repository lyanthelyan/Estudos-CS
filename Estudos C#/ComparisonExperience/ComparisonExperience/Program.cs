using ComparisonExperience.Entities;
using System.Diagnostics;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("TV", 900.00));
        list.Add(new Product("Notebook", 1200.00));
        list.Add(new Product("Tablet", 450.00));

        /*Aqui utilizei o IComparable para organizar por nome, como está na classe Product
         Mas e se eu quiser ordernar por PREÇO ?:
         Para evitar de abrir a classe e mudar o critério de comparação sempre que o critério mudar vamos usar da 
        PROGRAMAÇÃO FUNCIONAL: Vamos mudar o critério da comparação sem mudar a classe*/
        // list.Sort();

        list.Sort(ComparaProducts); // Delegate, referencia para uma função'
        Comparison<Product> comp = (p1,p2)=> p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); // Função Lambda

        list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // Função lambda também funciona
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    static int ComparaProducts(Product p1, Product p2)
    {
        return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
    }

}