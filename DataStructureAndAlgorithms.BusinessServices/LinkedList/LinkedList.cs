using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.BusinessServices.LinkedList
{
    public class LinkedListNode<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T data)
        {
            Data = data;
        }

        public LinkedListNode()
        {

        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    public class LinkedList<T> where T : IComparable<T>
    {
        public LinkedListNode<T> ReverseLinkedList(LinkedListNode<T> node)
        {
            //initially for prev we are setting null
            return ReverseLinkedList(node, null);
        }

        private LinkedListNode<T> ReverseLinkedList(LinkedListNode<T> node,
                                                   LinkedListNode<T> prev)
        {
            LinkedListNode<T> head = null;
            if (node.Next == null)
            {//at last, set head to last node
                head = node;
            }
            else
            {// go to the last
                head = ReverseLinkedList(node.Next, node);
            }

            //while we back track, keep updating the next of the node to get reverse.
            node.Next = prev;
            return head;
        }
    }
}
