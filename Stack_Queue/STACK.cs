using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    // UC1- Insertion of element using STACK.
    internal class STACK
    {
        public Node top;
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("New Node {0} is added ", newNode.data);
        }

        // displaying of node using STACK.
        // displaying node
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("None value be added");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Stack contains node:" + temp.data);
                temp = temp.next;
            }
        }
    }
}
