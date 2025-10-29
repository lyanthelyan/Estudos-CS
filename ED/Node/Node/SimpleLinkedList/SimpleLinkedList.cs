using Node.SimpleLinkedList;
using System.Security;

namespace Node.SimpleLinkedList
{
    internal class SimpleLinkedList<T>
    {
        // Head aponta para o primeiro nó da lista
        private Node<T> Head { get; set; }

        // Inserir no final da lista (PushBack)
        public void PushBack(T data)
        {
            // Criamos um novo nó
            Node<T> newNode = new Node<T>();
            newNode.Data = data;    // Definimos o valor do nó
            newNode.Next = null;      // O próximo é null, pois será o último nó

            // Se a lista estiver vazia, Head aponta para o novo nó
            if (Head == null) { Head = newNode; }
            else
            {
                // Criamos uma referência temporária para percorrer a lista
                Node<T> current = Head;

                // Enquanto o próximo nó não for null, continuamos avançando
                while (current.Next != null)
                {
                    current = current.Next; // Avança para o próximo nó
                }

                // Quando chegar no último nó, conectamos o novo nó
                current.Next = newNode;
            }
        }

        // Inserir no início da lista (PushFront)
        public void PushFront(T data)
        {
            // Criamos o novo nó
            Node<T> newNode = new Node<T>();
            newNode.Data = data;

            // O novo nó aponta para o antigo head
            newNode.Next = Head;

            // Atualizamos Head para apontar para o novo nó
            Head = newNode;
        }

        // Inserir em uma posição específica
        public void InsertAt(int position, T data)
        {
            // Criamos o novo nó
            Node<T> newNode = new Node<T>();
            newNode.Data = data;

            // Se a posição for 0, é igual ao PushFront
            if (position == 0)
            {
                newNode.Next = Head; // Novo nó aponta para o antigo head
                Head = newNode;      // Atualizamos Head
                return;
            }

            // Criamos uma referência para percorrer até o nó anterior à posição
            Node<T> current = Head;
            for (int i = 0; i < position - 1; i++)
            {
                // Se chegarmos ao final antes da posição, posição inválida
                if (current == null)
                {
                    Console.WriteLine("Posição inválida!");
                    return;
                }
                current = current.Next; // Avançamos
            }

            // Atualizamos referências para inserir o novo nó
            newNode.Next = current.Next; // Aponta para o nó que estava na posição
            current.Next = newNode;      // Nó anterior aponta para o novo nó
        }

        // Percorrer e exibir todos os valores da lista
        public void Traverse()
        {
            if (Head == null) Console.WriteLine("Empty List");

            Node<T> current = Head;

            // Enquanto existir um nó, exibimos o valor e avançamos
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        // Remover nó com valor específico
        public void Remove(T data)
        {
            if (Head == null)
            {
                Console.WriteLine("Empty list");
                return;
            }

            // Inicializamos referências: current começa no segundo nó
            Node<T> current = Head.Next;
            Node<T> previous = Head;

            // Se o Head contém o valor, removemos o primeiro nó
            if (Head.Data.Equals(data))
            {
                Head = Head.Next;
                return; // Não precisamos continuar
            }

            // Percorremos a lista até encontrar o valor ou chegar ao fim
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Removemos o nó conectando o anterior ao próximo
                    previous.Next = current.Next;
                    return; // Nó removido, terminamos
                }
                else
                {
                    // Avançamos referências
                    previous = current;
                    current = current.Next;
                }
            }
        }
    }
}
