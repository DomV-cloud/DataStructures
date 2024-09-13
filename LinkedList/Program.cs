namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<char> linkedList = new();
            Node<char> node3 = new() 
            { 
                data = 'C',
            };
            
            Node<char> node2 = new() 
            { 
                data = 'B',
                next = node3
            };
            
            Node<char> node1 = new() 
            { 
                data = 'A',
                next = node2
            };

            linkedList.AddFirst(node1);
            linkedList.AddFirst(node2);
            //linkedList.AddFirst(node1);
            Console.WriteLine($"The first node is: {linkedList.First.data}");
        }
    }
}
