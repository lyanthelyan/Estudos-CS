namespace Herança.Entities
{
    internal class BusinessAccount : Account // BusinessAccount herdando as propriedades do Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }
        
        //Ao inves de escrever todas as Associações novamente, utiliza-se base para referenciar a eles do contrutor account
        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
