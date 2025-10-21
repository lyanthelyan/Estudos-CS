
namespace Node.Entities
{
    internal class Node<T>
    {
        public T Value;
        public Node<T> Next { get; set; }
    }
}
