

using System.Diagnostics.CodeAnalysis;

namespace Node.StackList
{
    internal class StackList<T>
    {
        private List<T> Elements { get; set; }

        public StackList()
        {
            Elements = new List<T>();
        }


        public void Push(T element)
        {
            Elements.Add(element);
        }

        public T Pop()
        {
           if (Elements.Count == 0) { throw new InvalidOperationException("Stack is empty"); }
           T top = Elements[Elements.Count - 1];
           Elements.RemoveAt(Elements.Count - 1);
           return top;
        }
        public T Peek()
        {
            if (Elements.Count == 0) { throw new InvalidOperationException("Stack is empty"); }

            return Elements[Elements.Count - 1]; 
            
        }

        public void IsEmpty()
        {
            if (Elements.Count == 0)
                Console.WriteLine("It is empty");
            else
                Console.WriteLine("It is not empty");
        }

        
    }
}
