
using System.Collections.Generic;

namespace Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  STACK & QUEUE Problems");
            Console.Write("Insertion of element using: \n1. STACK.\n2. LINKED LIST.\n" +
                "Choose option to perform:  ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your choice is: " + option + "\n");
            switch (option)
            {
                case 1:
                    Console.WriteLine("\nImplentation using STACK.");
                    STACK stack = new STACK();
                    stack.Push(56);
                    stack.Push(30);
                    stack.Push(70);
                    stack.Display();
                    break;
                case 2:
                    Console.WriteLine("\nImplementation of STACK using LINKED LIST");
                    UsingLinkedList list = new UsingLinkedList();
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.DisplayList();
                    break;
                default:
                    Console.WriteLine("Choose correct option");
                    break;

            }           
        }
    }
}