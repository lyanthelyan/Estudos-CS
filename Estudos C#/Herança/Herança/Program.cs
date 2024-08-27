using Herança.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

        Console.WriteLine(account.Balance);

        //account.Balance = 500.00 Não irá funcionar pq está protegido
        account.Deposit(500); // Funciona adicionar mais Balance usando a função dentro da subclsse
        Console.WriteLine(account.Balance);
        BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // CLASSES ABSTRATAS
       
        // Account acc = new Account(1001, "Alex", 0); //Se a classe for abstrata, ela não pode ser instanciada
       List<Account> list = new List<Account>();
        list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
        list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
        list.Add(new SavingsAccount(1001, "Bob", 500.0, 0.01)); 
        list.Add(new BusinessAccount(1002, "Anna", 500.0, 500.0));
        // Se a classe Account mesmo sendo abstrada nao existisse, eu nao poderia misturar tipos diferentes em uma mesma lista
        double sum = 0;
        foreach (Account acc in list)
        {
            sum += acc.Balance;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //UPCASTING Conversao da subclasse para superclasse

        Account acc1 = bacc;
        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
        Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //DOWNCASTIG Conversao da superclasse para subclasse

        BusinessAccount acc4 = (BusinessAccount)acc2;
        acc4.Loan(100);
        //acc2.loan(100.0); Vai dar erro pq o Account nao tem a opercao Loan(), mesmo tendo estanciado
        //entao precisa dar um downcasting para funcionar.
        //BusinessAccount acc5 = (BusinessAccount)acc3; //O compilador nao ve o erro mas vai dar erro pq o acc3 é SavingsAccount, e não tem como fazer desse jeito
        if (acc3 is  BusinessAccount) {
            BusinessAccount acc5 = (BusinessAccount)acc3;
            acc5.Loan(100);
            Console.WriteLine("Loan");
        }
        if (acc3 is BusinessAccount) {
            SavingsAccount acc5 = (SavingsAccount)acc3;
            acc5.UpdateBalance();
            Console.WriteLine("Update! ");
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //SOBREPOSICAO  CONTA COMUM É COBRADA UMA TAXA DE 5.00    CONTA POUPANCA NAO COBRA A TAXA
         Account conta1 = new Account(1001, "Fabio", 500.0); // CONTA COMUM
        Account conta2 = new SavingsAccount(1002, "Ana", 500.0, 0.01); // CONTA POUPANCA

        conta1.WithDraw(10.0);
        conta2.WithDraw(10.0);

        Console.WriteLine(conta1.Balance); // 485
        Console.WriteLine(conta2.Balance); // 490 Utilizando o Override para nao descontar os 5
        Console.WriteLine(conta2.Balance); // 483 Utilizando o Override Base para descontar 5 e aproveitando esse metodo descontar mais 2 no savingsaccount

    }
}
