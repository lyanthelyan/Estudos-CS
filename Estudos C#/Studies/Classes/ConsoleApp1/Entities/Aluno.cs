
namespace ConsoleApp1.Entities
{
    internal class Aluno : Pessoa
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
            return $"Nome: {Name}\nIdade: {Idade}\nNota:{Nota}";
        }

        public override void DefinirNota(double nota)
        {
            Nota = nota;
        }
    }
}
