namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<char> linkedList = new();
            
            linkedList.AddFirst('C');
            linkedList.AddFirst('B');
            linkedList.AddFirst('A');

            Console.WriteLine($"The first node is: {linkedList.First.Data}");

            linkedList.AddLast('C');
            Console.WriteLine($"The last node is: {linkedList.Last.Data}");

            linkedList.FasterPrint();
        }

        public static void PerformanceTest()
        {
            LinkedList<char> linkedList = new();

            linkedList.AddFirst('C');
            linkedList.AddFirst('B');
            linkedList.AddFirst('A');

            Console.WriteLine($"The first node is: {linkedList.First.Data}");

            linkedList.AddLast('C');
            Console.WriteLine($"The last node is: {linkedList.Last.Data}");

            linkedList.PrintList();

            LinkedList<char> linkedList1 = new();

            linkedList1.AddFirst('C');
            linkedList1.AddFirst('B');
            linkedList1.AddFirst('A');

            Console.WriteLine($"The first node is: {linkedList1.First.Data}");

            linkedList1.AddLast('C');
            Console.WriteLine($"The last node is: {linkedList1.Last.Data}");

            linkedList1.FasterPrint();
        }
    }
}
