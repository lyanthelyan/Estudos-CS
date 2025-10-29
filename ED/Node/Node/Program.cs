using Node.StackList;
using Node.DoublyLinkedList;
using Node.SimpleLinkedList;


internal class Program
{
    private static void Main(string[] args)
    {
        SimpleLinkedList<int> linkedList = new SimpleLinkedList<int>();
        DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();

        StackList<int> stack = new StackList<int>();


        stack.Push(1);
        stack.Push(3);
        Console.WriteLine(stack.Peek());





    }
}