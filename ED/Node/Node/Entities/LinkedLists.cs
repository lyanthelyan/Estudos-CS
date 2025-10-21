
namespace Node.Entities
{
    internal class LinkedLists<T>
    {
        private Node<T> Head { get; set; }

        public void AdicionarNoFim(T value)
        {
            Node<T> novoNode = new Node<T>();
            novoNode.Value = value;
            novoNode.Next = null;

            if(Head == null) //Se a lista estiver vazia, o novo nó se torna o primeiro elemento (Head)
            {
                Head = novoNode;
            }
            else // Caso a lista nao esteja vazia, precisamos acha o ultimo nó para ligar o novo nó
            {
                // Começamos a percorrer a lista a partir do Head
                Node<T> atual = Head;

                // Enquanto o próximo nó não for null, continue avançando
                // Isso significa que ainda não chegamos no último nó da lista
                while (atual.Next != null)
                    atual = atual.Next; // Avança para o próximo nó

                // Quando o while termina, 'atual' é o último nó da lista
                // Agora conectamos o novo nó ao final da lista
                atual.Next = novoNode;
            }
        }

        public void Remover(T value)
        {

            Node<T> anterior = Head;
            Node<T> atual = Head.Next;

            if (Head == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            // verifica se o Head contém o valor que queremos remover
            if (Head.Value.Equals(value))
            {
                // atualiza Head para o próximo nó
                // isso "desconecta" o primeiro nó da lista
                Head = Head.Next;

                // termina o método, pois o nó já foi removido
                return;
            }

            while(atual != null) // percorre até o final da lista
            {
                // verifica se o nó atual contém o valor a remover
                if (atual.Value.Equals(value))
                {
                    // desconecta o nó atual da lista
                    anterior.Next = atual.Next;

                    // nó removido, termina o método
                    return;
                }

                // se não encontrou o valor, avança para o próximo nó
                anterior = atual;
                atual = atual.Next;
            }


        }

        public void Exibir()
        {

            if (Head == null) 
            {
                Console.WriteLine("Lista vazia!");
                return;
            }

            Node<T> atual = Head;
            
            

            while (atual != null)
            {
                Console.WriteLine(atual.Value);
                atual = atual.Next;
            }

        }


    }
}
