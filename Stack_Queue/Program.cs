
using System.Collections.Generic;

namespace Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  STACK & QUEUE Problems");
            Console.Write("Insertion of element using: \n1. STACK.\n2. LINKED LIST.\nValidating STACK ISEMPty using:  \n3. STACK\n4. LINKED LIST." +
                "Choose option to perform:  ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your choice is: " + option + "\n");
            STACK stack = new STACK();
            UsingLinkedList list = new UsingLinkedList();

            switch (option)
            {
                case 1:
                    Console.WriteLine("\nImplentation using STACK.");                    
                    stack.Push(56);
                    stack.Push(30);
                    stack.Push(70);
                    stack.Display();
                    break;

                case 2:
                    Console.WriteLine("\nImplementation of STACK using LINKED LIST");
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.DisplayList();
                    break;

                case 3:
                    stack.Push(56);
                    stack.Push(30);
                    stack.Push(70);
                    stack.IsEmpty();
                    stack.Display();
                    break;

                case 4:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.isEmpty();
                    list.DisplayList();                    
                    break;

                default:
                    Console.WriteLine("Choose correct option");
                    break;

            }           
        }
    }
}