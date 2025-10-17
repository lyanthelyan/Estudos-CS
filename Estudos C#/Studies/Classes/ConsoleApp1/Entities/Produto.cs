

namespace ConsoleApp1.Entities
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }

        public Produto(){}
        
        public Produto(string nome, double preco, double quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() 
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public override string ToString()
        {
            return $"Produto: {Nome}\nPreço: {Preco}\nQuantidade: {Quantidade}";
        }
    }
}
