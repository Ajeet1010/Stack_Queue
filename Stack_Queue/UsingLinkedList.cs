using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{    
    internal class UsingLinkedList
    {
        public Node top;
        // UC1- Insertion of element using LINKED LIST.
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

        // UC2- Checking STACK ISEMPTY or Not using LINKED LIST.
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("\n{0} is at the top", top.data);
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("{0} is Removed from the Stack", top.data);
            top = top.next;
        }
        public void isEmpty()
        {
            while (top != null)
            {
                Peek();
                Pop();
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
