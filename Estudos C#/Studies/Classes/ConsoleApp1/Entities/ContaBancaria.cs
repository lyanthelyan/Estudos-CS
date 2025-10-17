
namespace ConsoleApp1.Entities
{
    internal class ContaBancaria
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Sacar (double valor) 
        {
             Saldo = Saldo - valor;
        }

        public override string ToString()
        {
            return $"Titular: {Titular}\nSaldo: {Saldo}";
        }
    }
}
