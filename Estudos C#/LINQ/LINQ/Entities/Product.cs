namespace LINQ.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product() { }
        public Product(int id, string name, double price, Category Category)
        {
            Id = id;
            Name = name;
            Price = price;
            this.Category = Category;
        }

        public override string ToString()
        {
            return "ID: " + Id + 
                "\n" + "Name: " + Name +
                "\n" + "Price: " + Price.ToString("F2");
            
        }

    }
}
