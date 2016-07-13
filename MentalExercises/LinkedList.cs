using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalExercises
{
    public class Node
    {
        public string data;
        public Node next;
        public Node prev;
    }

    /// <summary>
    /// This really is the linked list
    /// </summary>
    public class CustomLinkedList
    {
        Node current;
        Node first;
        Node last;
        public void add(Node node)
        {
            if (current == null)
            {
                current = node;
                first = current;
            }
            else
            {
                current.next = node;
                current = node;
                last = node;
            }
        }
        public void makeCircular() { last.next = first; }
        public Node getFirst() { return first; }

        /// <summary>
        /// The idea of last is not to traverse the tree again and we can jump directly.
        /// </summary>
        /// <returns></returns>
        public Node getLast() { return last; }
    }
    public class TraverseList
    {
        Node first = null;
        public void walk(Node root)
        {
            if (first == null) first = root;
            Console.WriteLine(root.data);
            if (root.next != null && root.next != first)
                this.walk(root.next);
        }

    }

    public class Find
    {
        public bool doesthisExist(CustomLinkedList list, string s)
        {
            Node root = list.getFirst();
            while(root != null)
            {
                if (root.data == s)
                {
                    return true;
                }
                root = root.next;
            }
            return false;
        }
    }


}
