
namespace ConsoleApp1.Entities
{
    internal class Aluno : Pessoa, IBonificavel
    {
        public double Nota { get; set; }

        public Aluno()
        {
           
        }

        public Aluno(double nota)
        {
            Nota = nota;
        }
        
        public Aluno(string Nome, int Idade, double nota) : base(Nome, Idade)
        {
            Nota = nota;
        }

        public override string ToString()
        {
            return $"Nome: {Name}\nIdade: {Idade}\nNota:{Nota}\n";
        }

        public override void DefinirNota(double nota)
        {
            Nota = nota;
        }

        public override void CalcularBonus()
        {
            Nota += 1;
        }
        public void CalcularBonusInterface()
        {
            Nota = Nota + 1; // exemplo: aplica bônus de 1 ponto
        }
    }
}
