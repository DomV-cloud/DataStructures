using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace LinkedList
{
    /// <summary>
    /// Keep on mind:
    /// Important is working with references (property Next) to next Node
    /// Also keep on mind to always update Next, head (if u need) or tail (if u need)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        private int count = 0;
        //private List<Node<T>> nodes = [];

        Stopwatch stopWatch;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public Node<T>? First => head;
        public Node<T>? Last => tail;

        public Node<T> AddLast(T value)
        {
            var lastNode = new Node<T>(value);

            if (count == 0)
            {
                tail = lastNode;
                head = lastNode;
            }

            tail = lastNode;
            count++;

            return tail;
        }

        public Node<T> AddFirst(T value)
        {
            var newNode = new Node<T>(value);

            // if count is zero that means the LinkedList is empty and I am trying to init the list
            if (count == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head; // new node will be set to the old first one (current first)
                head = newNode;
            }
            count++;

            return head;
        }

        public void PrintList()
        {
            stopWatch = new Stopwatch();

            for (int i = 0; i < count; i++)
            {
                stopWatch.Start();
                var node = head.Next;

                if (head.Next != null)
                {
                    Console.WriteLine($"Node in Linked list: {head.Data}");

                    head = node;

                    continue;
                }
                else
                {
                    Console.WriteLine($"Node in Linked list: {head.Data}");

                    var elapsedMs = stopWatch.Elapsed.TotalMilliseconds;
                    Console.WriteLine($"Execution time of method {nameof(PrintList)} is: {elapsedMs}");
                    stopWatch.Stop();

                    break;
                }

            }
        }

        public void FasterPrint()
        {
            stopWatch = new Stopwatch();

            var current = head;
            while (current != null)
            {
                stopWatch.Start();
                Console.WriteLine($"Node in Linked list: {current.Data}");
                current = current.Next;
            }

            stopWatch.Stop();
            var elapsedMs = stopWatch.Elapsed.TotalMilliseconds;
            Console.WriteLine($"Execution time of method {nameof(FasterPrint)} is: {elapsedMs}");
        }
    }
}
