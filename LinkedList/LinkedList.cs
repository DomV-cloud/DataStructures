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
            else
            {
                tail.Next = lastNode;
                tail = lastNode;
            }

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
                newNode.Next = head; // new node will be set to the old one (current first)
                head = newNode;
            }
            count++;

            return head;
        }
    }
}
