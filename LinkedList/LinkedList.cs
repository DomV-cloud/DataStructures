using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private Node<T>? node = null;
        //private List<Node<T>> nodes = [];

        public Node<T> First { get; set; } = null!;
        public Node<T>? Last { get; set; }

        public Node<T> AddLast(Node<T> nodeToAddLast) 
        {
            if (nodeToAddLast.next is null && nodeToAddLast.data is not null)
            {
                Last = nodeToAddLast;
            }

            return Last;
        }

        public Node<T> AddFirst(Node<T> nodeToAddFirst) 
        {
            node = nodeToAddFirst;

            if(node.next is not null)
            {

                First = node;
            }

            return First;
        }
    }
}
