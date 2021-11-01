using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int New_Data)
        {
            data = New_Data;
            next = null;
        }
    }
}
