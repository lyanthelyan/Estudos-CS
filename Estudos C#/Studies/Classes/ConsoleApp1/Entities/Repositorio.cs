

namespace ConsoleApp1.Entities
{
    internal class Repositorio<T> where T : IBonificavel
    {
        private List<T> minhaLista = new List<T>();

        public Repositorio()
        {
            minhaLista = new List<T>();
        }

        public void Adicionar(T item)
        {
            minhaLista.Add(item);
        }

        public void Remover(T item)
        {
            minhaLista.Remove(item);
        }

        public List<T> ListarTodos()
        {
            return minhaLista;
        }

        public void AplicarBonusEmTodos()
        {
            foreach (var item in minhaLista)
            {
                item.CalcularBonusInterface();
            }
        }
    }
}
