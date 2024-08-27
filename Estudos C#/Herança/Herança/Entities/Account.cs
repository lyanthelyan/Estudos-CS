namespace Herança.Entities
{
    abstract class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }//Protected só pode ser alterado dentro da classe(Account)
                                                       //Ou da subclasse(BusinessAccount)

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDraw(double amount) // Taxa de 5.0   .Virtual significa que ele pode ser sobrescrito nas subclasses
        {
            Balance -= amount + 5.0;
        }
        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
