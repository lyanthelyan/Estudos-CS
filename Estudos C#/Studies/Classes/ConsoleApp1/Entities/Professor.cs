
namespace ConsoleApp1.Entities
{
    internal class Professor : Pessoa, IBonificavel
    {
        public double Salario { get; set; }

        public Professor()
        {
        }

        public Professor(string name, int idade) : base(name, idade)
        {
            Name = name;
            Idade = idade;
        }

        public override void CalcularBonus()
        {
            Salario += 1;
        }

        public void CalcularBonusInterface()
        {
            Salario += 1; // exemplo: aplica bônus de 1 ponto
        }

    }
}
