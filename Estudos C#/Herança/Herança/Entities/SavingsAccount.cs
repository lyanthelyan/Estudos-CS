namespace Herança.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        //public override void WithdDraw(double amount) // Taxa era de  5.0   Mas estamos sobrescrevendo na savings account para que ela funcione diferentemente nessa classe
        // {
        //    Balance -= amount;
        //}

        public override void WithDraw(double amount)//A taxa da conta poupança é 5, mais 2.0, aproveitando a implementação da taxa de 5 e simplementes descontando mais 2 reais
            //Utiliza-se o base, aproveitando
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }

        public sealed override void Deposit(double amount)//Essa opercao nao pode ser sobescrita novamente numa outra subclass, pq ela esta sealed
        {
            Balance += amount;
        }
    }
}
