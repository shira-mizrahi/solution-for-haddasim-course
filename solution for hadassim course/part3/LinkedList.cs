using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution_for_hadassim_course.part3
{
    internal class LinkedList
    {
        private Node Node;
        private Node lastNode;
        public LinkedList() { 
        Node=null;
            lastNode = Node;
        }
        public void Prepend(int val)
        {
            Node temp = new Node(val, Node);
            Node = temp;
        }
        public int Pop() {
            Node n=Node;
            while (n .Next.Next!= null)
            {
                n= n.Next;
            }
            int num = n.Next.Value;
            n.Next = null;
            lastNode = n;
            return num;
        }
        public void Append(int val)
        {
            lastNode.Next = new Node(val, Node);
            lastNode = lastNode.Next;
        }
        public int Unqueue()
        {
            int value = Node.Value;
            Node=Node.Next;
            return value;
        }
        public IEnumerable<int> ToList()
        {
            Node temp = Node;
            IEnumerable<int> list = new List<int>();
            while (temp != null) { 
                list.Append(temp.Value);
                temp = temp.Next;

            }
            return list;
        }
        public bool IsCircular()
        {
            return lastNode.Next == Node;
        }
        

    }
}
