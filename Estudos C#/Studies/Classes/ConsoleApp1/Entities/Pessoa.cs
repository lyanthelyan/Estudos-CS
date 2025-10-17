
namespace ConsoleApp1.Entities
{
    internal class Pessoa
    {
        public string Name { get; set; }
        public int Idade { get; set; }

        public Pessoa(){}

        public Pessoa(string name, int idade)
        {
            Name = name;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Name}\nIdade: {Idade}\n";
        }

        public virtual void DefinirNota(double nota){}
        
    }
}
