using System.Globalization;

namespace ComparisonExperience.Entities 
{
    // Tirando a implementação do IComparable'
    //internal class Product : IComparable<Product>
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString() 
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        //Tirando a implementação do CompareTo'
        /*public int CompareTo(Product other)
        {
            return Name.ToUpper().CompareTo(other.Name.ToUpper());
        }*/
    }
}
