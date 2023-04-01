using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    // UC1- Insertion of element using LINKED LIST.
    internal class UsingLinkedList
    {
        public Node top;
        public void Add(int data)
        {            
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
                Console.WriteLine("{0} is inserted into Stack", top.data);
            }
            else
            {
                newNode.next = top;
                top = newNode;
                Console.WriteLine("{0} is inserted into Stack", top.data);
            }
        }

        // displaying of element inserted using linked list.
        public void DisplayList()
        {
            if (top == null)
                Console.WriteLine("\nStack is Empty");
            else
            {
                Node temp = top;
                Console.WriteLine("\nElements in Stack are:  ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
