
namespace ContributorsData.Entities
{
    abstract class Contributors
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Contributors(){}

        public Contributors(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
