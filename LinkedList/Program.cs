namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<char> linkedList = new();
            
            linkedList.AddFirst('A');
            linkedList.AddFirst('B');

            Console.WriteLine($"The first node is: {linkedList.First.Data}");

            linkedList.AddLast('C');
            Console.WriteLine($"The last node is: {linkedList.Last.Data}");
        }
    }
}
