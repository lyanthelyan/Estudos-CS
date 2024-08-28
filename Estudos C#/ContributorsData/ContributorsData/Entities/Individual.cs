namespace ContributorsData.Entities
{
    internal class Individual : Contributors
    {
        public double  HealthExpenditure { get; set; }

        public Individual() { }

        public Individual(string name,double anualIncome, double healthExpenditure)
            :base (name, anualIncome)
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double Tax()
        {
            double tax = 0;
            if (AnualIncome < 20000.00)
            {
                 tax = (AnualIncome * 0.15) - (HealthExpenditure * 0.50);
            }
            else if (AnualIncome >= 20000.00)
            {
                tax = (AnualIncome * 0.25) - (HealthExpenditure * 0.50);

            }
            return tax;
        }
    }
}
