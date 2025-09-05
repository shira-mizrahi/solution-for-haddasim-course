using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution_for_hadassim_course.part3
{
    internal class Node
    {
        public int Value { 
        get; set;
        }
        public Node Next
        {
                get; set;
        }

        public Node(int val,Node next) {
        this.Value = val;
            this.Next = next;
        }
    }
}
