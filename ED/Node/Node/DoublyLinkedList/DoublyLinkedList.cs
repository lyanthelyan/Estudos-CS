

using System.Transactions;

namespace Node.DoublyLinkedList
{
    internal class DoublyLinkedList<T>
    {
        public Node<T> Head { get; set; }


        public void PushFront(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.Data = data;
            newNode.Previous = null;
            newNode.Next = Head;
            if (Head != null)
            {
                Head.Previous = newNode;
            }
            Head = newNode;

        }

        public void PushBack(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.Data = data;
            newNode.Next = null;

            if (Head == null)
            {
                Head = newNode;
                newNode.Previous = null;
                return;
            }

            Node<T> current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Previous = current;
        }

        public void PrintFoward()
        {
            if (Head == null) { Console.WriteLine("Empty list"); return; }

            Node<T> current = Head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public void PrintBackward()
        {
            if (Head == null) { Console.WriteLine("Empty list"); return; }
            Node<T> current = Head;



            while (current.Next != null)
            {
                current = current.Next;
            }

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Previous;
            }

        }

        public void Remove(T data)
        {
            if (Head == null){ return; }
            if(Head.Data.Equals(data))
            { 
                Head = Head.Next;
                if (Head != null) { Head.Previous = null; return; }
            }

            Node<T> current = Head;

            while (current != null)
            {
                
                if (current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                        return;
                    }
         
                }
                current = current.Next;
            }
            

        }
    }



}






