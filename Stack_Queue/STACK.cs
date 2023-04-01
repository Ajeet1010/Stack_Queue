using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{    
    internal class STACK
    {
        public Node top;
        // UC1- Insertion of element using STACK.
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

        // UC2- Checking STACK ISEMPTY or Not using STACK.
        //Peek method: It return the topmost item but didn't removes the top most element.
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("No elements present in the stack");
                return;
            }
        }

        //Pop method: It removes the top most element.
        public void Pop()
        {
            Console.WriteLine("Topmost element after peeking is : " + this.top.data);
            if (this.top == null)
            {
                Console.WriteLine("Topmost element present in the stack");
                return;
            }
            Peek();
            this.top = this.top.next;
        }
        //Checking the any underflow or overflow occurs(size of stack)

        public void IsEmpty()                               // IsEmpty: checking stack is empty 
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
        // displaying of node using STACK.
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("None value be is present");
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
