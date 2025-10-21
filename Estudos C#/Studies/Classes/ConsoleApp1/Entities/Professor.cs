
namespace ConsoleApp1.Entities
{
    internal class Professor : Pessoa, IBonificavel
    {
        public double Salario { get; set; }

        public Professor()
        {
        }

        public Professor(string name, int idade, double salario) : base(name, idade)
        {
            Name = name;
            Idade = idade;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"Nome: {Name}\nIdade: {Idade}\nSalario:{Salario}\n";
            
        }

        public override void CalcularBonus()
        {
            Salario += 1;
        }

        public void CalcularBonusInterface()
        {
            Salario += 500; // exemplo: aplica bônus de 1 ponto
        }

    }
}
